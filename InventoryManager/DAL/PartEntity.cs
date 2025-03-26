using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JasonNealC968.DAL
{
    public class PartEntity : INotifyPropertyChanged
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartID { get; set; }
        public string Name { get { return m_name; } set { m_name = value; NotifyPropertyChanged("Name"); } }
        public decimal Price { get { return m_price; } set { m_price = value; NotifyPropertyChanged("Price"); } }
        public int InStock { get { return m_stock; } set { m_stock= value; NotifyPropertyChanged("InStock"); } }
        public int Min { get { return m_min; } set { m_min = value; NotifyPropertyChanged("Min"); } }
        public int Max { get { return m_max; } set { m_max = value; NotifyPropertyChanged("Max"); } }
        public string Category { get; set; } = string.Empty;
        public string? CompanyName { get; set; }
        public int? MachineID { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string m_name = string.Empty;
        private decimal m_price = decimal.Zero;
        private int m_stock = 0;
        private int m_min = 0;
        private int m_max = 0;

        private void NotifyPropertyChanged(string p)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
        }
    }
}
