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
    public partial class RolEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            var Rol = new IdentityRole() { Name = RolAd.Text };
            IdentityResult Sonuc = RolManager.Create(Rol);
            if (Sonuc.Succeeded)
            {
                YeniRol.Text = RolAd.Text;
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