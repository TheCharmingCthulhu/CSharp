using System;
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
        private Image[,] _Grid;

        private FocusRectangle _Hightlight;

        public MapGrid()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            _Grid = new Image[GridWidth, GridHeight];

            _Hightlight = new FocusRectangle();
        }

        #region <- Functions ->
        public void AddImage(int x, int y, Image image)
        {
            _Grid[x, y] = image;
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

        #region <- Usercontrol ->
        protected override void OnLoad(EventArgs e)
        {
            if (Width % CellWidth != 0) Width -= Width % CellWidth - 1;
            if (Height % CellHeight != 0) Height -= Height % CellHeight - 1;

            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            UpdateGrid();

            base.OnResize(e);
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
                    DrawScrollbarEdge(e);
                    DrawFocus(e);

                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
        }

        private void DrawFocus(PaintEventArgs e)
        {
            if (_Hightlight != null)
                if (_Hightlight.Location != new Point(-1, -1))
                    e.Graphics.DrawRectangle(new Pen(_Hightlight.Color, 2), 
                        new Rectangle(CellWidth * _Hightlight.Location.X, CellHeight * _Hightlight.Location.Y, CellWidth, CellHeight));
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
            var view = (sender as HScrollBar);

            _OffsetX = DrawingUtils.TransformValue(e.NewValue, view.Maximum - (view.LargeChange - 1), GridWidth - 1);

            view.Value = e.NewValue;

            Invalidate();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            var view = (sender as VScrollBar);

            _OffsetY = DrawingUtils.TransformValue(e.NewValue, view.Maximum - (view.LargeChange - 1), GridHeight - 1);

            view.Value = e.NewValue;

            Invalidate();
        }

        private void UpdateGrid()
        {
            var size = GetGridSize();

            var offscreenX = DrawingUtils.TransformValue(size.Width - (Width - vScrollBar.Width), size.Width, GridWidth);
        }
        #endregion
    }
}
