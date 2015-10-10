using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Productos;
using PruebaTecnica.Core.Repositorios;
using PruebaTecnica.Core.UnitOfWork;
using PruebaTecnica.Core.Servicios.Interfaces;
using System.Linq.Expressions;

namespace PruebaTecnica.Core.Servicios.Implementaciones
{
    public class ProductoService : IProductoServicio

    {

        private IUnitOfWork UnitOfWork;

        public ProductoService(IUnitOfWork UFW)
        {
            UnitOfWork = UFW;
        }

        public void ActualizarProducto(Producto producto)
        {
            UnitOfWork.ProductoRepositorio.Add(producto);
            UnitOfWork.SaveChanges();
        }

        public void BorrarProducto(Producto producto)
        {
            UnitOfWork.ProductoRepositorio.Remove(producto);
            UnitOfWork.SaveChanges();
        }

        public void CrearProducto(Producto producto)
        {
            if (producto.catalogo == null)
            {
                producto.catalogo= UnitOfWork.CatalogoRepositorio.FindById(producto.CatalogoId);
            }

            UnitOfWork.ProductoRepositorio.Add(producto);
            UnitOfWork.SaveChanges();
        }

        public Producto FindById(int id)
        {
            return UnitOfWork.ProductoRepositorio.FindById(id);
        }

        public List<Producto> PageAndFilter(int skip, int take, Expression<Func<Producto, bool>> filter = null, Func<IQueryable<Producto>, IOrderedQueryable<Producto>> orderBy = null)
        {
            return UnitOfWork.ProductoRepositorio.PageAndFilter(skip, take, filter, orderBy);
        }
    }
}
