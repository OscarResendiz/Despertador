using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DespertadorNET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static KeyboardInterceptor ki;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (ki = new KeyboardInterceptor())
            {
                Application.Run(new FormPrincipal());
            }
        }
    }
}
