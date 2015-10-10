using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Repositorios;
using System.Threading;

namespace PruebaTecnica.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductoRepositorio ProductoRepositorio { get; }
        ICatalogoRepositorio CatalogoRepositorio { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
