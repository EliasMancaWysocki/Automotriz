﻿using Automotriz.Presentación;
using Automotriz.Presentación.Soporte;
using AutomotrizFront.Presentación;
using AutomotrizFront.Presentación.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicioSesion());
            //Application.Run(new FrmDatosEmisor());

        }
    }
}
