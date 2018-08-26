using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

namespace DesignBox.Source.Controls
{
    public partial class CollectionView : UserControl
    {
        int columns = 3;

        #region Properties
        public int Columns
        {
            get { return columns; }
            set
            {
                columns = value;

                LayoutCollection();
            }
        }
        public ObservableCollection<CollectionViewItem> Cells { get; set; } = new ObservableCollection<CollectionViewItem>();
        public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Left;
        #endregion

        public CollectionView()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeExample()
        {
            for (int i = 0; i < 6; i++)
            {
                CollectionViewItem item = new CollectionViewItem();

                item.Type = CollectionViewItem.ControlType.Panel;
                item.Size = ((i + 1) % 2 == 0) ? new Size(128, 64) : new Size(32, 32);

                Cells.Add(item);
            }
        }

        private void InitializeView()
        {
            if (Cells != null)
            {
                Cells.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
                {
                    if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Reset)
                    {
                        if (e.Action == NotifyCollectionChangedAction.Add)
                        {
                            foreach (CollectionViewItem item in e.NewItems)
                            {
                                item.Parent = this;
                            }
                        }

                        LayoutCollection();
                    }
                };
            }
        }

        public void LayoutCollection()
        {
            Controls.Clear();

            if (Cells.Count > 0)
            {
                // Cells als Grid an der stelle von 0,0 bis zum letzten Cell initialisieren..
                PositionCells(0, 0);
                // Groesse alle Cells abrufen von 0,0 bis width, height des letzten Cells ..
                Rectangle cellLayout = CalculateCellLayout();
                // Zentrieren ..
                int x = (Width / 2) - (cellLayout.Width / 2), y = (Height / 2) - (cellLayout.Height / 2);
                // Cells an die Zentrierung anpassen ..
                PositionCells(x, y);
                // Cell hinzufügen ..
                foreach(var cell in Cells)
                    Controls.Add(cell.GetControl());
            }
        }

        private void PositionCells(int positionX, int positionY)
        {
            int x = positionX, y = positionY;
            int height = 0;

            for (int i = 0; i < Cells.Count; i++)
            {
                Control control = Cells[i].GetControl();

                if (control != null)
                {
                    control.Left = x;
                    control.Top = y;

                    x += control.Width;

                    if (height < control.Height)
                        height = control.Height;

                    if ((i + 1) % Columns == 0)
                    {
                        x = positionX;

                        y += height;
                        height = 0;
                    }
                }
            }
        }

        public Rectangle CalculateCellLayout()
        {
            Rectangle result = Rectangle.Empty;

            for (int i = 0; i < Cells.Count; i++)
            {
                Control control = Cells[i].GetControl();

                if (control != null)
                {
                    result = Rectangle.Union(result, new Rectangle(control.Left, control.Top, control.Width, control.Height));
                }
            }

            return result;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            LayoutCollection();
        }
    }

    public class CollectionViewItem
    {
        ControlType controlType;
        Control control;

        #region Properties
        public enum ControlType
        {
            None,
            Panel
        }

        public CollectionView Parent { get; set; }

        public Size Size
        {
            get
            {
                return control != null ? control.Size : Size.Empty;
            }
            set
            {
                if (control != null)
                {
                    control.Size = value;
                }
            }
        }

        public Point Position
        {
            get
            {
                return control != null ? new Point(control.Left, control.Top) : Point.Empty;
            }
        }

        public Padding Padding { get; set; }

        public ControlType Type {
            get
            {
                return controlType;
            }
            set
            {
                controlType = value;

                switch (controlType)
                {
                    case ControlType.None:
                        control = null;
                        break;
                    case ControlType.Panel:
                        control = new Panel
                        {
                            BackColor = SystemColors.Control,
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        break;
                }

                if (Parent != null)
                {
                    Parent.LayoutCollection();
                }
            }
        }
        #endregion

        public CollectionViewItem()
        {

        }

        public Control GetControl()
        {
            return control;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(ControlType), controlType);
        }
    }
}