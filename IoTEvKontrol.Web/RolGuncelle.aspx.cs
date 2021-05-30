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
    public partial class RolGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);

            IdentityRole Rol = RolManager.FindById(Request.QueryString["ID"].ToString());
            RolAd.Text = Rol.Name;
        }

        protected void Guncelle_Click(object sender, EventArgs e)
        {
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            IdentityRole Rol = RolManager.FindById(Request.QueryString["ID"].ToString());
            Rol.Name = YeniRolAd.Text;
            IdentityResult Sonuc = RolManager.Update(Rol);
            if (Sonuc.Succeeded)
            {
                Response.Redirect("~/Roller.aspx");
            }
        }
    }
}