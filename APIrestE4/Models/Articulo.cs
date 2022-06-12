using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIrestE4.Models
{
    public class Articulo
    {
        public int id_producto { get; set; }
        public int id_categoria { get; set; }
        public int id_imagen { get; set; }
        public string nombreArticulo { get; set; }
        public string descripcionArt { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; } 

        public string fechaCaptura { get; set; }
        

     }
}