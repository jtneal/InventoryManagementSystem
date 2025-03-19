using JasonNealC968.DAL;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace JasonNealC968
{
    public partial class MainScreen : Form
    {
        private InventoryContext? dbContext;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            dbContext = new InventoryContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.Parts.Load();
            dbContext.Products.Load();
            partsDataGridView.DataSource = dbContext.Parts.Local.ToBindingList();
            productsDataGridView.DataSource = dbContext.Products.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            dbContext?.Dispose();
            dbContext = null;
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.DataSource = dbContext!.Parts.Where(part => EF.Functions.Like(part.Name, $"%{partsSearchTextBox.Text}%")).ToList();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = dbContext!.Products.Where(product => EF.Functions.Like(product.Name, $"%{productsSearchTextBox.Text}%")).ToList();
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart(dbContext!);
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

            ModifyPart modifyPart = new ModifyPart(dbContext!, int.Parse(firstCell));
            modifyPart.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
