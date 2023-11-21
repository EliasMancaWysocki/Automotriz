using System;
using System.Collections.Generic;
using AutomotrizBack.Entidades;

namespace AutomotrizBack.Entidades
{
    public class Comprobante
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        static public int LegajoEmpleado { get; set; }
        public Cliente Cliente { get; set; }
        public int IdOrdenPedido { get; set; }
        public int IdTipoFactura {  get; set; }
        public List<Items> FormasPago { get; set; }
        public List<DetalleComprobante> DetallesComprobante { get; set; }

        public Comprobante() 
        {
            FormasPago = new List<Items>();
            DetallesComprobante = new List<DetalleComprobante>();
        }
        public Comprobante(int id, DateTime fecha, int legajoEmpleado, Cliente cliente, int idOrdenPedido)
        {
            Id = id;
            Fecha = fecha;
            LegajoEmpleado = legajoEmpleado;
            Cliente = cliente;
            IdOrdenPedido = idOrdenPedido;
            FormasPago = new List<Items>();
            DetallesComprobante = new List<DetalleComprobante>();
        }
        public Comprobante(int id, DateTime fecha, int legajoEmpleado, Cliente cliente)
        {
            Id = id;
            Fecha = fecha;
            LegajoEmpleado = legajoEmpleado;
            Cliente = cliente;
            FormasPago = new List<Items>();
            DetallesComprobante = new List<DetalleComprobante>();
        }

        public void AgregarFormasPago(Items formaPago)
        {
            FormasPago.Add(formaPago);
        }
        public void EliminarFormaPago(Items formaPago)
        {
            FormasPago.Remove(formaPago);
        }
        public void AgregarDetalleComprobante (DetalleComprobante detalleComprobante)
        {
            DetallesComprobante.Add(detalleComprobante);
        }
        public void EliminarDetalleComprobante(int index)
        {
            DetallesComprobante.RemoveAt(index);
        }

        public double CalcularTotal()
        {
            double formaPago = 0;
            double total = 0;
            foreach(DetalleComprobante dc in DetallesComprobante)
            {
                foreach(Items i in FormasPago)
                {
                    formaPago += dc.CalcularSubtotal() * Convert.ToDouble(i.Extra) / 100;
                }
                total = dc.CalcularSubtotal() + formaPago + dc.CalcularOtrosImportes();
            }
            return total;
        }
        public double CalcularOtrosImportes()
        {
            double otrosImportes = 0;

            foreach (Items i in FormasPago)
            {
                foreach (DetalleComprobante dc in DetallesComprobante)
                {
                
                    Console.WriteLine(DetallesComprobante.Count);

                    otrosImportes += dc.CalcularSubtotal() * Convert.ToDouble(i.Extra) / 100;
                }
            }
            return otrosImportes;
        }
    }
}
