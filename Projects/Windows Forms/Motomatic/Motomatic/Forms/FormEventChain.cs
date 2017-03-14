using System.Windows.Forms;

namespace Motomatic.Forms
{
    public partial class FormEventChain : Form
    {
        public static string EventChainName { get; set; }

        public FormEventChain()
        {
            InitializeComponent();
        }

        internal static DialogResult Run()
        {
            var f = new FormEventChain();

            return f.ShowDialog();
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            EventChainName = (sender as TextBox).Text;
        }
    }
}
