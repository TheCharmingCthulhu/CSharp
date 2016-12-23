using System.Drawing;
using System.Windows.Forms;

namespace FinanciA.Source.Services
{
    public class FastDrawing
    {
        public static void DrawString(PaintEventArgs e, string text, Brush color, float x, float y,
            StringAlignment horizontalAlignment = StringAlignment.Near, StringAlignment verticalAlignment = StringAlignment.Near)
        {
            e.Graphics.DrawString(text, SystemFonts.DefaultFont, color, x, y, new StringFormat()
            {
                Trimming = StringTrimming.None,
                Alignment = horizontalAlignment,
                LineAlignment = verticalAlignment
            });
        }

        public static void DrawString(PaintEventArgs e, string text, Brush color, Rectangle frame,
            StringAlignment horizontalAlignment = StringAlignment.Near, StringAlignment verticalAlignment = StringAlignment.Near)
        {
            e.Graphics.DrawString(text, SystemFonts.DefaultFont, color, frame, new StringFormat()
            {
                Trimming = StringTrimming.None,
                Alignment = horizontalAlignment,
                LineAlignment = verticalAlignment
            });
        }
    }
}
