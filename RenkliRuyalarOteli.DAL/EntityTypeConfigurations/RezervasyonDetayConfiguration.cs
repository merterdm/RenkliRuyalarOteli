using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfigurations
{
    public class RezervasyonDetayConfiguration:BaseEntityConfiguration<RezervasyonDetay>
    {
        public override void Configure(EntityTypeBuilder<RezervasyonDetay> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Rezervasyon)
                    .WithMany(p => p.RezervasyonDetaylari)
                    .HasForeignKey(p => p.RezervasyonId)
                    .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

            builder.HasOne(p => p.Kullanici)
              .WithMany(p => p.RezervasyonDetaylari)
              .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);
        }
    }
}
