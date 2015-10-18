using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Productos;
using System.Runtime.Serialization;

namespace PruebaTecnica.Core.Catalogos
{
    [DataContract(IsReference = true)]
    public class Catalogo
    {

        public Catalogo() { }

        [DataMember]
        public int CatalogoId { get; set; }

        [DataMember]
        public string NombreCatalogo { get; set; }

        [DataMember]
        private ICollection<Producto> _productos;
        public virtual ICollection<Producto> Productos
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new List<Producto>();
                }
                return _productos;
            }

            set
            {
                _productos = value;
            }
        }
    }
}
