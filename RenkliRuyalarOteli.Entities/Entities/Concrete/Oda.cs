using RenkliRuyalarOteli.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{

    public class Oda:BaseEntity
    {
        public string OdaNo { get; set; }
        public byte KisiSayisi { get; set; }
        public bool Durum { get; set; } = true;
        public ICollection<OdaFiyat> OdaFiyatlari { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlari { get; set; }
        public Guid KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
