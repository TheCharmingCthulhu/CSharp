using Motomatic.Source.Automating;
using System.Windows.Forms;

namespace Motomatic.Forms
{
    public partial class FormEventEditor : Form
    {
        public FormEventEditor()
        {
            InitializeComponent();
        }

        public static DialogResult Run<T>(string eventCaption, T instance)
        {
            var f = new FormEventEditor();
            f.labelEventName.Text = eventCaption;
            f.propertyGridProperties.SelectedObject = instance;

            return f.ShowDialog();
        }

        private void propertyGridProperties_Click(object sender, System.EventArgs e)
        {

        }
    }
}
