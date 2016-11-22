using System.Runtime.InteropServices;

namespace Feast.Sources.Services
{
    static class Winapi
    {
        [DllImport("kernel32.dll")]
        static extern int lstrcmp([MarshalAs(UnmanagedType.LPStr)] string lpString1, [MarshalAs(UnmanagedType.LPStr)] string lpString2);

        public static int CompareStrings(string a, string b)
        {
            return lstrcmp(a, b);
        }
    }
}
