using Automotriz.Presentación;
using Automotriz.Presentación.Soporte;
using AutomotrizFront.Presentación.Soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotriz
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
            Application.Run(new FrmAutomotriz());
<<<<<<< HEAD
            //Application.Run(new FrmConsulta());
=======
            //Application.Run(new FrmActualizarCliente());
>>>>>>> 8f6338f1c668922043c12f544c0171afdc47c480

        }
    }
}
