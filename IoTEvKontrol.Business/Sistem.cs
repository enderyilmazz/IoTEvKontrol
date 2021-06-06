using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEvKontrol.Business
{
    public class Sistem
    {
        IoTEvKontrol.DataAccess.evkontrolEntities sorgu = new DataAccess.evkontrolEntities();
        public int KullaniciID { get; set; }
        public int OdaID { get; set; }
        public string IslemTipi { get; set; }
        public string Tarih { get; set; }
        public string Veri { get; set; }
        public string Durum { get; set; }

        public List<IoTEvKontrol.DataAccess.Sistem> Listele()
        {
            var sonuc = sorgu.Sistem.ToList();
            return sonuc;
        }
        public int Ekle()
        {
            IoTEvKontrol.DataAccess.Sistem ekle = new DataAccess.Sistem();
            ekle.KullaniciID = KullaniciID;
            ekle.OdaID = OdaID;
            ekle.IslemTipi = IslemTipi;
            ekle.Tarih = Tarih;
            ekle.Veri = Veri;
            ekle.Durum = Durum;
            sorgu.Sistem.Add(ekle);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }
        public int Sil(int id)
        {
            var aranan = sorgu.Sistem.Where(p => p.ID == id).FirstOrDefault();
            sorgu.Sistem.Remove(aranan);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }
    }
}
