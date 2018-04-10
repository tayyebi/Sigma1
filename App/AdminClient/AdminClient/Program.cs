using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        static public Forms.Master.Container container;
        static public string Username { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => HandleUnhandledException(args.ExceptionObject as Exception);
            Application.ThreadException += (sender, args) => HandleUnhandledException(args.Exception);


            container = new Forms.Master.Container();
            Application.Run(container);
        }
        static void HandleUnhandledException(Exception exception)
        {
            new Forms.Master.RexaMessage("There was something wrong \n\r" + exception.Message).ShowDialog();
        }
    }
}
