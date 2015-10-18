using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaTecnica.Core.Servicios.Interfaces;
using PruebaTecnica.Core.Catalogos;
using Presentacion.Models;

namespace Presentacion.Controllers
{
    public class CatalogoController : Controller
    {

       private ICatalogoServicio CatalogoServicio;

        public CatalogoController(ICatalogoServicio CatalogoServicio) {
            this.CatalogoServicio = CatalogoServicio;
        }

        // GET: Catalogo
        public ActionResult Index()
        {
            return View(CatalogoServicio.PageAndFilter(0,0,null,null,(x => x.Productos)));
        }

        // GET: Catalogo/Details/5
        public ActionResult Details(int id)
        {
            CatalogoModels Catalogo = new CatalogoModels(CatalogoServicio.FindById(id));

            return View(Catalogo);
        }

        // GET: Catalogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogo/Create
        [HttpPost]
        public ActionResult Create(CatalogoModels catalogo)
        {
            try
            {
                CatalogoServicio.CrearCatalogo(catalogo.ToCatalogoDomain());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Edit/5
        public ActionResult Edit(int id)
        {
            CatalogoModels Catalogo = new CatalogoModels(CatalogoServicio.FindById(id));

            return View(Catalogo);
        }

        // POST: Catalogo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CatalogoModels catalogo)
        {
            try
            {
                CatalogoServicio.ActualizarCatalogo(catalogo.ToCatalogoDomain());
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
