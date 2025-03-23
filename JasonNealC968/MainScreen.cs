using JasonNealC968.DAL;
using JasonNealC968.Mappers;
using JasonNealC968.Utilities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace JasonNealC968
{
    public partial class MainScreen : Form
    {
        protected Inventory? inventory;
        protected InventoryContext? context;

        public MainScreen()
        {
            InitializeComponent();
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        protected void MainScreen_Load(object sender, EventArgs e)
        {
            context = new InventoryContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Parts.Load();
            context.Products.Load();

            var parts = context.Parts.Local.ToBindingList();
            var products = context.Products.Local.ToBindingList();

            inventory = new Inventory(context)
            {
                AllParts = PartMapper.ToPartModels(parts),
                Products = ProductMapper.ToProductModels(products),
            };

            partsDataGridView.DataSource = parts;
            productsDataGridView.DataSource = products;

            partsDataGridView.Columns["Category"].Visible = false;
            partsDataGridView.Columns["CompanyName"].Visible = false;
            partsDataGridView.Columns["MachineID"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            context?.Dispose();
            context = null;
        }

        /*************************
         * Button Event Handlers *
         *************************/

        protected void PartsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.DataSource = inventory!.AllParts
                .Where(part => part.Name.Contains(partsSearchTextBox.Text))
                .ToList();
        }

        protected void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = inventory!.Products
                .Where(product => product.Name.Contains(productsSearchTextBox.Text))
                .ToList();
        }

        protected void PartsAddButton_Click(object sender, EventArgs e)
        {
            var partForm = new PartForm(inventory!);
            partForm.ShowDialog();
        }

        protected void ProductsAddButton_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm(inventory!);
            productForm.ShowDialog();
        }

        protected void PartsModifyButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(partsDataGridView);
            var partID = accessor.GetSelectedInt("PartID");

            if (partID == 0)
                return;

            var partForm = new PartForm(inventory!, partID);
            partForm.ShowDialog();
        }

        protected void ProductsModifyButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(productsDataGridView);
            var productID = accessor.GetSelectedInt("ProductID");

            if (productID == 0)
                return;

            var productForm = new ProductForm(inventory!, productID);
            productForm.ShowDialog();
        }

        protected void PartsDeleteButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(partsDataGridView);
            var partID = accessor.GetSelectedInt("PartID");

            if (partID == 0)
                return;

            var part = inventory!.lookupPart(partID);

            if (inventory!.isPartAssociated(partID))
            {
                MessageBox.Show("Parts associated to products cannot be deleted.", "Error");
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this part?\n\nPart ID: {part.PartID}\nPart Name: {part.Name}", "Are you sure?",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                inventory!.deletePart(part);
        }

        protected void ProductsDeleteButton_Click(object sender, EventArgs e)
        {
            var accessor = new DataGridViewAccessor(productsDataGridView);
            var productID = accessor.GetSelectedInt("ProductID");

            if (productID == 0)
                return;

            var product = inventory!.lookupProduct(productID);

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this product?\n\nProduct ID: {product.ProductID}\nProduct Name: {product.Name}", "Are you sure?",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                inventory!.removeProduct(product.ProductID);
        }

        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
