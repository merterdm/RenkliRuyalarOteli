using RenkliRuyalarOteli.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class Musteri:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public string MusteriTcNo { get; set; }
        public string CepNo { get; set; }
        public Guid KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlari { get; set; }
    }
}
