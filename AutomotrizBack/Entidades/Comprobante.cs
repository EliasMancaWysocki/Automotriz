using System;
using System.Collections.Generic;

namespace AutomotrizBack.Entidades
{
    public class Comprobante
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int LegajoEmpleado { get; set; }
        public int IdCliente { get; set; }
        public int IdOrdenPedido { get; set; }
        public List<Items> FormasPago { get; set; }

        public Comprobante() 
        {
            FormasPago = new List<Items>();
        }
        public Comprobante(int id, DateTime fecha, int legajoEmpleado, int idCliente, int idOrdenPedido)
        {
            Id = id;
            Fecha = fecha;
            LegajoEmpleado = legajoEmpleado;
            IdCliente = idCliente;
            IdOrdenPedido = idOrdenPedido;
            FormasPago = new List<Items>();
        }
        public Comprobante(int id, DateTime fecha, int legajoEmpleado, int idCliente)
        {
            Id = id;
            Fecha = fecha;
            LegajoEmpleado = legajoEmpleado;
            IdCliente = idCliente;
            FormasPago = new List<Items>();
        }

        public void AgregarFormasPago(Items formaPago)
        {
            FormasPago.Add(formaPago);
        }
    }
}
