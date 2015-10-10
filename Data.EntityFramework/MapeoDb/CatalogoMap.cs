using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using PruebaTecnica.Core.Catalogos;


namespace Data.EntityFramework.MapeoDb
{
    public class CatalogoMap : EntityTypeConfiguration<Catalogo>
    {
        public CatalogoMap()
        {

            ToTable("Catalogos");

            HasKey(x => x.CatalogoId);

            Property(x => x.CatalogoId).
                HasColumnName("CatalogoId").
                HasColumnType("int").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CatalogoId).
                HasColumnName("CatalogoId").
                HasColumnType("int").IsRequired();

            Property(x => x.NombreCatalogo).
                HasColumnName("Nombre").
                HasColumnType("nvarchar").
                HasMaxLength(100).
                IsRequired();

            HasMany(x => x.Productos).
                WithRequired(x => x.catalogo).
                HasForeignKey(x => x.CatalogoId);
        }

    }
}
