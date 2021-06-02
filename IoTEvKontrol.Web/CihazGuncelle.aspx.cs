using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class CihazGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            if (!Page.IsPostBack)
            {
                IoTEvKontrol.Business.Cihazlar Cihazlar = new IoTEvKontrol.Business.Cihazlar();
                var cihaz = Cihazlar.CihazGetir(Convert.ToInt32(Request.QueryString["ID"]));
                CihazAd.Text = cihaz.CihazAdi;
                IpAdres.Text = cihaz.IpAdres;
                PortNo.Text = cihaz.PortNo;
            }
        }

        protected void Guncelle_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Cihazlar Cihaz = new IoTEvKontrol.Business.Cihazlar();
            Cihaz.CihazAdi = CihazAd.Text;
            Cihaz.IpAdres = IpAdres.Text;
            Cihaz.PortNo = PortNo.Text;
            var Sonuc = Cihaz.Guncelle(Convert.ToInt32(Request.QueryString["ID"]));
            if (Sonuc == 1)
            {
                Response.Redirect("~/Cihazlar.aspx");
            }
        }
    }
}