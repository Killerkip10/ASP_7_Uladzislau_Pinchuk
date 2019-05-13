using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using laba7.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Principal;
using System.Security.Claims;

namespace laba7
{
    public partial class SiteMaster : MasterPage
    {
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AuthenticationManager.SignOut();
            Response.Redirect("/Login.aspx");
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }
    }
}