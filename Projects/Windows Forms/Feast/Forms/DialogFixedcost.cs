using Feast.Sources;
using System;
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

        internal static DialogResult RunCreate()
        {
            var f = new DialogFixedcost();

            Icon = null;
            Description = null;
            Sum = -1;

            return f.ShowDialog();
        }

        private void UpdateForm()
        {
            pictureBoxIcon.Image = Icon;
            pictureBoxIcon.Tag = Icon.Tag;
            textBoxDescription.Text = Description;
            numericUpDownSum.Value = Sum;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            if (pictureBoxIcon.Image != null && pictureBoxIcon.Image.Tag != null && !string.IsNullOrEmpty(textBoxDescription.Text) && numericUpDownSum.Value > -1)
            {
                Icon = pictureBoxIcon.Image;
                Icon.Tag = pictureBoxIcon.Image.Tag;
                Description = textBoxDescription.Text;
                Sum = numericUpDownSum.Value;

                DialogResult = DialogResult.OK;
            }
            else
            {
                if (pictureBoxIcon.Image == null || pictureBoxIcon.Image.Tag == null)
                    MessageBox.Show("Please select an image.", "Missing Image");
            }
        }

        internal static DialogResult RunEdit(Fixcost item)
        {
            var f = new DialogFixedcost();

            Icon = item.Icon;
            Description = item.Description;
            Sum = item.Sum;

            f.UpdateForm();

            return f.ShowDialog();
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
