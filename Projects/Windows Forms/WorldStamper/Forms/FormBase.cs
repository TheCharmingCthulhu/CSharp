using System.Windows.Forms;

namespace WorldStamper.Forms
{
    public class FormBase : Form
    {
        public FormBase() : base()
        {
            StartPosition = FormStartPosition.CenterParent;

            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
