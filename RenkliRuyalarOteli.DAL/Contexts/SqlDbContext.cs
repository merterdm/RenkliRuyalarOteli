using Microsoft.EntityFrameworkCore;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.DAL.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<OdaFiyat> OdaFiyatlari { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=RenkliRuyalarOteli;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
