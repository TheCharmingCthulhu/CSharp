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

        [DllImport("Kernel32.dll")]
        private static extern bool SetConsoleCtrlHandler(ConsoleHandler handler, bool add);

        private delegate bool ConsoleHandler(int type);
        private static event ConsoleHandler _consoleExit;
        private static Action _callback;

        public static void OnExit(Action callback)
        {
            _callback = callback;

            if (_consoleExit != null) _consoleExit -= ConsoleUtils_consoleExit;
            _consoleExit += ConsoleUtils_consoleExit;

            SetConsoleCtrlHandler(_consoleExit, true);
        }

        private static bool ConsoleUtils_consoleExit(int type)
        {
            switch (type)
            {
                case 0:
                case 1:
                case 2:
                case 5:
                case 6:
                default:
                    _callback?.Invoke();
                    return true;
            }
        }
    }
}
