using System.Windows.Forms;

namespace Motomatic.Forms
{
    public partial class FormEventChain : Form
    {
        public static string EventName { get; set; }

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
            EventName = (sender as TextBox).Text;
        }
    }
}
