using System;
using System.Windows.Forms;
using Samplebank.Source;
using Samplebank.Source.Models;
using FsqLite.Source;

namespace Samplebank
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSamplebank());
        }
    }
}
