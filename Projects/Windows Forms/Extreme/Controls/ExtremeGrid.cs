using Extreme.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Extreme
{
    public partial class ExtremeGrid : UserControl
    {
        public int GridSize { get; set; } = 32;

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
            for (int x = 1; x < Width / GridSize + 1; x++)
                e.Graphics.DrawLine(Pens.Black, new Point(x * GridSize, 0), new Point(x * GridSize, Height));

            for (int y = 1; y < Height / GridSize + 1; y++)
                e.Graphics.DrawLine(Pens.Black, new Point(0, y * GridSize), new Point(Width, y * GridSize));
        }

        public void CreateWindow(int column, int row, int columnSpan, int rowSpan, Color color)
        {
            var window = new ExtremeDragWindow()
            {
                Location = new Point(GridSize * column, GridSize * row),
                Size = new Size(GridSize * columnSpan, GridSize * rowSpan),
                BackColor = color
            };

            if (!CheckWindowCollision(window))
                Controls.Add(window);
            else
                window.Dispose();
        }

        public bool CheckWindowWithinClient(ExtremeDragWindow window)
        {
            return ClientRectangle.IntersectsWith(window.Bounds);
        }

        public bool CheckWindowCollision(ExtremeDragWindow window)
        {
            // Validates Collision
            foreach (Control ctrl in Controls)
                if (ctrl is ExtremeDragWindow)
                if ((ctrl as ExtremeDragWindow).Guid != window.Guid && ctrl.Bounds.IntersectsWith(window.Bounds))
                    return true;

            return false;
        }
    }
}
