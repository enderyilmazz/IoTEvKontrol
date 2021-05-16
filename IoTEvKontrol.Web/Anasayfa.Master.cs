using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IoTEvKontrol.Web
{
    public partial class Anasayfa : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.Page sayfa = new System.Web.UI.Page();
            if (sayfa.User.Identity.IsAuthenticated)
            {
                kullaniciBilgi.Text = sayfa.User.Identity.GetUserName();
            }
        }

        protected void Cikis_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Giris.aspx");
        }
    }
}