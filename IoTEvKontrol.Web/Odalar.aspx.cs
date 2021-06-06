using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class Odalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            IoTEvKontrol.DataAccess.evkontrolEntities ent = new IoTEvKontrol.DataAccess.evkontrolEntities();
            var odalar = (from q in ent.Oda
                          join w in ent.Cihazlar on q.CihazID equals w.ID
                          select new
                          {
                              q.ID,
                              q.CihazID,
                              q.OdaAdi,
                              q.Aciklama,
                              w.CihazAdi,
                              w.IpAdres,
                              w.PortNo
                          }).ToList();
            OdaTablo.DataSource = odalar;
            OdaTablo.DataBind();
        }

        protected void OdaTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "odaSil")
            {
                IoTEvKontrol.Business.Oda Oda = new IoTEvKontrol.Business.Oda();
                var Sonuc = Oda.Sil(Convert.ToInt32(e.CommandArgument));
                if (Sonuc == 1)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    HataMesaj.Visible = true;
                }
            }
            if (e.CommandName == "odaGuncelle")
            {
                Response.Redirect("~/OdaGuncelle.aspx?ID=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}