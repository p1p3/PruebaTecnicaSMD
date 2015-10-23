using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Catalogos;

namespace PruebaTecnica.Core.Productos
{


    public class Producto
    {
        public Producto() { }

     
        public int ProductoId { get; set; }
 
        public int CatalogoId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Categoria { get; set; }

        public decimal Precio { get; set; }

        public string RutaImagen { get; set; }

        public virtual Catalogo catalogo { get; set; }
    }
}
