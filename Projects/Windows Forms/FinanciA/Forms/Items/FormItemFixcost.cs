using FinanciA.Source;
using MetroFramework.Forms;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace FinanciA.Forms.Fixcosts
{
    public partial class FormItemFixcost : MetroForm
    {
        public static Fixcost Item { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public Bitmap Image { get; set; } = null;

        public FormItemFixcost()
        {
            InitializeComponent();
        }

        public static DialogResult Run(CurrencyDataItem fixcostItem = null)
        {
            Item = null;

            var f = new FormItemFixcost();

            if (fixcostItem != null)
            {
                f.Title = fixcostItem.Name;
                f.Description = fixcostItem.Description;
                f.Price = fixcostItem.Price;
                f.Image = fixcostItem.Icon;
            }

            f.InitializeForm();

            return f.ShowDialog();
        }

        private void InitializeForm()
        {
            textBoxName.Text = Title;
            textBoxDescription.Text = Description;
            textBoxPrice.Text = Price.ToString("C2");
            pictureBoxImage.Image = Image;
        }

        #region <- Fields ->
        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            Title = (sender as TextBox).Text.Trim();
            
            Text = !string.IsNullOrEmpty(Title) ? Title : "N/A";

            Invalidate();
        }

        private void textBoxDescription_TextChanged(object sender, System.EventArgs e)
        {
            Description = (sender as TextBox).Text.Trim();
        }

        private void textBoxPrice_TextChanged(object sender, System.EventArgs e)
        {
            decimal price = 0;
            decimal.TryParse((sender as TextBox).Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out price);

            if (price > 0) Price = price;
        }

        private void metroButtonOk_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Title) && Price > 0)
            {
                Item = new Fixcost()
                {
                    Name = Title,
                    Description = Description,
                    Price = Price,
                    Icon = Image
                };

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Überprüfen Sie den Namen und den Preis", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion

        private void FormFixcostItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) e.Handled = true;
            if (e.KeyCode == Keys.Enter) metroButtonOk_Click(metroButtonOk, e);
        }
    }
}
