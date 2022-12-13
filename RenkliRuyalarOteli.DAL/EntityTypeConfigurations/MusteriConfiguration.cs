using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Abstract;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfigurations
{
    public class MusteriConfiguration: BaseEntityConfiguration<Musteri>
    {
        public override void Configure(EntityTypeBuilder<Musteri> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.MusteriTcNo).HasMaxLength(11);
            builder.Property(p=>p.Ad).HasMaxLength(30);
            builder.Property(p=>p.Soyad).HasMaxLength(30);
            builder.Property(p=>p.CepNo).HasMaxLength(20);

            builder.HasOne(p => p.Kullanici)
                .WithMany(p => p.Musteriler)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);
        }

    }
}
