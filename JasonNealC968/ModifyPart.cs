using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;

namespace JasonNealC968;

public partial class ModifyPart : Form
{
    protected readonly Inventory inventory;
    private readonly int partID;
    private Part? part;

    public ModifyPart(Inventory inventory, int partID)
    {
        this.inventory = inventory;
        this.partID = partID;
        InitializeComponent();
    }

    private void ModifyPart_Load(object sender, EventArgs e)
    {
        part = inventory.lookupPart(partID);

        if (part.PartID != partID)
        {
            Close();
            return;
        }

        partIdTextBox.Text = part.PartID.ToString();
        partNameTextBox.Text = part.Name;
        partInventoryNumericUpDown.Text = part.InStock.ToString();
        partPriceTextBox.Text = part.Price.ToString();
        partMaxNumericUpDown.Text = part.Max.ToString();
        partMinNumericUpDown.Text = part.Min.ToString();

        if (part is Outsourced outsourced)
        {
            partCompanyNameTextBox.Text = outsourced.CompanyName;
            outsourcedRadioButton.Checked = true;
        }
        else if (part is Inhouse inhouse)
        {
            partMachineIdNumericUpDown.Text = inhouse.MachineID.ToString();
            inHouseRadioButton.Checked = true;
        }

        radioButton_CheckedChanged(this, new EventArgs());
    }

    protected bool IsFormValid()
    {
        var validators = new CompositeValidator([
            new RequiredValidator([
                partNameTextBox,
                partInventoryNumericUpDown,
                partPriceTextBox,
                partMaxNumericUpDown,
                partMinNumericUpDown,
                outsourcedRadioButton.Checked ? partCompanyNameTextBox : partMachineIdNumericUpDown,
            ]),
            new RadioCheckedValidator([inHouseRadioButton, outsourcedRadioButton]),
            new MinMaxValidator(partInventoryNumericUpDown, partMinNumericUpDown, partMaxNumericUpDown),
            new DecimalValidator([partPriceTextBox]),
            new IntegerValidator([
                partInventoryNumericUpDown,
                partMaxNumericUpDown,
                partMinNumericUpDown,
                partMachineIdNumericUpDown,
            ]),
        ]);

        return validators.Validate();
    }

    protected void partCancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected void partSaveButton_Click(object sender, EventArgs e)
    {
        Part newPart = outsourcedRadioButton.Checked
            ? new Outsourced() { CompanyName = partCompanyNameTextBox.Text }
            : new Inhouse() { MachineID = Convert.ToInt32(partMachineIdNumericUpDown.Text) };

        newPart.PartID = part!.PartID; // Need PartID set to bind the update
        newPart.Name = partNameTextBox.Text;
        newPart.InStock = Convert.ToInt32(partInventoryNumericUpDown.Value);
        newPart.Price = decimal.Parse(partPriceTextBox.Text);
        newPart.Min = Convert.ToInt32(partMinNumericUpDown.Value);
        newPart.Max = Convert.ToInt32(partMaxNumericUpDown.Value);

        inventory.updatePart(partID, newPart);
        Close();
    }

    protected void textBox_TextChanged(object sender, EventArgs e)
    {
        partSaveButton.Enabled = IsFormValid();
    }

    protected void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        partMachineIdLabel.Visible = inHouseRadioButton.Checked;
        partMachineIdNumericUpDown.Visible = inHouseRadioButton.Checked;
        partCompanyNameLabel.Visible = outsourcedRadioButton.Checked;
        partCompanyNameTextBox.Visible = outsourcedRadioButton.Checked;
        partSaveButton.Enabled = IsFormValid();
    }
}
