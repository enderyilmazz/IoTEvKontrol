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
    public partial class Kullanicilar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            //if (!User.IsInRole("Admin"))
            //{
            //    Label1.Text = "Burası Yetki Dışı";
            //}

            var UserStore = new UserStore<IdentityUser>();
            var UserManager = new UserManager<IdentityUser>(UserStore);
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            KullaniciTablo.DataSource = UserManager.Users.ToList();
            KullaniciTablo.DataBind();
        }

        protected void KullaniciTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "kullaniciSil")
            {
                var UserStore = new UserStore<IdentityUser>();
                var UserManager = new UserManager<IdentityUser>(UserStore);
                IdentityUser Kullanici = UserManager.FindById(e.CommandArgument.ToString());
                IdentityResult Sonuc = UserManager.Delete(Kullanici);
                if (Sonuc.Succeeded)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    HataMesaj.Visible = true;
                }
            }
            if (e.CommandName == "kullaniciGuncelle")
            {
                Response.Redirect("~/KullaniciGuncelle.aspx?ID=" + e.CommandArgument.ToString() + "");
            }
        }
    }
}