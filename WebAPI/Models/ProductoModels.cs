using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using PruebaTecnica.Core.Productos;

namespace WebAPI.Models
{
    public class ProductoModels
    {
        [DataContract(IsReference = true)]
        public class ProductoListar
        {
            public ProductoListar() { }

            public ProductoListar(Producto ProductoCore) {
                this.ProductoId = ProductoCore.ProductoId;
                this.CatalogoId = ProductoCore.CatalogoId;
                this.name = ProductoCore.Titulo;
                this.description = ProductoCore.Descripcion;
                this.category = ProductoCore.Categoria;
                this.price = ProductoCore.Precio;
                this.RutaImagen = ProductoCore.RutaImagen;
            }

            [DataMember]
            public int ProductoId { get; set; }
            [DataMember]

            public int CatalogoId { get; set; }
            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string description { get; set; }

            [DataMember]
            public string category { get; set; }

            [DataMember]
            public decimal price { get; set; }

            [DataMember]
            public string RutaImagen { get; set; }


        }

        
    }
}