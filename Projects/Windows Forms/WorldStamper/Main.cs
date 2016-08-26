using System.Drawing;
using System.Windows.Forms;

namespace WorldStamper
{
    public partial class Main : Form
    {
        const bool _DEBUG = true;

        public Main()
        {
            InitializeComponent();
            InitializeView();
            InitializeDebug();
        }

        private void InitializeView()
        {

        }

        private void InitializeDebug()
        {
            if (_DEBUG)
            {
                mapGrid1.Invalidate();
            }
        }
    }
}
