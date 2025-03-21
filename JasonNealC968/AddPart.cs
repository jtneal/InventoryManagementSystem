using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968
{
    public partial class AddPart : Form
    {
        protected readonly Inventory inventory;

        public AddPart(Inventory inventory)
        {
            this.inventory = inventory;
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
            Part part = outsourcedRadioButton.Checked
                ? new Outsourced() { CompanyName = partCompanyNameTextBox.Text }
                : new Inhouse() { MachineID = Convert.ToInt32(partMachineIdNumericUpDown.Text) };

            part.Name = partNameTextBox.Text;
            part.InStock = Convert.ToInt32(partInventoryNumericUpDown.Value);
            part.Price = decimal.Parse(partPriceTextBox.Text);
            part.Min = Convert.ToInt32(partMinNumericUpDown.Value);
            part.Max = Convert.ToInt32(partMaxNumericUpDown.Value);

            inventory.addPart(part);
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
}
