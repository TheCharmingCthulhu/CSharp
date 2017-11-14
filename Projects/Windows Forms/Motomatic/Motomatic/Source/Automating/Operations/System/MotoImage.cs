using Motomatic.Controls.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Motomatic.Source.Automating.Operations.System
{
    static class MotoImage
    {
        public class Search : Event
        {
            [Editor(typeof(FileEditor), typeof(UITypeEditor))]
            public string Filename { get; set; }

            public Rectangle Area { get; set; }
            public int Offset { get; set; } = 0;

            protected override bool Observe()
            {
                if (!string.IsNullOrEmpty(Filename))
                    if (File.Exists(Filename))
                    {
                        if (Area.IsEmpty) Area = Screen.PrimaryScreen.Bounds;

                        Engine.ExecRaw(Parser.New()
                            .Chain("CoordMode Pixel, Screen")
                            .Chain("ImageSearch, Fx, Fy, {0}, {1}, {2}, {3}, {4}",
                                Area.Left - Offset, Area.Top - Offset, Area.Left + Area.Width + Offset, Area.Top + Area.Height + Offset, Filename)
                            .Finalize());

                        Parameters.Clear();
                        Parameters.Add(Engine.GetVar("Fx"));
                        Parameters.Add(Engine.GetVar("Fy"));

                        return Parameters.All(x => !string.IsNullOrEmpty(x));
                    }

                return false;
            }

            public override string ToString()
            {
                return string.Format("Imagesearch - {0}", !string.IsNullOrEmpty(Filename) ? Path.GetFileNameWithoutExtension(Filename) : "None");
            }
        }
    }
}
