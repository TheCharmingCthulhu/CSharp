using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Feast.Forms
{
    public partial class DialogFixedcost : Form
    {
        public static new Image Icon { get; set; }
        public static string Description { get; set; }
        public static decimal Sum { get; set; }

        public DialogFixedcost()
        {
            InitializeComponent();
        }

        internal static DialogResult Run()
        {
            var f = new DialogFixedcost();

            Icon = null;
            Description = null;
            Sum = -1;

            return f.ShowDialog();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            if (pictureBoxIcon.Image != null && !string.IsNullOrEmpty(textBoxDescription.Text) && numericUpDownSum.Value > -1)
            {
                Icon = pictureBoxIcon.Image;
                Icon.Tag = pictureBoxIcon.Image.Tag;
                Description = textBoxDescription.Text;
                Sum = numericUpDownSum.Value;

                DialogResult = DialogResult.OK;
            }
        }

        private void pictureBoxIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxIcon.Image = new Bitmap(ofd.FileName);
                pictureBoxIcon.Image.Tag = Path.GetFileName(ofd.FileName);
            }
        }
    }
}
