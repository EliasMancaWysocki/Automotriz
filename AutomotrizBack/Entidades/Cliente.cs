using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public int Barrio { get; set; }
        public string Documento { get; set; }
        public int TipoDoc { get; set; }
        public int TipoCliente { get; set; }
        public int CondicionIVA { get; set; }

        public Cliente(int id, string nombre, string apellido, string calle, string altura, int barrio, string documento, int tipoDoc, int tipoCliente, int condicionIVA)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Calle = calle;
            Altura = altura;
            Barrio = barrio;
            Documento = documento;
            TipoDoc = tipoDoc;
            TipoCliente = tipoCliente;
            CondicionIVA = condicionIVA;
        }

        public Cliente() { }
    }
}
