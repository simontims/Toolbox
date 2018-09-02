using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Toolbox
{

    static class Program
    {


        // Based on https://blogs.msdn.microsoft.com/csharpfaq/2006/03/27/how-can-i-easily-log-a-message-to-a-file-for-debugging-purposes/
        public static void LogToFile(string msg)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText(
                Path.Combine(Application.StartupPath, "toolbox.log"));
            try
            {
                string logLine = System.String.Format(
                    "{0} {1}", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

    }
}
