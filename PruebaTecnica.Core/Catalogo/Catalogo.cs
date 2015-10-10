using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Productos;

namespace PruebaTecnica.Core.Catalogos
{
   public class Catalogo
    {

        public Catalogo() { }

        public int CatalogoId { get; set; }
        public string NombreCatalogo { get; set; }

        private ICollection<Producto> _productos;
        public virtual ICollection<Producto> Productos {
            get
            {
                if (_productos == null) {
                    _productos = new List<Producto>();
                }
                return _productos;
            }

            set {
                _productos = value;
            } }
    }
}
