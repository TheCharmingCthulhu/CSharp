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
            uctSample.Invalidate();
        }
    }
}
