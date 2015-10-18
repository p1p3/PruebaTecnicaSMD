using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Catalogos;
using System.Runtime.Serialization;

namespace PruebaTecnica.Core.Productos
{

    [DataContract(IsReference = true)]
    public class Producto
    {
        public Producto() { }

        [DataMember]
        public int ProductoId { get; set; }
        [DataMember]

        public int CatalogoId { get; set; }
        [DataMember]
        public string Titulo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string Categoria { get; set; }

        [DataMember]
        public decimal Precio { get; set; }

        [DataMember]
        public string RutaImagen { get; set; }

        
        public virtual Catalogo catalogo { get; set; }
    }
}
