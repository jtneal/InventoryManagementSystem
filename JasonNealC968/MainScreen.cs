using JasonNealC968.DAL;
using JasonNealC968.Mappers;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace JasonNealC968
{
    public partial class MainScreen : Form
    {
        private Inventory? inventory;
        private InventoryContext? context;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
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

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.DataSource = context!.Parts.Where(part
                => EF.Functions.Like(part.Name, $"%{partsSearchTextBox.Text}%")).ToList();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = context!.Products.Where(product
                => EF.Functions.Like(product.Name, $"%{productsSearchTextBox.Text}%")).ToList();
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart(inventory!);
            addPart.ShowDialog();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var firstSelectedRow = partsDataGridView.SelectedRows[0];
            var firstCell = firstSelectedRow.Cells[0].Value.ToString();

            if (firstCell is null)
            {
                return;
            }

            ModifyPart modifyPart = new ModifyPart(inventory!, int.Parse(firstCell));
            modifyPart.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
