﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int IdTipoProd { get; set; }
        public int IdMarca { get; set; }
        public int IdUMedida { get; set; }
        public int IdPresentacion { get; set; }

        public Producto() { }  
        public Producto(int codigo, string descripcion, double precio, int tipoProd, int idMarca, int idUMedida, int idPresentacion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            IdTipoProd = tipoProd;
            IdMarca = idMarca;
            IdUMedida = idUMedida;
            IdPresentacion = idPresentacion;
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }

}
   
