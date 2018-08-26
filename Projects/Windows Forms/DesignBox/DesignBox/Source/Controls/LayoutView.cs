using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DesignBox.Source.Controls
{
    public partial class LayoutView : UserControl
    {
        public const int CELL_MAXIMUM_COUNT = 16;

        public enum LayoutItemType
        {
            Panel,
        }

        public LayoutViewTablePanel Table { get { return tlpTable; } }

        public LayoutView()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            SetStyle(LayoutViewHelper.OptimizedStyle, true);
        }

        private void InsertTableCellsWhereNeeded()
        {
            List<Point> cells = GetEmptyCells();

            Table.BeginLayoutUpdate();
            foreach(Point cell in cells)
            {
                Control view = new LayoutViewItemPanel(cell);

                if (view is LayoutViewItemPanel)
                {
                    LayoutViewItemPanel v = (LayoutViewItemPanel)view;
                    
                    /// Define selection behavior...
                    v.OnHighlightStateChanged += (sender, e) =>
                    {
                        if (e.Highlighted)
                        {
                            ToolbarSelectCell(sender);
                        }
                        else
                        {
                            ToolbarDeselectCell(sender);
                        }
                    };
                }

                Table.Controls.Add(view, cell.X, cell.Y);
            }
            Table.EndLayoutUpdate();
            Table.Invalidate();
        }

        private List<Point> GetEmptyCells()
        {
            List<Point> cells = new List<Point>();

            for (int x = 0; x < Table.ColumnCount; x++)
            {
                for (int y = 0; y < Table.RowCount; y++)
                {
                    cells.Add(new Point(x, y));
                }
            }

            foreach (Point cell in cells.ToArray())
            {
                Control view = Table.GetControlFromPosition(cell.X, cell.Y);

                if (view != null)
                {
                    cells.Remove(cell);
                }
            }

            return cells;
        }

        #region Toolbar
        private void ToolbarSelectCell(object sender)
        {
            /// Setzt für das "LayoutViewItemPanel" daten...
            if (sender is LayoutViewItemPanel)
            {
                LayoutViewItemPanel view = sender as LayoutViewItemPanel;
                if (view != null)
                {
                    lblCell.Text = string.Format("Layout:\"{0}\" | X:\"{1}\" | Y:\"{2}\"", view.GetType().Name, view.GetCellPosition().X, view.GetCellPosition().Y);
                }
            }
        }

        private void ToolbarDeselectCell(object sender)
        {
            lblCell.Text = "N/A";
        }
        #endregion

        #region Events
        private void tsbtnInsertColumn_Click(object sender, System.EventArgs e)
        {
            if (Table.ColumnCount + 1 < CELL_MAXIMUM_COUNT)
            {
                Table.ColumnCount += 1;
                Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                if (Table.ColumnStyles[0].Width != 50)
                {
                    Table.ColumnStyles[0].Width = 50;
                }

                InsertTableCellsWhereNeeded();
            }
        }

        private void tsbtnInsertRow_Click(object sender, System.EventArgs e)
        {
            if (Table.RowCount + 1 < CELL_MAXIMUM_COUNT)
            {
                Table.RowCount += 1;
                Table.RowStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                if (Table.RowStyles[0].Height != 50)
                {
                    Table.RowStyles[0].Height = 50;
                }

                InsertTableCellsWhereNeeded();
            }
        }

        private void tsbtnToolbar_Click(object sender, EventArgs e)
        {
            pToolbar.Visible = !pToolbar.Visible;
        }
        #endregion
    }

    public class LayoutViewTablePanel : TableLayoutPanel
    {
        public LayoutViewTablePanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= LayoutViewHelper.WS_EX_COMPOSITED;
                return cp;
            }
        }

        public void BeginLayoutUpdate()
        {
            LayoutViewHelper.SendMessage(Handle, LayoutViewHelper.WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        public void EndLayoutUpdate()
        {
            LayoutViewHelper.SendMessage(Handle, LayoutViewHelper.WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
        }
    }

    public interface ILayoutItemData
    {
        Point GetCellPosition();
    }

    public class LayoutViewItemPanel : Panel, ILayoutItemData
    {
        public Point Position { get; private set; }

        public class LayoutTypeDefaultPanelArgs
        {
            public bool Highlighted { get; private set; }

            public LayoutTypeDefaultPanelArgs(bool highlighted)
            {
                Highlighted = highlighted;
            }
        }

        public delegate void DefaultPanelHandler(object sender, LayoutTypeDefaultPanelArgs e);
        public event DefaultPanelHandler OnHighlightStateChanged;

        public bool Highlighted { get; set; }

        public LayoutViewItemPanel(Point position)
        {
            Dock = DockStyle.Fill;
            BackColor = SystemColors.Control;

            SetStyle(LayoutViewHelper.OptimizedStyle, true);

            Position = position;
        }

        #region Override
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (!Highlighted)
            {
                BackColor = SystemColors.ControlLightLight;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                {
                    Highlighted = !Highlighted;

                    BackColor = Highlighted ? SystemColors.ActiveCaption : SystemColors.ControlLightLight;

                    OnHighlightStateChanged?.Invoke(this, new LayoutTypeDefaultPanelArgs(Highlighted));
                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (!Highlighted)
            {
                BackColor = SystemColors.Control;
            }
        } 
        #endregion

        public Point GetCellPosition()
        {
            return Position;
        }
    }

    public class LayoutViewHelper
    {
        public static int WM_SETREDRAW = 0x000B; //uint WM_SETREDRAW
        public static int WS_EX_COMPOSITED = 0x02000000;


        public static ControlStyles OptimizedStyle { get; private set; } =
            ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam); //UInt32 Msg
    }
}
