using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class KullaniciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/Giris.aspx");
                }
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var kullanici = new IdentityUser() { UserName = KullaniciAdi.Text };
            IdentityResult sonuc = manager.Create(kullanici, Sifre.Text);
            if (sonuc.Succeeded)
            {
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