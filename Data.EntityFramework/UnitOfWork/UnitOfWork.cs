using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.UnitOfWork;
using Data.EntityFramework.Fachada;
using PruebaTecnica.Core.Repositorios;
using System.Threading;

namespace Data.EntityFramework.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private FachadaDominio _context { get; }
        private IProductoRepositorio _ProductoRepositorio;
        private ICatalogoRepositorio _CatalogoRepositorio;


        public UnitOfWork(string nameOrConnectionString)
        {

            _context = new FachadaDominio(nameOrConnectionString);
        }

        public IProductoRepositorio ProductoRepositorio
        {
            get
            {
                if (_ProductoRepositorio == null)
                {
                    _ProductoRepositorio = new Repositorios.ProductosRepositorio(_context);
                }
                return _ProductoRepositorio;

               }
        }

        public ICatalogoRepositorio CatalogoRepositorio
        {
            get
            {
                if (_CatalogoRepositorio == null)
                {
                    _CatalogoRepositorio = new Repositorios.CatalogoRepositorio(_context);
                }
                return _CatalogoRepositorio;

            }
        }


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        #region IDisposable 
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _CatalogoRepositorio = null;
                    _ProductoRepositorio = null;
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

      
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
