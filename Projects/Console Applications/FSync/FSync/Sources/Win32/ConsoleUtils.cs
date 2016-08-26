using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FSync.Sources.Win32
{
    class ConsoleUtils
    {
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
    
        internal static void ShowConsoleWindow(bool visible)
        {
            var hWnd = GetConsoleWindow();

            ShowWindow(hWnd, visible ? 1 : 0);
        }
    }
}
