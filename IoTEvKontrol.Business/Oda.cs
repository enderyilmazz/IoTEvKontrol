using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEvKontrol.Business
{
    public class Oda
    {
        IoTEvKontrol.DataAccess.evkontrolEntities sorgu = new DataAccess.evkontrolEntities();
        
        public int EvID { get; set; }
        public int CihazID { get; set; }
        public string OdaAdi { get; set; }
        public string Aciklama { get; set; }

        public List<IoTEvKontrol.DataAccess.Oda> Listele()
        {
            var sonuc = sorgu.Oda.ToList();
            return sonuc;
        }

        public IoTEvKontrol.DataAccess.Oda OdaGetir(int id)
        {
            var aranan = sorgu.Oda.Where(p => p.ID == id).FirstOrDefault();
            return aranan;
        }

        public int Ekle()
        {
            IoTEvKontrol.DataAccess.Oda ekle = new DataAccess.Oda();
            ekle.EvID = EvID;
            ekle.CihazID = CihazID;
            ekle.OdaAdi = OdaAdi;
            ekle.Aciklama = Aciklama;
            sorgu.Oda.Add(ekle);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var aranan = sorgu.Oda.Where(p => p.ID == id).FirstOrDefault();
            sorgu.Oda.Remove(aranan);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var aranan = sorgu.Oda.Where(p => p.ID == id).FirstOrDefault();
            aranan.EvID = EvID;
            aranan.CihazID = CihazID;
            aranan.OdaAdi = OdaAdi;
            aranan.Aciklama = Aciklama;
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }
    }
}
