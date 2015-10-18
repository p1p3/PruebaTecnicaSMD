using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using PruebaTecnica.Core.Productos;

namespace Data.EntityFramework.MapeoDb
{
    public class ProductoMap : EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {

            ToTable("Productos");

            HasKey(x => x.ProductoId);

            Property(x => x.ProductoId).
                HasColumnName("ProductoId").
                HasColumnType("int").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CatalogoId).
                HasColumnName("CatalogoId").
                HasColumnType("int").IsRequired();

            Property(x => x.Titulo).
                HasColumnName("Titulo").
                HasColumnType("nvarchar").
                HasMaxLength(100).
                IsRequired();

            Property(x => x.Descripcion).
                HasColumnName("Descripcion").
                HasColumnType("nvarchar").
                HasMaxLength(1000).
                IsRequired();

            Property(x => x.RutaImagen).
                HasColumnName("RutaImagen").
                HasColumnType("nvarchar").
                HasMaxLength(1000).
                IsRequired();

            Property(x => x.Categoria).
              HasColumnName("Categoria").
              HasColumnType("nvarchar").
              HasMaxLength(1000).
              IsRequired();

            Property(x => x.Precio).
              HasColumnName("Precio").
              HasColumnType("decimal").
              HasPrecision(18,0).
              IsRequired();

            HasRequired(x => x.catalogo).
                WithMany(x => x.Productos).
                HasForeignKey(x => x.CatalogoId);
        }


    }
}
