using JasonNealC968.Constants;
using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Validators;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968
{
    public partial class ProductForm : Form
    {
        protected readonly Inventory inventory;
        protected readonly int productID;
        protected Product product;

        public ProductForm(Inventory inventory, int productID = 0)
        {
            this.inventory = inventory;
            this.productID = productID;

            product = inventory.lookupProduct(productID);

            InitializeComponent();
        }

        protected bool IsFormValid()
        {
            var validators = new CompositeValidator([
                new RequiredValidator([
                    productNameTextBox,
                    productInventoryNumericUpDown,
                    productPriceTextBox,
                    productMaxNumericUpDown,
                    productMinNumericUpDown,
                ]),
                new MinMaxValidator(productInventoryNumericUpDown, productMinNumericUpDown, productMaxNumericUpDown),
                new DecimalValidator([productPriceTextBox]),
                new IntegerValidator([productInventoryNumericUpDown, productMaxNumericUpDown, productMinNumericUpDown]),
            ]);

            return validators.Validate();
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        protected void ProductForm_Load(object sender, EventArgs e)
        {
            productFormLabel.Text = product.ProductID > 0 ? "Modify Product" : "Add Product";
            productIdTextBox.Text = product.ProductID > 0 ? product.ProductID.ToString() : string.Empty;
            productNameTextBox.Text = product.Name;
            productInventoryNumericUpDown.Text = product.InStock.ToString();
            productPriceTextBox.Text = product.Price > 0 ? product.Price.ToString() : string.Empty;
            productMaxNumericUpDown.Text = product.Max.ToString();
            productMinNumericUpDown.Text = product.Min.ToString();

            candidatesDataGridView.DataSource = inventory.AllParts;
            associatedDataGridView.DataSource = product.AssociatedParts;

            candidatesDataGridView.Columns["Category"].Visible = false;
            associatedDataGridView.Columns["Category"].Visible = false;
        }

        /*************************
         * Button Event Handlers *
         *************************/

        protected void candidatesSearchButton_Click(object sender, EventArgs e)
        {
            candidatesDataGridView.DataSource = inventory.AllParts.Where(part
                => part.Name.Contains(candidatesSearchTextBox.Text)).ToList();
        }

        protected void associatedAddButton_Click(object sender, EventArgs e)
        {
            if (candidatesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to add.", "No Row Selected");
                return;
            }

            var selectedRow = candidatesDataGridView.SelectedRows[0];
            var partID = selectedRow.Cells["PartID"].Value.ToString();
            var name = selectedRow.Cells["Name"].Value.ToString();
            var price = selectedRow.Cells["Price"].Value.ToString();
            var inStock = selectedRow.Cells["InStock"].Value.ToString();
            var min = selectedRow.Cells["Min"].Value.ToString();
            var max = selectedRow.Cells["Max"].Value.ToString();
            var category = selectedRow.Cells["Category"].Value.ToString();

            if (partID is null)
            {
                MessageBox.Show("Please select a row with a valid PartID.", "Part ID Not Found");
                return;
            }

            if (product.AssociatedParts.Where(x => x.PartID == Convert.ToInt32(partID)).IsNullOrEmpty())
            {
                Part part = category == PartCategory.Outsourced ? new Outsourced() : new Inhouse();

                part.PartID = Convert.ToInt32(partID);
                part.Name = name!;
                part.Price = decimal.Parse(price!);
                part.InStock = Convert.ToInt32(inStock);
                part.Min = Convert.ToInt32(min);
                part.Max = Convert.ToInt32(max);

                product.addAssociatedPart(part);
            }
        }

        protected void associatedDeleteButton_Click(object sender, EventArgs e)
        {
            if (associatedDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected");
                return;
            }

            var selectedRow = associatedDataGridView.SelectedRows[0];
            var partID = selectedRow.Cells["PartID"].Value.ToString();

            product.removeAssociatedPart(Convert.ToInt32(partID));
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (productID > 0)
                product.ProductID = productID;

            product.Name = productNameTextBox.Text;
            product.InStock = Convert.ToInt32(productInventoryNumericUpDown.Value);
            product.Price = decimal.Parse(productPriceTextBox.Text);
            product.Min = Convert.ToInt32(productMinNumericUpDown.Value);
            product.Max = Convert.ToInt32(productMaxNumericUpDown.Value);

            // This will also add if the product doesn't have an ID
            inventory.updateProduct(productID, product);
            Close();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        protected void textBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = IsFormValid();
        }
    }
}
