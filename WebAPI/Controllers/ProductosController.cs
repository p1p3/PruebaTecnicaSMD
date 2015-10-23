using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PruebaTecnica.Core.UnitOfWork;
using PruebaTecnica.Core.Productos;
using PruebaTecnica.Core.Servicios.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductosController : ApiController
    {
        private IProductoServicio _ProductoServicio { get; }

        public ProductosController(IProductoServicio ProductoServicio) {
            _ProductoServicio = ProductoServicio;
        }



        // GET api/Productos
        public IEnumerable<ProductoModels.ProductoListar> Get()
        {
            List<ProductoModels.ProductoListar> ProductosRetorno = new List<ProductoModels.ProductoListar>();

            var Productos = _ProductoServicio.PageAndFilter(0, 0,null,null,(x => x.catalogo));

            if (Productos == null || Productos.Count == 0 )
                throw new HttpResponseException(HttpStatusCode.NotFound);

            foreach (Producto producto in Productos)
            {
                ProductosRetorno.Add(new ProductoModels.ProductoListar(producto));
            }

            return ProductosRetorno;
        }


    }
}
