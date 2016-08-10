using System;
using System.Windows.Forms;

namespace Timebar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            uctSample.RefreshControls();
            uctSample.Refresh();
        }

        private void trackBarScale_ValueChanged(object sender, EventArgs e)
        {
            ucTimebar.Timebar.Scale = trackBarScale.Value;

            uctSample.RefreshControls();
            uctSample.Refresh();
        }
    }
}
