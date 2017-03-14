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

        public static DialogResult Run<T>(T instance)
        {
            var f = new FormEventEditor();

            f.propertyGridProperties.SelectedObject = instance;

            return f.ShowDialog();
        }
    }
}
