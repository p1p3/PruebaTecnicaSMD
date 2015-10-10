using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Presentacion.Models;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Productos;
using System.ComponentModel.DataAnnotations;

namespace Presentacion.Models
{
    public class ProductoModels
    {


        public ProductoModels()
        { }

        public ProductoModels(Producto ProductoDominio)
        {
            this.ProductoId = ProductoDominio.ProductoId;
            this.CatalogoId = ProductoDominio.CatalogoId;
            this.Titulo = ProductoDominio.Titulo;
            this.Descripcion = ProductoDominio.Descripcion;
            this.RutaImagen = ProductoDominio.RutaImagen;
        }


        public Producto ToProductDomain()
        {
            Producto Producto = new Producto
            {
                ProductoId = this.ProductoId,
                CatalogoId = this.CatalogoId,
                Titulo = this.Titulo,
                Descripcion = this.Descripcion,
                RutaImagen = this.RutaImagen
            };

            return Producto;
        }

        public int ProductoId { get; set; }
        public int CatalogoId { get; set; }

        [Required(ErrorMessage = "El título del producto es requerido.")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "La descripción del producto es requerida.")]
        public string Descripcion { get; set; }

        public string RutaImagen { get; set; }

        public virtual Catalogo catalogo { get; set; }

    }
}