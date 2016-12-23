using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Drawing;
using MetroFramework.Controls;
using System.Linq;
using FinanciA.Source;
using System.Windows.Forms.VisualStyles;
using FinanciA.Source.Services;

namespace FinanciA.Forms.Items
{
    public partial class FormOverview : MetroForm
    {
        Rectangle _Frame;
        Diagrams _Diagram = Diagrams.None;

        DateTime _StartOfMonth;
        //DateTime _EndOfMonth;

        public enum Diagrams
        {
            None = -1,
            Month = 0
        }

        public FormOverview()
        {
            InitializeComponent();
        }

        public static DialogResult Run()
        {
            var f = new FormOverview();


            return f.ShowDialog();
        }

        private void FormOverview_Paint(object sender, PaintEventArgs e)
        {
            _Frame = new Rectangle(20, 100, e.ClipRectangle.Right - 61, e.ClipRectangle.Bottom - 120);

            e.Graphics.DrawRectangle(Pens.SlateGray, _Frame);

            switch (_Diagram)
            {
                case Diagrams.None:
                    FastDrawing.DrawString(e, "Bitte wählen Sie einen Ansichtstypen aus.", Brushes.Black, _Frame, 
                        StringAlignment.Center, StringAlignment.Center);
                    break;

                case Diagrams.Month:
                    DrawDiagramMonth(e);
                    break;
            }
        }
        
        #region <- Drawing ->
        private void DrawDiagramMonth(PaintEventArgs e)
        {
            if (FormMain.FixcostManager.Items.Count > 0 && FormMain.SalaryManager.Items.Count > 0)
            {
                var mainFrame = new Rectangle(_Frame.X + 10, _Frame.Y + 20, _Frame.Width - 30, _Frame.Height - 40);
                var x = 0; // Diagram starting point

                // Labels
                for (int i = 0; i < FormMain.SalaryManager.Items.Count; i++)
                {
                    var item = FormMain.SalaryManager.Items[i];

                    e.Graphics.DrawString(item.Description, DefaultFont, Brushes.Black, mainFrame.X, mainFrame.Y + 25 * i);

                    var itemX = GetItemLabelLength(e, item).Width;
                    if (itemX > x) x = itemX;
                }

                var subFrame = new Rectangle((mainFrame.X + 15) + x, mainFrame.Y, (mainFrame.Width - 15) - x, mainFrame.Height);

                // Date
                FastDrawing.DrawString(e, _StartOfMonth.ToShortDateString(), Brushes.Black, subFrame.X, _Frame.Y + 5);

                e.Graphics.DrawRectangle(Pens.Black, subFrame);
            }
            else FastDrawing.DrawString(e, "Keine Daten zum Anzeigen vorhanden.", Brushes.Black, _Frame.X, _Frame.Y, 
                StringAlignment.Center, StringAlignment.Center);
        }
        #endregion

        #region <- Drawing Helpers ->

        private Size GetItemLabelLength(PaintEventArgs e, CurrencyDataItem item)
        {
            var text = !string.IsNullOrEmpty(item.Name) ? item.Name : item.Description;

            return e.Graphics.MeasureString(text, DefaultFont).ToSize();
        }
        #endregion

        private void metroComboBoxTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Diagram = (Diagrams)(sender as MetroComboBox).SelectedIndex;

            Invalidate();
        }
    }
}
