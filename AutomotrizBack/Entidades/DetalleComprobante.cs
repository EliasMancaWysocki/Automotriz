using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutomotrizBack.Datos;

namespace AutomotrizBack.Entidades
{
    public class DetalleComprobante
    {
        IComprobantesDAO Servicio;
        
        public int Cantidad {  get; set; }
        public double Precio { get; set; }
        public int IdBonif { get; set; }
        public int IdAutoplan { get; set; }
        public int CodProducto { get; set; }

        public DetalleComprobante () 
        {
            Servicio = new ComprobantesDAO();
        }

        public double CalcularSubtotal()
        {
            double bonif = 0;
            double subtotal = Precio * Cantidad;

            foreach (Items i in Servicio.ObtenerDescuentos())
            {
                if (i.Id == IdBonif)
                {
                    bonif = subtotal * Convert.ToDouble(i.Nombre) / 100;
                }
            }
            
            return subtotal -=  bonif;

        }
        public double CalcularOtrosImportes()
        {
            double autoplan = 0;
            double subtotal = Precio * Cantidad;
            foreach (Items i in Servicio.ObtenerAutoplanes())
            {
                if (i.Id == IdBonif)
                {
                    autoplan = subtotal * Convert.ToDouble(i.Extra) / 100;
                }
            }
            return autoplan;
        }
    }
}
