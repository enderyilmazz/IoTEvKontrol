using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IoTEvKontrol.WebService
{
    /// <summary>
    /// Summary description for IoTEvKontrolWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class IoTEvKontrolWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<IoTEvKontrol.Business.Sistem> SistemBilgisi()
        {
            List<IoTEvKontrol.Business.Sistem> SistemBilgileri = new List<Business.Sistem>();
            IoTEvKontrol.Business.Sistem SistemBilgi = new Business.Sistem();
            var GelenBilgi = SistemBilgi.Listele();
            foreach (var Bilgi in GelenBilgi)
            {
                IoTEvKontrol.Business.Sistem Sistem = new Business.Sistem();
                Sistem.KullaniciID = Convert.ToInt32(Bilgi.KullaniciID);
                Sistem.OdaID = Convert.ToInt32(Bilgi.OdaID);
                Sistem.IslemTipi = Bilgi.IslemTipi;
                Sistem.Tarih = Bilgi.Tarih;
                Sistem.Veri = Bilgi.Veri;
                Sistem.Durum = Bilgi.Durum;
                SistemBilgileri.Add(Sistem);
            }
            return SistemBilgileri;
        }
        [WebMethod]
        public void SensorVeriKaydet()
        {
            IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
            Cihaz.Ip = "192.168.1.36";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "c";
            int sicaklik = Convert.ToInt32(Cihaz.VeriGonderAl());

            IoTEvKontrol.Business.Sistem SistemBilgi = new Business.Sistem();
            SistemBilgi.OdaID = 10;
            SistemBilgi.IslemTipi = "Sıcaklık Sensör Okuması";
            SistemBilgi.Tarih = DateTime.Now.ToString();
            SistemBilgi.Veri = sicaklik.ToString();
            SistemBilgi.Durum = "Aktif";
            SistemBilgi.Ekle();

            Cihaz.Ip = "192.168.1.36";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "d";
            int nem = Convert.ToInt32(Cihaz.VeriGonderAl());

            SistemBilgi.OdaID = 10;
            SistemBilgi.IslemTipi = "Nem Sensör Okuması";
            SistemBilgi.Tarih = DateTime.Now.ToString();
            SistemBilgi.Veri = nem.ToString();
            SistemBilgi.Durum = "Aktif";
            SistemBilgi.Ekle();
        }
    }
}
