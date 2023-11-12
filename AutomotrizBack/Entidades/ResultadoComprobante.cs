using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class ResultadoComprobante
    {
        public DateTime FechaEmision {  get; set; }
        public int NumComprobante { get; set; }
        public string TipoDoc {  get; set; }
        public string Documento {  get; set; }
        public int Importe { get; set; }

        public ResultadoComprobante() { }
    }
}
