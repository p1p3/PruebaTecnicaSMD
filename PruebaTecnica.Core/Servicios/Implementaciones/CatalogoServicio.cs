using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Repositorios;
using PruebaTecnica.Core.UnitOfWork;
using PruebaTecnica.Core.Servicios.Interfaces;
using System.Linq.Expressions;

namespace PruebaTecnica.Core.Servicios.Interfaces
{
   public class CatalogoServicio : ICatalogoServicio

    {
        private IUnitOfWork UnitOfWork;

        public CatalogoServicio(IUnitOfWork UFW)
        {
            UnitOfWork = UFW;
        }

        public void ActualizarCatalogo(Catalogo catalgo)
        {
            UnitOfWork.CatalogoRepositorio.Add(catalgo);
            UnitOfWork.SaveChanges();
        }

        public void BorrarCatalogo(Catalogo catalogo)
        {
            UnitOfWork.CatalogoRepositorio.Remove(catalogo);
            UnitOfWork.SaveChanges();
        }

        public void CrearCatalogo(Catalogo catalogo)
        {
            UnitOfWork.CatalogoRepositorio.Add(catalogo);
            UnitOfWork.SaveChanges();
        }

        public Catalogo FindById(int id)
        {
            return UnitOfWork.CatalogoRepositorio.FindById(id);
        }

        public List<Catalogo> PageAndFilter(int skip, int take, Expression<Func<Catalogo, bool>> filter = null, Func<IQueryable<Catalogo>, IOrderedQueryable<Catalogo>> orderBy = null)
        {
            return UnitOfWork.CatalogoRepositorio.PageAndFilter(skip, take, filter, orderBy);
        }
    }
}
