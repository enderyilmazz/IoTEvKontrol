using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class Roller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Giris.aspx");
            }
            var RolStore = new RoleStore<IdentityRole>();
            var RolManager = new RoleManager<IdentityRole>(RolStore);
            RolTablo.DataSource = RolManager.Roles.ToList();
            RolTablo.DataBind();
        }

        protected void RolTabloCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "rolSil")
            {
                var RolStore = new RoleStore<IdentityRole>();
                var RolManager = new RoleManager<IdentityRole>(RolStore);
                IdentityRole Rol = RolManager.FindById(e.CommandArgument.ToString());
                IdentityResult Sonuc = RolManager.Delete(Rol);
                if (Sonuc.Succeeded)
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
            if (e.CommandName == "rolGuncelle")
            {
                Response.Redirect("~/RolGuncelle.aspx?ID="+e.CommandArgument.ToString()+"");
            }
        }

    }
}