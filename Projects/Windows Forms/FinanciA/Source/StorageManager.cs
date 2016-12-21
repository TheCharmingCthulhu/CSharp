using System;

namespace FinanciA.Source
{
    class StorageManager
    {
        public const string PATH_ROOT = "\\Data";
        public const string PATH_FILES = "\\Data\\Resources\\";

        public static string GetStoragePath(int index)
        {
            string path = Environment.CurrentDirectory;

            switch (index)
            {
                case 0: path += PATH_ROOT; break;
                case 1: path += PATH_FILES; break;
            }

            return path;
        }
    }
}
