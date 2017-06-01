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
    }
}
