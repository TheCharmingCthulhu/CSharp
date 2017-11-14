using System;
using System.Windows.Forms;

namespace Finman.Source.Dialogs
{
    public partial class DialogItemService : Form
    {
        public static ServiceItem Item { get; set; }

        public DialogItemService()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            numericUpDownPrice.Maximum = int.MaxValue;
        }

        public static DialogResult Run(ServiceItem item = null)
        {
            Item = item == null ? new ServiceItem() : item;

            var f = new DialogItemService();
            f.InitializeForm(Item);

            return f.ShowDialog();
        }

        private void InitializeForm(ServiceItem item)
        {
            textBoxName.Text = item.Name;
            numericUpDownPrice.Value = item.Price;
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            var view = sender as TextBox;

            Item.Name = view.Text.Trim().Replace("\r\n", "");
        }

        private void numericUpDownPrice_ValueChanged(object sender, System.EventArgs e)
        {
            var view = sender as NumericUpDown;

            Item.Price = view.Value;
        }
    }
}
