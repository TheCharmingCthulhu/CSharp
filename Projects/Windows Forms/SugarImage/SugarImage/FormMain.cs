using SugarImage.Source;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SugarImage
{
    public partial class FormMain : Form
    {
        string _ForegroundColor = "000000", _BackgroundColor = "cccccc";
        bool _Update = false;

        ImageService _Service = new ImageService();


        public FormMain()
        {
            InitializeComponent();
            InitializeViews();
        }

        private void InitializeViews()
        {
            toolStripTextBoxWidth.Text = Properties.Settings.Default.Width.ToString();
            toolStripTextBoxHeight.Text = Properties.Settings.Default.Height.ToString();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            GenerateImage();
        }

        private void toolStripTextBox_Leave(object sender, EventArgs e)
        {
            GenerateImage();
        }

        private async void toolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!_Update)
            {
                _Update = true;

                await System.Threading.Tasks.Task.Delay(250);

                GenerateImage();

                _Update = false;
            }
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files (*.jpg, *.bmp, *.gif, *.png)|*.jpg; *.bmp; *.gif; *.png";
            
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                switch (System.IO.Path.GetExtension(sfd.FileName))
                {
                    case ".jpg":
                        pictureBoxImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case ".bmp":
                        pictureBoxImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".gif":
                        pictureBoxImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case ".png":
                        pictureBoxImage.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    default:
                        return;
                }
            }
        }

        private async void GenerateImage()
        {
            int width, height;
            int.TryParse(toolStripTextBoxWidth.Text, out width);
            int.TryParse(toolStripTextBoxHeight.Text, out height);

            Properties.Settings.Default.Width = Convert.ToInt16(width);
            Properties.Settings.Default.Height = Convert.ToInt16(height);
            Properties.Settings.Default.Save();

            pictureBoxImage.Image = await _Service.Generate(width, height, _BackgroundColor, _ForegroundColor, toolStripTextBoxText.Text);
            pictureBoxImage.BackColor = ColorTranslator.FromHtml("#" + _BackgroundColor);

            UpdateForm();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) _BackgroundColor = cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2");

            GenerateImage();
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) _ForegroundColor = cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2");

            GenerateImage();
        }

        private void UpdateForm()
        {
            Width = Math.Min(Math.Max(pictureBoxImage.Image.Width, 640), 1920);
            Height = Math.Min(Math.Max(pictureBoxImage.Image.Height, 480), 1080);
        }
    }
}
