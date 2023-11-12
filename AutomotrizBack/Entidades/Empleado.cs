using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    class Empleado
    {
       

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public DateTime FechaNac { get; set; }
        public int Barrio { get; set; }
        public string Documento { get; set; }
        public int TipoDoc { get; set; }
        public int TipEmpleado { get; set; }
        public DateTime FechaAlta { get; set; }

        public Empleado(int legajo, string nombre, string apellido, string calle, string altura, DateTime fechaNac, int barrio, string documento, int tipoDoc, int tipEmpleado, DateTime fechaAlta)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Calle = calle;
            Altura = altura;
            FechaNac = fechaNac;
            Barrio = barrio;
            Documento = documento;
            TipoDoc = tipoDoc;
            TipEmpleado = tipEmpleado;
            FechaAlta = fechaAlta;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
