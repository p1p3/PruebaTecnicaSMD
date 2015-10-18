using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Productos;
using System.Linq.Expressions;

namespace PruebaTecnica.Core.Servicios.Interfaces
{
   public interface IProductoServicio
    {
        Producto FindById(int id);
        void CrearProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void BorrarProducto(Producto producto);
        List<Producto> PageAndFilter(int skip, int take, Expression<Func<Producto, bool>> filter = null, Func<IQueryable<Producto>, IOrderedQueryable<Producto>> orderBy = null, Expression<Func<Producto, object>> include = null);
    }
}
