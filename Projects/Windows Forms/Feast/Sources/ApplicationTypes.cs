using System;

namespace Feast.Sources
{
    class ApplicationTypes
    {
        public enum Resources
        {
            Icons
        }

        const string DATA_ICONS = "\\Resources\\Icons\\";

        public static string GetResourcePath(Resources resource)
        {
            switch (resource)
            {
                case Resources.Icons:
                    return Environment.CurrentDirectory + DATA_ICONS;

                default:
                    return null;
            }
        }
    }
}
