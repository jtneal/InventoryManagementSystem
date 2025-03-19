using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;

namespace JasonNealC968;

public partial class AddPart : Form
{
    protected readonly InventoryContext context;

    public AddPart(InventoryContext context)
    {
        this.context = context;
        InitializeComponent();
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

    protected virtual void partSaveButton_Click(object sender, EventArgs e)
    {
        context.Parts.Add(new Part
        {
            Name = partNameTextBox.Text,
            Inventory = Convert.ToInt32(partInventoryNumericUpDown.Value),
            Price = decimal.Parse(partPriceTextBox.Text),
            Min = Convert.ToInt32(partMinNumericUpDown.Value),
            Max = Convert.ToInt32(partMaxNumericUpDown.Value),
            Category = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked)?.Text,
            MachineId = partMachineIdTextBox.Text,
            CompanyName = partCompanyNameTextBox.Text,
        });

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
