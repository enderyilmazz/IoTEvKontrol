using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class OdaEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            if (!Page.IsPostBack)
            {
                IoTEvKontrol.Business.Cihazlar Cihaz = new IoTEvKontrol.Business.Cihazlar();
                var Cihazlar = Cihaz.Listele();
                foreach (var item in Cihazlar)
                {
                    CihazListe.Items.Add(item.CihazAdi);
                }
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Cihazlar Cihazlar = new IoTEvKontrol.Business.Cihazlar();
            var Cihaz = Cihazlar.CihazIdGetir(CihazListe.SelectedValue);
            IoTEvKontrol.Business.Oda Oda = new IoTEvKontrol.Business.Oda();
            Oda.EvID = 1;
            Oda.CihazID = Cihaz.ID;
            Oda.OdaAdi = OdaAd.Text;
            Oda.Aciklama = Aciklama.Text;
            var sonuc = Oda.Ekle();
            if (sonuc == 1)
            {
                YeniOda.Text = OdaAd.Text;
                BasariMesaj.Visible = true;
                HataMesaj.Visible = false;
            }
            else
            {
                BasariMesaj.Visible = false;
                HataMesaj.Visible = true;
            }
        }
    }
}