using System.Collections.Generic;
using System.Runtime.Serialization;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Productos;

namespace WebAPI.Models
{
   public class CatalogoModels
    {

        [DataContract(IsReference = true)]
        public class CatalogoListar
        {

            public CatalogoListar() { }

            
            public CatalogoListar(Catalogo CatalogoCore)
            {
                this.NombreCatalogo = CatalogoCore.NombreCatalogo;
                this.CatalogoId = CatalogoCore.CatalogoId;
                ProductoModels.ProductoListar ProductosTemp;
                foreach (Producto ProductoItem in CatalogoCore.Productos) {
                    ProductosTemp = new ProductoModels.ProductoListar(ProductoItem);
                    this.Productos.Add(ProductosTemp);
                }

            }

            [DataMember]
            public int CatalogoId { get; set; }

            [DataMember]
            public string NombreCatalogo { get; set; }

            [DataMember]
            private ICollection<ProductoModels.ProductoListar> _productos;
            public ICollection<ProductoModels.ProductoListar> Productos
            {
                get
                {
                    if (_productos == null)
                    {
                        _productos = new List<ProductoModels.ProductoListar>();
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
}
