using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfigurations
{
    public class KullaniciConfiguration:BaseEntityConfiguration<Kullanici>
    {
        public override void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.TcNo).HasMaxLength(11);
            builder.Property(p=>p.Email).HasMaxLength(50);
            //builder.HasData(new Kullanici
            //{
            //    Id=new Guid(),
            //    TcNo="123456",
            //    Email="admin@gmail.com"
            //});
        }
    }
}
