using JasonNealC968.DAL;
using JasonNealC968.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            inventory = new Inventory(context);
            inventory.AllParts = PartMapper.ToPartModels(parts);
            inventory.Products = ProductMapper.ToProductModels(products);

            partsDataGridView.DataSource = parts;
            productsDataGridView.DataSource = products;
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

        protected void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.DataSource = context!.Parts.Where(part
                => EF.Functions.Like(part.Name, $"%{partsSearchTextBox.Text}%")).ToList();
        }

        protected void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = context!.Products.Where(product
                => EF.Functions.Like(product.Name, $"%{productsSearchTextBox.Text}%")).ToList();
        }

        protected void partsAddButton_Click(object sender, EventArgs e)
        {
            var partForm = new PartForm(inventory!);
            partForm.ShowDialog();
        }

        protected void productsAddButton_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm(inventory!);
            productForm.ShowDialog();
        }

        protected void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "No Row Selected");
                return;
            }

            var selectedRow = partsDataGridView.SelectedRows[0];
            var partID = selectedRow.Cells["PartID"].Value.ToString();

            if (partID is null)
            {
                MessageBox.Show("Please select a row with a valid PartID.", "Part ID Not Found");
                return;
            }

            var partForm = new PartForm(inventory!, int.Parse(partID));
            partForm.ShowDialog();
        }

        protected void productsModifyButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "No Row Selected");
                return;
            }

            var selectedRow = productsDataGridView.SelectedRows[0];
            var productID = selectedRow.Cells["ProductID"].Value.ToString();

            if (productID is null)
            {
                MessageBox.Show("Please select a row with a valid ProductID.", "Product ID Not Found");
                return;
            }

            var productForm = new ProductForm(inventory!, int.Parse(productID));
            productForm.ShowDialog();
        }

        protected void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected");
                return;
            }

            var selectedRow = partsDataGridView.SelectedRows[0];
            var partID = selectedRow.Cells["PartID"].Value.ToString();

            if (partID is null)
            {
                MessageBox.Show("Please select a row with a valid PartID.", "Part ID Not Found");
                return;
            }

            var part = inventory!.lookupPart(int.Parse(partID));

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this part?\n\nPart ID: {part.PartID}\nPart Name: {part.Name}", "Are you sure?",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                inventory!.deletePart(part);
        }

        protected void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected");
                return;
            }

            var selectedRow = productsDataGridView.SelectedRows[0];
            var productID = selectedRow.Cells["ProductID"].Value.ToString();

            if (productID is null)
            {
                MessageBox.Show("Please select a row with a valid ProductID.", "Product ID Not Found");
                return;
            }

            var product = inventory!.lookupProduct(int.Parse(productID));

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete this product?\n\nProduct ID: {product.ProductID}\nProduct Name: {product.Name}", "Are you sure?",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                inventory!.removeProduct(product.ProductID);
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
