using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Catalogos;
using System.Linq.Expressions;

namespace PruebaTecnica.Core.Servicios.Interfaces
{
    public interface ICatalogoServicio
    {
        Catalogo FindById(int id);
        void CrearCatalogo(Catalogo Catalogo);
        void ActualizarCatalogo(Catalogo catalgo);
        void BorrarCatalogo(Catalogo catalogo);
        List<Catalogo> PageAndFilter(int skip, int take, Expression<Func<Catalogo, bool>> filter = null, Func<IQueryable<Catalogo>, IOrderedQueryable<Catalogo>> orderBy = null, Expression<Func<Catalogo, object>> include = null);
    }
}
