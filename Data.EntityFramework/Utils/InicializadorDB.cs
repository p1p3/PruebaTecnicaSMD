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

            int CantidadProductos = 10;
            Producto producto;
            var productos = new List<Producto>();
            for (int i = 0; i < CantidadProductos; i++)
            {
                producto = new Producto()
                {
                    Titulo = "Producto" + i,
                    Precio = i,
                    Descripcion = "DescripcionProducto" + i,
                    Categoria = "Categoria" + i,
                    RutaImagen = "none",
                    catalogo = Catalogo

                };
                productos.Add(producto);
            }



            context.Productos.AddRange(productos);

            base.Seed(context);
        }
    }
}
