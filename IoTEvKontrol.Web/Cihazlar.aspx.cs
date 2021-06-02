using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class Cihazlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            IoTEvKontrol.Business.Cihazlar cihazlar = new IoTEvKontrol.Business.Cihazlar();
            var cihaz =  cihazlar.Listele();
            CihazTablo.DataSource = cihaz;
            CihazTablo.DataBind();
        }

        protected void CihazTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "cihazSil")
            {
                IoTEvKontrol.Business.Cihazlar cihazlar = new IoTEvKontrol.Business.Cihazlar();
                var Sonuc = cihazlar.Sil(Convert.ToInt32(e.CommandArgument));
                if (Sonuc == 1)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    HataMesaj.Visible = true;
                }
            }
            if (e.CommandName == "cihazGuncelle")
            {
                Response.Redirect("~/CihazGuncelle.aspx?ID=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}