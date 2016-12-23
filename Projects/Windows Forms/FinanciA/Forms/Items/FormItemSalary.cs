using MetroFramework.Forms;
using System.Globalization;
using System.Windows.Forms;
using FinanciA.Source;
using System;

namespace FinanciA.Forms.Items
{
    public partial class FormItemSalary : MetroForm
    {
        public static Salary Item { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public FormItemSalary()
        {
            InitializeComponent();
        }

        public static DialogResult Run(Salary item = null)
        {
            Item = null;

            var f = new FormItemSalary();
            f.Date = new DateTime(DateTime.Now.Year, 1, 1);

            if (item != null)
            {
                f.Description = item.Description;
                f.Price = item.Price;
            }

            f.InitializeForm();

            return f.ShowDialog();
        }

        private void InitializeForm()
        {
            textBoxDescription.Text = Description;
            textBoxPrice.Text = Price.ToString("C2");
            maskedTextBoxPayment.Text = Date.ToString();
        }

        private void textBoxPrice_TextChanged(object sender, System.EventArgs e)
        {
            decimal price = 0;
            decimal.TryParse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out price);

            if (price > 0) Price = price;
            else (sender as TextBox).Clear();
        }

        private void textBoxDescription_TextChanged(object sender, System.EventArgs e)
        {
            Description = (sender as TextBox).Text.Trim();
        }

        private void maskedTextBoxDate_TextChanged(object sender, EventArgs e)
        {
            DateTime date;

            if (!DateTime.TryParse((sender as MaskedTextBox).Text + "." + DateTime.Now.Month + "." + DateTime.Now.Year.ToString(), out date))
                (sender as MaskedTextBox).Text = "__";
            else {
                if (date.Day > 30) { (sender as MaskedTextBox).Text = "__"; }
                else Date = date;
            }
        }

        private void maskedTextBoxPayment_Click(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Clear();
        }

        private void metroButtonOk_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Description) && Price > 0 && Date != DateTime.Parse("01.01.0001"))
            {
                Item = new Salary()
                {
                    Description = Description,
                    Price = Price,
                    Payment = Date.Day
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
