using System.Windows.Forms;
using System.Drawing;

namespace Motomatic.Source.Modules
{
    class Mouse
    {
        public static void Move(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }
    }
}
