using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEvKontrol.Business
{
    public class Cihazlar
    {
        public string CihazAdi { get; set; }
        public string IpAdres { get; set; }
        public string PortNo { get; set; }

        IoTEvKontrol.DataAccess.evkontrolEntities sorgu = new DataAccess.evkontrolEntities();
        public List<IoTEvKontrol.DataAccess.Cihazlar> Listele()
        {
            var sonuc = sorgu.Cihazlar.ToList();
            return sonuc;
        }

        public IoTEvKontrol.DataAccess.Cihazlar CihazGetir(int id)
        {
            var aranan = sorgu.Cihazlar.Where(p => p.ID == id).FirstOrDefault();
            return aranan;
        }

        public IoTEvKontrol.DataAccess.Cihazlar CihazIdGetir(string cihazAdi)
        {
            var aranan = sorgu.Cihazlar.Where(p => p.CihazAdi == cihazAdi).FirstOrDefault();
            return aranan;
        }

        public int Ekle()
        {
            IoTEvKontrol.DataAccess.Cihazlar ekle = new DataAccess.Cihazlar();
            ekle.CihazAdi = CihazAdi;
            ekle.IpAdres = IpAdres;
            ekle.PortNo = PortNo;
            sorgu.Cihazlar.Add(ekle);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }

        public int Sil(int id)
        {
            var aranan = sorgu.Cihazlar.Where(p => p.ID == id).FirstOrDefault();
            sorgu.Cihazlar.Remove(aranan);
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }

        public int Guncelle(int id)
        {
            var aranan = sorgu.Cihazlar.Where(p => p.ID == id).FirstOrDefault();
            aranan.CihazAdi = CihazAdi;
            aranan.IpAdres = IpAdres;
            aranan.PortNo = PortNo;
            var sonuc = sorgu.SaveChanges();
            return sonuc;
        }
    }
}
