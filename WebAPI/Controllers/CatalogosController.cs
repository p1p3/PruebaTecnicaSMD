using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Servicios.Interfaces;
using WebAPI.Models;

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
        public IEnumerable<CatalogoModels.CatalogoListar> Get()
        {
            List<CatalogoModels.CatalogoListar> CatalogosRetorno = new List<CatalogoModels.CatalogoListar>();

            var Catalogos = _CatalogoServicio.PageAndFilter(0, 0, null, null, (x => x.Productos));
 
            if (Catalogos == null || Catalogos.Count == 0)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            foreach (Catalogo catalogo in Catalogos)
            {
                CatalogosRetorno.Add(new CatalogoModels.CatalogoListar(catalogo));
            }

            return CatalogosRetorno;
        }

    }
}
