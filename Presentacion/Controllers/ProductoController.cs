using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaTecnica.Core.Servicios.Interfaces;
using PruebaTecnica.Core.Productos;
using Presentacion.Models;
using System.IO;

namespace Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoServicio ProductoServicio;

        public ProductoController(IProductoServicio ProductoServicio)
        {
            this.ProductoServicio = ProductoServicio;
        }

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            ProductoModels Producto = new ProductoModels(ProductoServicio.FindById(id));
            return View(Producto);
        }

        // GET: Producto/Create
        public ActionResult Create(int id)
        {
            return View(new ProductoModels { CatalogoId = id });
        }

        [HttpPost]
        public ActionResult Create(ProductoModels producto, HttpPostedFileBase file)
        {

            if (file != null && file.ContentLength > 0)
            {
                try
                {


                    string imagepath = Server.MapPath("~/Images");

                    if (!Directory.Exists(imagepath))
                    {
                        Directory.CreateDirectory(imagepath);
                    }

                    string Nombre = Convert.ToString(System.Guid.NewGuid()) + Path.GetFileName(file.FileName);


                    string path = Path.Combine(imagepath,
                                             Nombre);


                    file.SaveAs(path);
                    producto.RutaImagen = Nombre;
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }

            }
            else {
                producto.RutaImagen = string.Empty;
            }

            ProductoServicio.CrearProducto(producto.ToProductDomain());
            return RedirectToAction("Details", "Catalogo", new { id = producto.CatalogoId });
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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
