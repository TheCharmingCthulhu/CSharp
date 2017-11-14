using System;
using System.Windows.Forms;

namespace Finman.Source.Dialogs
{
    public partial class DialogItemFixcost : Form
    {
        public static FixcostItem Item { get; set; } = null;

        public DialogItemFixcost()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            numericUpDownPrice.Maximum = int.MaxValue;
        }

        public static DialogResult Run(FixcostItem item = null)
        {
            Item = item == null ? new FixcostItem() : item;

            var f = new DialogItemFixcost();
            f.InitializeForm(Item);

            return f.ShowDialog();
        }

        private void InitializeForm(FixcostItem item)
        {
            textBoxName.Text = item.Name;
            numericUpDownPrice.Value = item.Price;
        }

        #region < Field - Events ->
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            var view = sender as TextBox;

            Item.Name = view.Text.Trim().Replace("\r\n", "");
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            var view = sender as NumericUpDown;

            Item.Price = view.Value;
        } 
        #endregion
    }
}
