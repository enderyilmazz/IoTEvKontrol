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
    public partial class KullaniciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            Rol.Items.Clear();
            var UserStore = new UserStore<IdentityUser>();
            var UserManager = new UserManager<IdentityUser>(UserStore);
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            IdentityUser Kullanici = UserManager.FindById(Request.QueryString["ID"].ToString());
            var KullaniciRolleri = RolManager.Roles.Where(m => m.Users.Any(r => r.UserId == Kullanici.Id)).ToList();

            Eposta.Text = Kullanici.Email;
            Telefon.Text = Kullanici.PhoneNumber;
            KullaniciAdi.Text = Kullanici.UserName;

            foreach (var Rol in RolManager.Roles)
            {
                YeniRol.Items.Add(Rol.Name);
            }
            foreach (var KullaniciRol in KullaniciRolleri)
            {
                Rol.Items.Add(KullaniciRol.Name);
            }
        }
        protected void Guncelle_Click(object sender, EventArgs e)
        {
            var UserStore = new UserStore<IdentityUser>();
            var UserManager = new UserManager<IdentityUser>(UserStore);
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            IdentityUser Kullanici = UserManager.FindById(Request.QueryString["ID"].ToString());
            Kullanici.Email = Eposta.Text;
            Kullanici.PhoneNumber = Eposta.Text;

            UserManager.RemoveFromRole(Kullanici.Id, Rol.Text);
            UserManager.AddToRole(Kullanici.Id, YeniRol.SelectedValue);
            UserManager.Update(Kullanici);
            IdentityResult SifreSonuc = UserManager.ChangePassword(Kullanici.Id, MevcutSifre.Text, YeniSifre.Text);

            Response.Redirect("~/Kullanicilar.aspx");
        }
    }
}