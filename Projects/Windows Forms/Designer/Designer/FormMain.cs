using Designer.Source;
using System.Windows.Forms;

namespace Designer
{
    public partial class FormMain : Form
    {
        Matrix matrix;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            matrix = new Matrix(4, 4, 2);
            matrix[0, 0, 0] = 1; 
        }
    }
}
