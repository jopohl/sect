using System;
using System.Timers;
using System.Windows.Forms;
using EllipticCurveTool.Controller;

namespace EllipticCurveTool
{
    static class Program
    {
        private static System.Timers.Timer _closeTimer;
        
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            MainController controller = new MainController();

            if (args.Length == 1 && args[0] == "autoclose")
            {
                _closeTimer = new System.Timers.Timer(1000);
                _closeTimer.Elapsed += OnTimedEvent;
                _closeTimer.AutoReset = false;
                _closeTimer.Start();
                Console.WriteLine("Starting application...");
                Application.Run(controller.Form);
                _closeTimer.Stop();
                _closeTimer.Dispose();
            }
            else
            {
                Application.Run(controller.Form);
            }
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Application.Exit();
            Console.WriteLine("Application was automatically closed.");
        }
    }
}
