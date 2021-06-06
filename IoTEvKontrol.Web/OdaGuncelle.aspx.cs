using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class OdaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            if (!Page.IsPostBack)
            {
                IoTEvKontrol.Business.Oda Odalar = new IoTEvKontrol.Business.Oda();
                var oda = Odalar.OdaGetir(Convert.ToInt32(Request.QueryString["ID"]));
                OdaAd.Text = oda.OdaAdi;
                Aciklama.Text = oda.Aciklama;               
                IoTEvKontrol.Business.Cihazlar Cihazlar = new IoTEvKontrol.Business.Cihazlar();
                var cihaz = Cihazlar.CihazGetir(Convert.ToInt32(oda.CihazID));
                var cihazListe = Cihazlar.Listele();
                MevcutCihaz.Items.Add(cihaz.CihazAdi.ToString());
                foreach (var item in cihazListe)
                {
                    CihazListe.Items.Add(item.CihazAdi);
                }
            }
        }

        protected void Guncelle_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Cihazlar Cihazlar = new IoTEvKontrol.Business.Cihazlar();
            var cihaz = Cihazlar.CihazIdGetir(CihazListe.SelectedValue);
            IoTEvKontrol.Business.Oda Oda = new IoTEvKontrol.Business.Oda();
            Oda.EvID = 1;
            Oda.OdaAdi = OdaAd.Text;
            Oda.Aciklama = Aciklama.Text;
            Oda.CihazID = cihaz.ID;
            var Sonuc = Oda.Guncelle(Convert.ToInt32(Request.QueryString["ID"]));
            if (Sonuc == 1)
            {
                Response.Redirect("~/Odalar.aspx");
            }
        }
    }
}