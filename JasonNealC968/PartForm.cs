using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;

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
            if (part.PartID > 0)
            {
                partFormLabel.Text = "Modify Part";
                partIdTextBox.Text = part.PartID.ToString();
                partNameTextBox.Text = part.Name;
                partInventoryNumericUpDown.Text = part.InStock.ToString();
                partPriceTextBox.Text = part.Price.ToString();
                partMaxNumericUpDown.Text = part.Max.ToString();
                partMinNumericUpDown.Text = part.Min.ToString();
            }

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

            Control_Changed(this, new EventArgs());
        }

        protected void Control_Changed(object sender, EventArgs e)
        {
            partMachineIdLabel.Visible = inHouseRadioButton.Checked;
            partMachineIdNumericUpDown.Visible = inHouseRadioButton.Checked;
            partCompanyNameLabel.Visible = outsourcedRadioButton.Checked;
            partCompanyNameTextBox.Visible = outsourcedRadioButton.Checked;
            partSaveButton.Enabled = IsFormValid();
        }

        /*************************
         * Button Event Handlers *
         *************************/

        protected void PartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void PartSaveButton_Click(object sender, EventArgs e)
        {
            // Can't use existing part because it may be the wrong type
            Part newPart = outsourcedRadioButton.Checked
                ? new Outsourced() { CompanyName = partCompanyNameTextBox.Text }
                : new Inhouse() { MachineID = Convert.ToInt32(partMachineIdNumericUpDown.Text) };

            if (partID > 0)
                newPart.PartID = partID;

            newPart.Name = partNameTextBox.Text;
            newPart.InStock = Convert.ToInt32(partInventoryNumericUpDown.Text);
            newPart.Price = decimal.Parse(partPriceTextBox.Text);
            newPart.Min = Convert.ToInt32(partMinNumericUpDown.Text);
            newPart.Max = Convert.ToInt32(partMaxNumericUpDown.Text);

            // This will also add if the part doesn't have an ID
            inventory.updatePart(partID, newPart);
            Close();
        }
    }
}
