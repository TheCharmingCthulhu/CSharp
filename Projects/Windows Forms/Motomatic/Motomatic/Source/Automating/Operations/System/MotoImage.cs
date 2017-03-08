using Motomatic.Source.Automating;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Motomatic.Source.Automating.Operations.System
{
    static class MotoImage
    {
        public class Search : Event
        {
            string _Filename;
            Rectangle _Area;

            public Search(string filename) : this(filename, Rectangle.Empty)
            {

            }

            public Search(string filename, Rectangle area, int offset = -1) : base()
            {
                _Filename = filename;
                _Area = area;
               
                if (offset != -1)
                    _Area = new Rectangle(_Area.Left - offset, _Area.Top - offset, _Area.Width + offset, _Area.Height + offset);
            }

            /// <summary>
            /// Always calls the observe function and returns.
            /// </summary>
            /// <returns>Returns the found image coordinate otherwise an empty point</returns>
            protected override object Observe()
            {
                if (!string.IsNullOrEmpty(_Filename))
                    if (File.Exists(_Filename))
                    {
                        if (_Area.IsEmpty) _Area = Screen.PrimaryScreen.Bounds;

                        Engine.ExecRaw(Parser.New()
                            .Chain("CoordMode Pixel, Screen")
                            .Chain("ImageSearch, Fx, Fy, {0}, {1}, {2}, {3}, {4}",
                                _Area.Left, _Area.Top, _Area.Left + _Area.Width, _Area.Top + _Area.Height, _Filename)
                            .Finalize());

                        return !string.IsNullOrEmpty(Engine.GetVar("Fx")) && !string.IsNullOrEmpty(Engine.GetVar("Fx")) ? new Point(int.Parse(Engine.GetVar("Fx")), int.Parse(Engine.GetVar("Fy"))) : Point.Empty;
                    }

                return Point.Empty;
            }
        }
    }
}
