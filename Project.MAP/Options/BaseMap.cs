using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public abstract class BaseMap<T> :EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseMap()
        {
            //HasColumnName metodu ile ilgili property'lerin hangi kolonlara denk geldiğini belirtiyoruz.
            Property(x => x.CreatedDate).HasColumnName("Veri Yaratma Tarihi").IsOptional();
            Property(x => x.DeletedDate).HasColumnName("Veri Silme Tarihi").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("Veri Guncelleme Tarihi").IsOptional();
            Property(x => x.Status).HasColumnName("Veri Durumu").IsOptional();
        }        
    }
}
