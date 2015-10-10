using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Repositorios;

namespace Data.EntityFramework.Repositorios
{
   internal class CatalogoRepositorio : RepositorioGenerico<Catalogo>, ICatalogoRepositorio
    {
        internal CatalogoRepositorio(Fachada.FachadaDominio contexto) : base(contexto) { }
    }
}
