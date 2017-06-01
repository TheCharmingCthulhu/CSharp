using System;
using System.Drawing;
using System.Windows.Forms;

namespace Extreme.Controls
{
    public partial class ExtremeDragWindow : UserControl
    {
        #region Properties
        public bool Selected { get; set; } = false;

        public Guid Guid { get; set; } = Guid.NewGuid();

        public string Label { get; set; } = "";

        public int BorderSize { get; set; } = 5;

        public AnchorStyles ResizeAnchor { get; private set; } = AnchorStyles.None;
        #endregion

        public ExtremeDragWindow()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawResizeBorder(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            ResizeCursor(e);
            ResizeContainer(e);
        }

        Rectangle _OriginalBounds;
        Point _MousePoint;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            ResizeAnchor = GetResizeAnchor(e);

            if (e.Button == MouseButtons.Left)
            {
                _MousePoint = e.Location;

                if (ResizeAnchor == AnchorStyles.None)
                    Selected = !Selected;
            }

            Invalidate();
        }

        private void DrawResizeBorder(PaintEventArgs e)
        {
            if (Selected)
            {
                for (int i = 0; i < BorderSize; i++)
                    e.Graphics.DrawRectangle(Pens.Violet,
                        new Rectangle(e.ClipRectangle.Left + i, e.ClipRectangle.Top + i, e.ClipRectangle.Right - (i + 1) * 2, e.ClipRectangle.Bottom - (i + 1) * 2));
            }
        }

        private void ResizeContainer(MouseEventArgs e)
        {
            if (Selected && e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - _MousePoint.X;
                int deltaY = e.Y - _MousePoint.Y;

                if (Parent is ExtremeGrid)
                {
                    var parent = Parent as ExtremeGrid;

                    _OriginalBounds = Bounds;

                    switch (ResizeAnchor)
                    {
                        case AnchorStyles.Top:
                            Top = (Top + deltaY) - (deltaY % parent.GridSize);

                            if (parent.CheckWindowCollision(this) || !parent.CheckWindowWithinClient(this))
                                Top = _OriginalBounds.Top;

                            break;
                        case AnchorStyles.Bottom:

                            Height = e.Location.Y - (e.Location.Y % parent.GridSize) + parent.GridSize;

                            if (parent.CheckWindowCollision(this) || !parent.CheckWindowWithinClient(this))
                                Height = _OriginalBounds.Height;

                            break;
                    }

                    Refresh();
                }
            }
        }

        private AnchorStyles GetResizeAnchor(MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= BorderSize)
                return AnchorStyles.Left;
            else if (e.X >= Width - BorderSize && e.X <= Width)
                return AnchorStyles.Right;
            else if (e.Y >= 0 && e.Y < BorderSize)
                return AnchorStyles.Top;
            else if (e.Y >= Height - BorderSize && e.Y <= Height)
                return AnchorStyles.Bottom;
            else
                return AnchorStyles.None;
        }

        private void ResizeCursor(MouseEventArgs e)
        {
            if (Selected)
            {
                switch (GetResizeAnchor(e))
                {
                    case AnchorStyles.Top:
                    case AnchorStyles.Bottom:
                        Cursor = Cursors.SizeNS;
                        break;
                    case AnchorStyles.Left:
                    case AnchorStyles.Right:
                        Cursor = Cursors.SizeWE;
                        break;
                    default:
                        Cursor = Cursors.Default;
                        break;
                }
            }
        }
    }
}
