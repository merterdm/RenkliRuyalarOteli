﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.EntityTypeConfigurations
{
    public class OdaConfiguration:BaseEntityConfiguration<Oda>
    {
        public override void Configure(EntityTypeBuilder<Oda> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.OdaNo).HasMaxLength(50);
            builder.HasOne(p => p.Kullanici)
                .WithMany(p => p.Odalar)
                .HasForeignKey(p => p.KullaniciId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);
        }
    }
}