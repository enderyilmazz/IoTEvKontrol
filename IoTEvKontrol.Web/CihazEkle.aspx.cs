using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class CihazEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Cihazlar Cihaz = new IoTEvKontrol.Business.Cihazlar();
            Cihaz.CihazAdi = CihazAd.Text;
            Cihaz.IpAdres = IpNo.Text;
            Cihaz.PortNo = PortNo.Text;
            var sonuc = Cihaz.Ekle();
            if (sonuc == 1)
            {
                YeniCihaz.Text = CihazAd.Text;
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