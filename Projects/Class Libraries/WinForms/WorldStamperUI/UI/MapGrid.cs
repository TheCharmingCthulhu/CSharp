using System;
using System.Drawing;
using System.Windows.Forms;
using WorldStamper.Sources.Utilities;

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

        public MapGrid()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            _Grid = new Image[GridWidth, GridHeight];
        }

        #region <- Functions ->
        public void AddImage(int x, int y, Image image)
        {
            _Grid[x, y] = image;
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
            UpdateScrollbars();

            base.OnResize(e);
        }
        #endregion

        #region <- Drawing ->
        bool _showEdge;

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawGrid(e);
            DrawScrollbarEdge(e);

            base.OnPaint(e);
        }

        private void DrawScrollbarEdge(PaintEventArgs e)
        {
            if (_showEdge)
            {
                var size = new Size(vScrollBar.Width, hScrollBar.Height);
                e.Graphics.FillRectangle(SystemBrushes.Control, new RectangleF(new Point(Width - size.Width, Height - size.Height), size));
            }
        }

        private void DrawGrid(PaintEventArgs e)
        {
            for (int x = _OffsetX; x < GridWidth; x++)
                for (int y = _OffsetY; y < GridHeight; y++)
                {
                    var rect = new Rectangle(((CellWidth * x) - (CellWidth * _OffsetX)), ((CellHeight * y) - (CellHeight * _OffsetY)), CellWidth, CellHeight);

                    if (_Grid != null && _Grid[x, y] != null)
                        e.Graphics.DrawImage(_Grid[x, y], rect);

                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
        }

        private Size GetGridSize()
        {
            return new Size(GridWidth * CellWidth, GridHeight * CellHeight);
        }
        #endregion

        #region <- Scrollbars ->
        int _scrollLimitX = 0, _scrollLimitY = 0;

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (_scrollLimitX < e.NewValue) e.NewValue = _scrollLimitX;

            var view = (sender as HScrollBar);

            _OffsetX = DrawingUtils.TransformValue(e.NewValue, view.Maximum - (view.LargeChange - 1), GridWidth);

            view.Value = e.NewValue;

            Invalidate();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (_scrollLimitY < e.NewValue) e.NewValue = _scrollLimitY;

            var view = (sender as VScrollBar);

            _OffsetY = DrawingUtils.TransformValue(e.NewValue, view.Maximum - (view.LargeChange - 1), GridHeight);

            view.Value = e.NewValue;

            Invalidate();
        }

        private void UpdateScrollbars()
        {
            var gridSize = GetGridSize();

            hScrollBar.Visible = Width < gridSize.Width && Width > 0;
            vScrollBar.Visible = Height < gridSize.Height && Width > 0;

            _scrollLimitX = hScrollBar.Visible ? DrawingUtils.TransformValue(gridSize.Width - Width + CellWidth + 17, gridSize.Width, hScrollBar.Maximum - (hScrollBar.LargeChange - 1)) : hScrollBar.Maximum;
            _scrollLimitY = vScrollBar.Visible ? DrawingUtils.TransformValue(gridSize.Height - Height + CellHeight + 17, gridSize.Height, vScrollBar.Maximum - (vScrollBar.LargeChange - 1)) : vScrollBar.Maximum - (vScrollBar.LargeChange - 1);

            _OffsetX = 0;
            _OffsetY = 0;

            hScrollBar.Value = 0;
            vScrollBar.Value = 0;

            _showEdge = !(!hScrollBar.Visible && !vScrollBar.Visible);
        }
        #endregion
    }
}
