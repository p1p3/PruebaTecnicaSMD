using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PruebaTecnica.Core.Catalogos;
using PruebaTecnica.Core.Productos;
using PruebaTecnica.Core.Repositorios;
using Data.EntityFramework.Utils;
using Data.EntityFramework.MapeoDb;

namespace Data.EntityFramework.Fachada
{
    public class FachadaDominio : DbContext
    {

        public DbSet<Producto> Productos { get; private set; }

        public DbSet<Catalogo> Catalogos { get; private set; }

        static FachadaDominio()
        {
            Database.SetInitializer(new InicializadorDB());
        }

        public FachadaDominio(string nameOrConnectionString = "PruebaTecnicaSMD") : base(nameOrConnectionString)
        {
            Productos = base.Set<Producto>();
            Catalogos = base.Set<Catalogo>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new CatalogoMap());
        }
    }
}
