using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Items
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public object Extra { get; set; }

        public Items() { }
        public Items(int id, string nombre) 
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        public Items(int id, string nombre, object extra)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Extra = extra;
        }
    }
}
