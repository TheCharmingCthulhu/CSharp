using System;
using System.Drawing;
using System.Windows.Forms;

namespace Designer.Source.Controls
{
    public partial class DynamicPanel : UserControl
    {
        #region Attributes
        private int _InitX;
        private bool _IsCaptured;
        #endregion

        public DynamicPanel()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            Capture = _IsCaptured;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                if ((_InitX - e.X) % 32 == 0)
                {
                    // Left
                    if (_InitX > e.X)
                    {
                        Left = Left + e.X;
                        Width = Width + 32;
                    }
                }
            }
        }

        private void DynamicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _InitX = e.X - (e.X % 32);
            _IsCaptured = true;
        }

        private void DynamicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _IsCaptured = false;
        }
    }
}
