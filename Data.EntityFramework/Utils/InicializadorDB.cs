using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.EntityFramework.Fachada;
using PruebaTecnica.Core.Productos;
using PruebaTecnica.Core.Catalogos;

namespace Data.EntityFramework.Utils
{
    class InicializadorDB : DropCreateDatabaseIfModelChanges<FachadaDominio>
    {
        protected override void Seed(FachadaDominio context)
        {

            Catalogo Catalogo = new Catalogo { NombreCatalogo = "Catálogo 1" };
            context.Catalogos.Add(Catalogo);

            //int CantidadProductos = 10;
            //Producto producto;
            //var productos = new List<Producto>();
            //for (int i = 0; i < CantidadProductos; i++)
            //{
            //    producto = new Producto()
            //    {
            //        Titulo = "Producto" + i,
            //        Precio = i,
            //        Descripcion = "DescripcionProducto" + i,
            //        Categoria = "Categoria" + i,
            //        RutaImagen = "none",
            //        catalogo = Catalogo

            //    };
            //    productos.Add(producto);
            //}


            var productos = new List<Producto>
            {
              new Producto {Titulo = "Kayak",Descripcion="A boat for one person",RutaImagen ="none",Categoria = "Watersports",Precio=275m, CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Lifejacket",Descripcion="Protective and fashionable",RutaImagen ="none",Categoria = "Watersports",Precio=48.95m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Soccer Ball",Descripcion="FIFA-approved size and weight",RutaImagen ="none",Categoria = "Soccer",Precio=19.5m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Corner Flags",Descripcion="Give your playing field a professional touch",RutaImagen ="none",Categoria = "Soccer",Precio=34.95m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Stadium",Descripcion="Flat-packed 35,000-seat stadium",RutaImagen ="none",Categoria = "Soccer",Precio=79500.00m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Thinking Cap",Descripcion="Improve your brain effciency by 75%",RutaImagen ="none",Categoria = "Chess",Precio=16m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Unsteady Chair",Descripcion="Secretly give your opponents  a disvantage",RutaImagen ="none",Categoria = "Chess",Precio=29.95m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Human Chess Board",Descripcion="A fun game for the family",RutaImagen ="none",Categoria = "Chess",Precio=75m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Bling-Bling King",Descripcion="Gold-Plated, diamond-studded King",RutaImagen ="none",Categoria = "Chess",Precio=1200m,CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
            };
            context.Productos.AddRange(productos);

            base.Seed(context);
        }
    }
}
