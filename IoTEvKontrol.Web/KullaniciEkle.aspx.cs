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
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            foreach (var Rol in RolManager.Roles)
            {
                Roller.Items.Add(Rol.Name);
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            var UserStore = new UserStore<IdentityUser>();
            var UserManager = new UserManager<IdentityUser>(UserStore);
            var Kullanici = new IdentityUser()
            {
                UserName = KullaniciAdi.Text,
                Email = Eposta.Text,
                PhoneNumber = Telefon.Text
            };

            IdentityResult Sonuc = UserManager.Create(Kullanici, Sifre.Text);
            if (Sonuc.Succeeded)
            {
                UserManager.AddToRole(Kullanici.Id, Roller.SelectedValue);
                YeniKullanici.Text = KullaniciAdi.Text;
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