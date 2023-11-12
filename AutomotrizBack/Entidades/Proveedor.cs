using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    class Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Altura { get; set; }
        public int Barrio { get; set; }
        public string Calle { get; set; }
        public string Documento {get;set;}
        public int Tipo_Documento { get; set; }
        public int TipoCIva { get; set; }

        public Proveedor(int id, string razonSocial, string direccion, string altura, int barrio, string calle, string documento, int tipo_Documento, int tipoCIva)
        {
            Id = id;
            RazonSocial = razonSocial;
            Direccion = direccion;
            Altura = altura;
            Barrio = barrio;
            Calle = calle;
            Documento = documento;
            Tipo_Documento = tipo_Documento;
            TipoCIva = tipoCIva;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
