using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStamper.Sources.Utilities
{
    class ResourceUtils
    {
        internal enum AssetsType
        {
            Fonts,
            Gfx,
            Gui,
            Map,
            Sounds
        }

        internal const string ASSETS_PATH = "..\\assets";

        internal static string GetResourcePath(AssetsType type) {
            switch (type)
            {
                case AssetsType.Map:
                    return Path.Combine(ASSETS_PATH, "Maps");

                case AssetsType.Gfx:
                    return Path.Combine(ASSETS_PATH, "Gfx");
                
                default:
                    return null;
            }
        }
    }
}
