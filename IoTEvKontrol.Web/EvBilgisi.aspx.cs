using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class EvBilgisi : System.Web.UI.Page
    {
        static int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            if (!Page.IsPostBack)
            {
                IoTEvKontrol.Business.Ev EvBilgi = new IoTEvKontrol.Business.Ev();
                var ev = EvBilgi.Listele();
                EvAdi.Text = ev.EvAdi;
                Telefon.Text = ev.Telefon;
                Adres.Text = ev.Adres;
                IpAdres.Text = ev.IpAdres;
                Aciklama.Text = ev.Aciklama;
                id = ev.ID;
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Ev EvBilgi = new IoTEvKontrol.Business.Ev();
            EvBilgi.EvAdi = EvAdi.Text;
            EvBilgi.Telefon = Telefon.Text;
            EvBilgi.Adres = Adres.Text;
            EvBilgi.IpAdres = IpAdres.Text;
            EvBilgi.Aciklama = Aciklama.Text;
            var sonuc = EvBilgi.Guncelle(id);
            if (sonuc == 1)
            {
                BasariMesaj.Visible = true;
                UyariMesaj.Visible = false;
            }
            else
            {
                BasariMesaj.Visible = false;
                UyariMesaj.Visible = true;
            }
        }
    }
}