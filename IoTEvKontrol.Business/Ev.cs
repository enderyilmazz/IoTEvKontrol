using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEvKontrol.Business
{
    public class Ev
    {
        IoTEvKontrol.DataAccess.evkontrolEntities sorgu = new DataAccess.evkontrolEntities();
        public string EvAdi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string IpAdres { get; set; }
        public string Aciklama { get; set; }

        public IoTEvKontrol.DataAccess.Ev Listele()
        {
            var sonuc = sorgu.Ev.ToList();
            return sonuc.FirstOrDefault();
        }

        public int Guncelle(int id)
        {
            var ev = sorgu.Ev.Where(p => p.ID == id).FirstOrDefault();
            ev.EvAdi = EvAdi;
            ev.Telefon = Telefon;
            ev.Adres = Adres;
            ev.IpAdres = IpAdres;
            ev.Aciklama = Aciklama;
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }
    }
}
