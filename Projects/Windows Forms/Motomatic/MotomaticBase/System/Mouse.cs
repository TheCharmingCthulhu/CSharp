using System.Drawing;
using System.Windows.Forms;

namespace MotomaticBase.System
{
    class Mouse
    {
        public static void Move(int x, int y, double speed)
        {
            Cursor.Position = new Point(x, y);
        }
    }
}
