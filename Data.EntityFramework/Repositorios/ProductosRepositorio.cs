using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Productos;
using PruebaTecnica.Core.Repositorios;

namespace Data.EntityFramework.Repositorios
{
    internal class ProductosRepositorio : RepositorioGenerico<Producto>,IProductoRepositorio
    {
        internal ProductosRepositorio(Fachada.FachadaDominio contexto) : base(contexto) { }
    }
}
