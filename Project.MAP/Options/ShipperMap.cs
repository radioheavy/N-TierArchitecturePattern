using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ShipperMap : BaseMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargolar");
            Property(x => x.CompanyName).HasColumnName("Sirket Ismi");

            //Çoka çok ilişkinin tamamlanması
            HasMany(x => x.Orders).WithRequired(x => x.Shipper).HasForeignKey(x => x.ShipperID);
        }
    }
}
