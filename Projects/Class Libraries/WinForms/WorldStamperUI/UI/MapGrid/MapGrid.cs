using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WorldStamper.Sources.Utilities;
using WorldStamperUI.UI.MapGrid;

namespace WorldStamper.Sources.UI
{
    public partial class MapGrid : UserControl
    {
        public int GridWidth { get; set; } = 20;
        public int GridHeight { get; set; } = 20;

        public int CellWidth { get; set; } = 32;
        public int CellHeight { get; set; } = 32;

        private int _OffsetX = 0, _OffsetY = 0;
        private Bitmap[,] _Grid;

        private FocusRectangle _Hightlight;

        public MapGrid()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            _Grid = new Bitmap[GridWidth, GridHeight];

            _Hightlight = new FocusRectangle();
        }

        #region <- Functions ->
        public void AddImage(int x, int y, Image image)
        {
            _Grid[x, y] = new Bitmap(image);
        }
        #endregion

        #region <- UI Functions ->
        public Point MouseToCoordinates(Point location)
        {
            if (location.X >= 0 && location.X <= (GridWidth * CellWidth) - (_OffsetX * CellWidth) - 1 && 
                location.Y >= 0 && location.Y <= (GridHeight * CellHeight) - (_OffsetY * CellHeight) - 1)
                return new Point(location.X / CellWidth, location.Y / CellHeight);

            return new Point(-1, -1);
        }

        private Size GetGridSize()
        {
            return new Size(GridWidth * CellWidth, GridHeight * CellHeight);
        }
        #endregion

        #region <- Parent Form ->
        private void ParentForm_Resize(object sender, EventArgs e)
        {
            var view = (sender as Form);

            ResetGrid(view);
        }

        private void ResetGrid(Form view)
        {
            if (view.WindowState == FormWindowState.Maximized)
            {
                _OffsetX = 0;
                _OffsetY = 0;
            }
        }
        #endregion

        #region <- User Control ->
        protected override void OnLoad(EventArgs e)
        {
            if (Width % CellWidth != 0) Width -= Width % CellWidth - 1;
            if (Height % CellHeight != 0) Height -= Height % CellHeight - 1;

            ParentForm.Resize += ParentForm_Resize;

            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            ResizeUpdateGrid();

            base.OnResize(e);
        }

        private void ResizeUpdateGrid()
        {
            int horizontalWidth = GridWidth * CellWidth + vScrollBar.Width + hScrollBar.LargeChange + CellWidth;
            hScrollBar.Visible = horizontalWidth > Width;
            hScrollBar.Maximum = hScrollBar.Visible ? horizontalWidth - Width : Width;
            hScrollBar.Value = 0;

            int verticalWidth = GridHeight * CellHeight + hScrollBar.Height + vScrollBar.LargeChange + CellHeight;
            vScrollBar.Visible = verticalWidth > Height;
            vScrollBar.Maximum = vScrollBar.Visible ? verticalWidth - Height : Height;
            vScrollBar.Value = 0;

            _OffsetX = 0;
            _OffsetY = 0;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int oldValue = vScrollBar.Value;
            int delta = vScrollBar.LargeChange + Math.Abs(e.Delta) / 4;

            if (e.Delta < 0)
                if (vScrollBar.Maximum > vScrollBar.Value + delta)
                {
                    vScrollBar.Value += delta;

                    vScrollBar_Scroll(vScrollBar, new ScrollEventArgs(ScrollEventType.LargeIncrement, oldValue, vScrollBar.Value));
                }
                else vScrollBar.Value = vScrollBar.Maximum;
            if (e.Delta > 0)
                if (vScrollBar.Minimum < vScrollBar.Value - delta)
                {
                    vScrollBar.Value -= delta;

                    vScrollBar_Scroll(vScrollBar, new ScrollEventArgs(ScrollEventType.LargeDecrement, oldValue, vScrollBar.Value));
                }
                else
                    vScrollBar.Value = vScrollBar.Minimum;

            base.OnMouseWheel(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            UpdateFocus(e);

            base.OnMouseMove(e);
        }

        private void UpdateFocus(MouseEventArgs e)
        {
            _Hightlight.Location = MouseToCoordinates(e.Location);

            Invalidate();
        }
        #endregion

        #region <- Drawing ->
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawGrid(e);
            DrawScrollbarEdge(e);
            DrawFocusRectangle(e);

            base.OnPaint(e);
        }

        private void DrawScrollbarEdge(PaintEventArgs e)
        {
            var size = new Size(vScrollBar.Width, hScrollBar.Height);
            e.Graphics.FillRectangle(SystemBrushes.Control, new RectangleF(new Point(Width - size.Width, Height - size.Height), size));
        }

        private void DrawGrid(PaintEventArgs e)
        {
            for (int x = _OffsetX; x < GridWidth; x++)
                for (int y = _OffsetY; y < GridHeight; y++)
                {
                    var rect = new Rectangle(((CellWidth * x) - (CellWidth * _OffsetX)), ((CellHeight * y) - (CellHeight * _OffsetY)), CellWidth, CellHeight);

                    DrawImage(e, x, y, rect);

                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
        }

        private void DrawFocusRectangle(PaintEventArgs e)
        {
            if (_Hightlight.Location == new Point(-1, -1)) return;

            if (_Hightlight != null)
            {
                var rect = new Rectangle(CellWidth * _Hightlight.Location.X, CellHeight * _Hightlight.Location.Y, CellWidth, CellHeight);

                e.Graphics.DrawRectangle(new Pen(_Hightlight.Color, 2), rect);
            }
        }

        private void DrawImage(PaintEventArgs e, int x, int y, Rectangle rect)
        {
            if (_Grid != null && _Grid[x, y] != null)
                e.Graphics.DrawImage(_Grid[x, y], rect);
        }
        #endregion

        #region <- Scrollbars ->
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type != ScrollEventType.EndScroll && e.Type != ScrollEventType.ThumbPosition)
            {
                var view = (sender as HScrollBar);

                _OffsetX = DrawingUtils.TransformValue(e.NewValue, GridHeight * CellWidth, GridWidth);

                Invalidate();
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type != ScrollEventType.EndScroll && e.Type != ScrollEventType.ThumbPosition)
            {
                var view = (sender as VScrollBar);
                
                _OffsetY = DrawingUtils.TransformValue(e.NewValue, GridHeight * CellHeight, GridHeight);

                Invalidate();
            }
        }
        #endregion
    }
}
