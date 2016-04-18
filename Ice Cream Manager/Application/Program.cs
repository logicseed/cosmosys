﻿using System;
using System.Windows.Forms;

using IceCreamManager.Model;
using IceCreamManager.View;
//using IceCreamManager.Controller;

namespace IceCreamManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm.Reference);
        }
    }
}
