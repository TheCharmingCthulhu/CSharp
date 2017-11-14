using Extreme.Controls;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Extreme
{
    public partial class ExtremeGrid : UserControl
    {
        int _GridSize = 32;

        public int GridSize
        {
            get { return _GridSize; }
            set { _GridSize = value; Invalidate(); }
        }

        public ExtremeGrid()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawGrid(e);
        }

        private void DrawGrid(PaintEventArgs e)
        {
            for (int x = 1; x < Width / _GridSize + 1; x++)
                e.Graphics.DrawLine(Pens.Black, new Point(x * _GridSize, 0), new Point(x * _GridSize, Height));

            for (int y = 1; y < Height / _GridSize + 1; y++)
                e.Graphics.DrawLine(Pens.Black, new Point(0, y * _GridSize), new Point(Width, y * _GridSize));
        }

        public void CreateWindow(int column, int row, int columnSpan, int rowSpan, Color color)
        {
            var window = new ExtremeDragWindow()
            {
                Location = new Point(_GridSize * column, _GridSize * row),
                Size = new Size(_GridSize * columnSpan, _GridSize * rowSpan),
                BackColor = color
            };

            if (!CheckWindowCollision(window))
                Controls.Add(window);
            else
                window.Dispose();
        }

        public void SelectWindow(ExtremeDragWindow window)
        {
            foreach (var ctrl in Controls.OfType<ExtremeDragWindow>()) {
                if (ctrl.Guid.Equals(window.Guid))
                    ctrl.Selected = true;
                else
                    ctrl.Selected = false;

                ctrl.Invalidate();
            };
        }

        public bool CheckWindowWithinClient(ExtremeDragWindow window)
        {
            return ClientRectangle.IntersectsWith(window.Bounds);
        }

        public bool CheckWindowCollision(ExtremeDragWindow window)
        {
            foreach (var ctrl in Controls.OfType<ExtremeDragWindow>())
                if (ctrl.Guid != window.Guid && ctrl.Bounds.IntersectsWith(window.Bounds))
                    return true;

            return false;
        }
    }
}
