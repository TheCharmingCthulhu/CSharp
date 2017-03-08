using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Motomatic
{
    static class Program
    {
        const int PROCESS_AFFINITY = 4;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)(2 * PROCESS_AFFINITY);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
