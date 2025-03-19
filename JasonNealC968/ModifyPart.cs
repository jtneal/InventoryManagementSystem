using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;

namespace JasonNealC968;

public partial class ModifyPart : Form
{
    protected readonly InventoryContext context;
    private readonly int partID;
    private Part? part;

    public ModifyPart(InventoryContext context, int partID)
    {
        this.context = context;
        this.partID = partID;
        InitializeComponent();
    }

    private void ModifyPart_Load(object sender, EventArgs e)
    {
        part = context.Parts.Find(partID);

        if (part is null)
        {
            Close();
            return;
        }

        partIdTextBox.Text = part.PartID.ToString();
        partNameTextBox.Text = part.Name;
        partInventoryNumericUpDown.Text = part.Inventory.ToString();
        partPriceTextBox.Text = part.Price.ToString();
        partMaxNumericUpDown.Text = part.Max.ToString();
        partMinNumericUpDown.Text = part.Min.ToString();
        partMachineIdTextBox.Text = part.MachineId;
        partCompanyNameTextBox.Text = part.CompanyName;
        inHouseRadioButton.Checked = part.Category == "In-House";
        outsourcedRadioButton.Checked = part.Category == "Outsourced";
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
            ]),
            new MinMaxValidator(partInventoryNumericUpDown, partMinNumericUpDown, partMaxNumericUpDown),
            new NumericValidator(partPriceTextBox),
        ]);

        return validators.Validate();
    }

    protected void partCancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected void partSaveButton_Click(object sender, EventArgs e)
    {
        if (part is null)
        {
            Close();
            return;
        }

        part.Name = partNameTextBox.Text;
        part.Inventory = Convert.ToInt32(partInventoryNumericUpDown.Value);
        part.Price = decimal.Parse(partPriceTextBox.Text);
        part.Min = Convert.ToInt32(partMinNumericUpDown.Value);
        part.Max = Convert.ToInt32(partMaxNumericUpDown.Value);
        part.Category = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked)?.Text;
        part.MachineId = partMachineIdTextBox.Text;
        part.CompanyName = partCompanyNameTextBox.Text;
        context.SaveChanges();
        Close();
    }

    protected void textBox_TextChanged(object sender, EventArgs e)
    {
        partSaveButton.Enabled = IsFormValid();
    }

    protected void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        partMachineIdLabel.Visible = inHouseRadioButton.Checked;
        partMachineIdTextBox.Visible = inHouseRadioButton.Checked;
        partCompanyNameLabel.Visible = outsourcedRadioButton.Checked;
        partCompanyNameTextBox.Visible = outsourcedRadioButton.Checked;
    }
}
