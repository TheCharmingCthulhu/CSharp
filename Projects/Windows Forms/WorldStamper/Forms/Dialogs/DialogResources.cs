using System.Windows.Forms;
using WorldStamper.Sources.Interfaces;

namespace WorldStamper.Forms.Dialogs
{
    public partial class DialogResources : DialogBase
    {
        public DialogResources()
        {
            InitializeComponent();
        }

        internal static DialogResult Run(string title, string description, IResource[] resources)
        {
            var f = new DialogResources();

            f.Text = title;
            f.labelDescription.Text = description;

            foreach (var resource in resources)
                f.listBoxResources.Items.Add(string.Format("\"{0}\"", resource.GetFilename()));

            return f.ShowDialog();
        }
    }
}
