using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Repositorios;
using System.Linq.Expressions;
using System.Data.Entity;
using Data.EntityFramework.Fachada;

namespace Data.EntityFramework.Repositorios
{
    internal class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {

        private FachadaDominio _contexto;
        private DbSet<TEntity> _set;

        internal RepositorioGenerico(FachadaDominio contexto)
        {
            _contexto = contexto;
        }

        protected DbSet<TEntity> SetDb
        {
            get
            {
                _set = _set ?? _contexto.Set<TEntity>();
                return _set;
            }
        }

        public void Add(TEntity entity)
        {
            SetDb.Add(entity);
        }

        public TEntity FindById(object id)
        {
            return SetDb.Find(id);
        }

        public List<TEntity> PageAndFilter(int skip, int take, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Expression<Func<TEntity, object>> include = null )
        {
            IQueryable<TEntity> query = SetDb;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (include != null)
            {
                
                query = query.Include(include);

            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public void Remove(TEntity entity)
        {
            if (_contexto.Entry(entity).State == EntityState.Detached)
            {
                SetDb.Attach(entity);
            }
            SetDb.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            var entry = _contexto.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                SetDb.Attach(entity);
                entry = _contexto.Entry(entity);
            }
            entry.State = EntityState.Modified;
        }
    }
}
