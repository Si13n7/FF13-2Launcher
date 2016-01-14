using System;
using System.Windows.Forms;

namespace FF13FullLauncher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string clFilter = Environment.CommandLine.ToLower().Replace("true", "1").Replace("+set ", "+").Replace("\"", string.Empty);
            if (clFilter.Contains("+debug 1"))
                SilDev.Log.ActivateDebug();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
