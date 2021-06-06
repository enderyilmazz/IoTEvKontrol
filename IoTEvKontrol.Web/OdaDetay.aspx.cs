using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class OdaDetay : System.Web.UI.Page
    {
        static int CihazID;
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

            for (int i = 0; i < OdaTablo.Items.Count; i++)
            {
                var a = odalar[i];
                IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
                Cihaz.Ip = a.IpAdres;
                Cihaz.Port = Convert.ToInt32(a.PortNo);

                Cihaz.Bilgi = "c";
                TextBox Sicaklik = OdaTablo.Items[i].FindControl("TextBox1") as TextBox;
                int s = Convert.ToInt32(Cihaz.VeriGonderAl());
                Sicaklik.Text = s.ToString();

                Cihaz.Bilgi = "d";
                TextBox Nem = OdaTablo.Items[i].FindControl("TextBox2") as TextBox;
                Nem.Text = Cihaz.VeriGonderAl().ToString();
                int n = Convert.ToInt32(Cihaz.VeriGonderAl());
                Nem.Text = n.ToString();
            }
        }
        protected void OdaTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Kontrol")
            {
                Response.Write(e.CommandArgument.ToString());
                Response.Redirect("~/OdaKontrol.aspx?ID=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}