using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Código")]
        public string codigo { get; set; }

        [DisplayNameAttribute("Nombre")]
        public string nombre { get; set; }

        [DisplayNameAttribute("Descripción")]
        public string descripcion { get; set; }

        [DisplayNameAttribute("Marca")]
        public Marca marca { get; set; }

        [DisplayNameAttribute("Categoría")]
        public Categoria categoria { get; set; }

         [DisplayNameAttribute("Imagen Obtenida de URL")]

        public string imagenUrl { get; set; }

        [DisplayNameAttribute("Precio")]
        public decimal precio { get; set; }

        public Articulo()
        {
            marca = new Marca();
            categoria = new Categoria();
        }
        
    }

 
}
