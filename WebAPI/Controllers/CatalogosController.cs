using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Servicios.Interfaces;

namespace WebAPI.Controllers
{
    public class CatalogosController : ApiController
    {

        private ICatalogoServicio _CatalogoServicio { get; }

        public CatalogosController(ICatalogoServicio ICatalogoServicio)
        {
            _CatalogoServicio = ICatalogoServicio;
        }


        // GET api/Catalogos
        public IEnumerable<Catalogo> Get()
        {
            var Catalogos = _CatalogoServicio.PageAndFilter(0, 0, null, null, (x => x.Productos));

            if (Catalogos == null || Catalogos.Count == 0)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Catalogos;
        }

    }
}
