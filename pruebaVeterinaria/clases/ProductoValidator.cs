using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaVeterinaria.clases
{
    public class ProductoValidator
    {

        public int idproducto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public int cantidadStock { get; set; }
        public decimal precio { get; set; }
        public string tipoProducto { get; set; }
       public ProductoValidator() {
            idproducto = 0;
            nombre_producto = "";
            descripcion_producto = "";
            cantidadStock = 0 ;
            precio = 0;
            tipoProducto = "";
        }
    }
    
}
