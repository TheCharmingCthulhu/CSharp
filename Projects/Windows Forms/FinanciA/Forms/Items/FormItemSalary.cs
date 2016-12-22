using MetroFramework.Forms;
using System.Globalization;
using System.Windows.Forms;
using FinanciA.Source;

namespace FinanciA.Forms.Items
{
    public partial class FormItemSalary : MetroForm
    {
        public static Salary Item { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public FormItemSalary()
        {
            InitializeComponent();
        }

        public static DialogResult Run(Salary item = null)
        {
            Item = null;

            var f = new FormItemSalary();

            if (item != null)
            {
                f.Description = item.Description;
                f.Price = item.Price;
            }

            return f.ShowDialog();
        }

        private void textBoxPrice_TextChanged(object sender, System.EventArgs e)
        {
            decimal price = 0;
            decimal.TryParse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out price);

            if (price > 0) Price = price;
            else (sender as TextBox).Clear();
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            Description = (sender as TextBox).Text.Trim();
        }

        private void metroButtonOk_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Description) && Price > 0)
            {
                Item = new Salary()
                {
                    Description = Description,
                    Price = Price
                };

                DialogResult = DialogResult.OK;
            } 
            else
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormItemSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) metroButtonOk_Click(metroButtonOk, e);
        }
    }
}
