namespace JasonNealC968.Utilities
{
    public class DataGridViewAccessor(DataGridView dataGridView)
    {
        public int GetSelectedInt(string columnName)
        {
            var value = GetSelectedString(columnName);

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please select a row with an ID.", "ID Not Found");
                return 0;
            }

            return int.Parse(value);
        }

        public string GetSelectedString(string columnName)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.", "No Row Selected");
                return string.Empty;
            }

            return dataGridView.SelectedRows[0].Cells[columnName].Value.ToString() ?? string.Empty;
        }
    }
}
