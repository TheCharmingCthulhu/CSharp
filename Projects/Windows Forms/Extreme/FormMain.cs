using System;
using System.Drawing;
using System.Windows.Forms;

namespace Extreme
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            extremeGrid1.CreateWindow(0, 0, 1, 1, Color.SkyBlue);
            extremeGrid1.CreateWindow(0, 3, 1, 1, Color.SkyBlue);
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            extremeGrid1.GridSize = Math.Max((sender as TrackBar).Value - (sender as TrackBar).Value % 8, 8);
            label1.Text = extremeGrid1.GridSize.ToString();
        }
    }
}
