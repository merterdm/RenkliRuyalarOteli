using RenkliRuyalarOteli.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkliRuyalarOteli.Entities.Entities.Concrete
{
    public class Rezervasyon:BaseEntity
    {
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }      
        public Guid OdaFiyatId { get; set; }
        public Guid OdaId { get; set; }
        public Oda Oda { get; set; }
        public OdaFiyat OdaFiyat { get; set; }
        public ICollection<RezervasyonDetay> RezervasyonDetaylari { get; set; }
        public Guid KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
