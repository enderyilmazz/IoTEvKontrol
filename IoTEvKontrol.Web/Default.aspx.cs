using Microsoft.AspNet.Identity;
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
            //string baglanti = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            //SqlConnection baglan = new SqlConnection(baglanti);
            //SqlCommand sorgu = new SqlCommand("SELECT * FROM Roller",baglan);
            //SqlDataReader oku;
            //baglan.Open();
            //oku = sorgu.ExecuteReader();
            //GridView1.DataSource = gelen;
            //GridView1.DataBind();
            //baglan.Close();

            //IoTEvKontrol.Business.Roller Rol = new IoTEvKontrol.Business.Roller();
            //Rol.RolAdi = "Deneme";
            //Rol.Aciklama = "Test";
            //Rol.Ekle();

            //IoTEvKontrol.Business.Roller Rol = new IoTEvKontrol.Business.Roller();
            //Rol.RolAdi = "User2";
            //Rol.Aciklama = "User2";
            //Rol.Guncelle(6);

            //GridView1.DataSource = Rol.Listele();
            //GridView1.DataBind();
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
            int abc = Convert.ToInt32(Cihaz.VeriGonderAl());
            TextBox1.Text = abc.ToString();

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