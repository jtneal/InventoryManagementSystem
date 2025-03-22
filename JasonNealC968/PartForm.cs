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
    public partial class PartForm : Form
    {
        protected readonly Inventory inventory;
        protected readonly int partID;
        protected Part part;

        public PartForm(Inventory inventory, int partID = 0)
        {
            this.inventory = inventory;
            this.partID = partID;

            part = inventory.lookupPart(partID);

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

        /***********************
         * Form Event Handlers *
         ***********************/

        protected void ModifyPart_Load(object sender, EventArgs e)
        {
            partFormLabel.Text = part.PartID > 0 ? "Modify Part" : "Add Part";
            partIdTextBox.Text = part.PartID > 0 ? part.PartID.ToString() : string.Empty;
            partNameTextBox.Text = part.Name;
            partInventoryNumericUpDown.Text = part.InStock.ToString();
            partPriceTextBox.Text = part.Price > 0 ? part.Price.ToString() : string.Empty;
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

        /*************************
         * Button Event Handlers *
         *************************/

        protected void partCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void partSaveButton_Click(object sender, EventArgs e)
        {
            // Can't use existing part because it may be the wrong type
            Part newPart = outsourcedRadioButton.Checked
                ? new Outsourced() { CompanyName = partCompanyNameTextBox.Text }
                : new Inhouse() { MachineID = Convert.ToInt32(partMachineIdNumericUpDown.Text) };

            newPart.PartID = partID; // Need PartID set to bind the update
            newPart.Name = partNameTextBox.Text;
            newPart.InStock = Convert.ToInt32(partInventoryNumericUpDown.Value);
            newPart.Price = decimal.Parse(partPriceTextBox.Text);
            newPart.Min = Convert.ToInt32(partMinNumericUpDown.Value);
            newPart.Max = Convert.ToInt32(partMaxNumericUpDown.Value);

            inventory.updatePart(partID, newPart);
            Close();
        }

        /***********************
         * Form Event Handlers *
         ***********************/

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
