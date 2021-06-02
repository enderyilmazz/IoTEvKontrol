using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
            Cihaz.Ip = "192.168.1.35";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "a";
            Label1.Text = "Durum : " + Cihaz.VeriGonderAl();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
            Cihaz.Ip = "192.168.1.35";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "b";
            Label1.Text = "Durum : " + Cihaz.VeriGonderAl();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
            Cihaz.Ip = "192.168.1.35";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "c";
            Label1.Text = "Sıcaklık : " + Cihaz.VeriGonderAl() + "°C";
            TextBox1.Text = Cihaz.VeriGonderAl();


            string dene = "$(function() {$('.knob').knob({ })})";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "dene", dene, true);
        }

        protected void Nem_Click(object sender, EventArgs e)
        {
            IoTEvKontrol.Business.Arduino Cihaz = new IoTEvKontrol.Business.Arduino();
            Cihaz.Ip = "192.168.1.35";
            Cihaz.Port = 80;
            Cihaz.Bilgi = "d";
            Label1.Text = "Nem : %" + Cihaz.VeriGonderAl();
            int abc = Convert.ToInt32(Cihaz.VeriGonderAl());
            TextBox2.Text = abc.ToString();

            string dene = "$(function() {$('.knob').knob({ })})";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "dene", dene, true);
        }
    }
}