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


            var productos = new List<Producto>
            {
              new Producto {Titulo = "Producto1",Descripcion="DescripcionProducto2",RutaImagen ="asdad1",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto2",Descripcion="DescripcionProducto1",RutaImagen ="asdad2",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto3",Descripcion="DescripcionProducto3",RutaImagen ="asdad3",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto4",Descripcion="DescripcionProducto4",RutaImagen ="asdad4",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto5",Descripcion="DescripcionProducto5",RutaImagen ="asdad5",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto6",Descripcion="DescripcionProducto6",RutaImagen ="asdad6",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto7",Descripcion="DescripcionProducto7",RutaImagen ="asdad7",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto9",Descripcion="DescripcionProducto9",RutaImagen ="asdad9",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
              new Producto {Titulo = "Producto10",Descripcion="DescripcionProducto10",RutaImagen ="asdad10",CatalogoId = Catalogo.CatalogoId,catalogo = Catalogo },
            };
            context.Productos.AddRange(productos);

            base.Seed(context);
                    }
    }
}
