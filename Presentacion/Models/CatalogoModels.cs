using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Presentacion.Models;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Productos;

namespace Presentacion.Models
{
    public class CatalogoModels

    {
        public CatalogoModels() { }

        public CatalogoModels(Catalogo catalogoDominio) {
            this.CatalogoId = catalogoDominio.CatalogoId;
            this.NombreCatalogo = catalogoDominio.NombreCatalogo;
            this.Productos = catalogoDominio.Productos;
        }

        public int CatalogoId { get; set; }

        [Required(ErrorMessage = "El nombre del catalogo es requerido.")]
        public string NombreCatalogo { get; set; }

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

        public Catalogo ToCatalogoDomain() {
            Catalogo Catalogo = new Catalogo
            {
                CatalogoId = this.CatalogoId,
                NombreCatalogo = this.NombreCatalogo,
                Productos = this.Productos
            };

            return Catalogo;
        }
    }
}