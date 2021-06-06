using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class OdaKontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            int CihazID = Convert.ToInt32(Request.QueryString["ID"]);
            IoTEvKontrol.DataAccess.evkontrolEntities ent = new IoTEvKontrol.DataAccess.evkontrolEntities();
            var odalar = (from q in ent.Oda
                          join w in ent.Cihazlar on q.CihazID equals w.ID
                          where q.CihazID == CihazID
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
            
            //OdaTablo.DataSource = odalar;
            //OdaTablo.DataBind();
        }
    }
}