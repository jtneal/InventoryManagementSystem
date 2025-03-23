using JasonNealC968.Constants;
using JasonNealC968.DAL;
using JasonNealC968.Models;
using JasonNealC968.Utilities;
using JasonNealC968.Validators;
using Microsoft.IdentityModel.Tokens;

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
            if (product.ProductID > 0)
            {
                productFormLabel.Text = "Modify Product";
                productIdTextBox.Text = product.ProductID.ToString();
                productNameTextBox.Text = product.Name;
                productInventoryNumericUpDown.Text = product.InStock.ToString();
                productPriceTextBox.Text = product.Price.ToString();
                productMaxNumericUpDown.Text = product.Max.ToString();
                productMinNumericUpDown.Text = product.Min.ToString();
            }

            candidatesDataGridView.DataSource = inventory.AllParts;
            associatedDataGridView.DataSource = product.AssociatedParts;

            candidatesDataGridView.Columns["Category"].Visible = false;
            associatedDataGridView.Columns["Category"].Visible = false;
        }

        protected void Control_Changed(object sender, EventArgs e)
        {
            saveButton.Enabled = IsFormValid();
        }

        /*************************
         * Button Event Handlers *
         *************************/

        protected void CandidatesSearchButton_Click(object sender, EventArgs e)
        {
            candidatesDataGridView.DataSource = inventory.AllParts.Where(part
                => part.Name.Contains(candidatesSearchTextBox.Text)).ToList();
        }

        protected void AssociatedAddButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(candidatesDataGridView);
            var partID = accessor.GetSelectedInt("PartID");

            if (partID == 0)
                return;

            var name = accessor.GetSelectedString("Name");
            var price = accessor.GetSelectedString("Price");
            var inStock = accessor.GetSelectedString("InStock");
            var min = accessor.GetSelectedString("Min");
            var max = accessor.GetSelectedString("Max");
            var category = accessor.GetSelectedString("Category");

            // If this product is already there we have nothing to do!
            if (!product.AssociatedParts.Where(x => x.PartID == partID).IsNullOrEmpty())
                return;

            Part part = category == PartCategory.Outsourced ? new Outsourced() : new Inhouse();

            part.PartID = partID;
            part.Name = name!;
            part.Price = decimal.Parse(price!);
            part.InStock = Convert.ToInt32(inStock);
            part.Min = Convert.ToInt32(min);
            part.Max = Convert.ToInt32(max);

            product.addAssociatedPart(part);
        }

        protected void AssociatedDeleteButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(associatedDataGridView);
            var partID = accessor.GetSelectedInt("PartID");

            if (partID == 0)
                return;

            product.removeAssociatedPart(partID);
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (productID > 0)
                product.ProductID = productID;

            product.Name = productNameTextBox.Text;
            product.InStock = Convert.ToInt32(productInventoryNumericUpDown.Text);
            product.Price = decimal.Parse(productPriceTextBox.Text);
            product.Min = Convert.ToInt32(productMinNumericUpDown.Text);
            product.Max = Convert.ToInt32(productMaxNumericUpDown.Text);

            // This will also add if the product doesn't have an ID
            inventory.updateProduct(productID, product);
            Close();
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
