﻿using System;
using System.Windows.Forms;
using EllipticCurveTool.Controller;

namespace EllipticCurveTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainController controller = new MainController();
            Application.Run(controller.Form);
        }
    }
}
