using System;

namespace Feast.Sources
{
    class ApplicationTypes
    {
        public enum Resources
        {
            Icons,
            Files
        }

        const string DATA_ICONS = "\\Resources\\Icons\\";
        const string DATA_FILES = "\\Resources\\Data\\";

        public static string GetResourcePath(Resources resource)
        {
            switch (resource)
            {
                case Resources.Icons:
                    return Environment.CurrentDirectory + DATA_ICONS;

                case Resources.Files:
                    return Environment.CurrentDirectory + DATA_FILES;

                default:
                    return null;
            }
        }
    }
}
