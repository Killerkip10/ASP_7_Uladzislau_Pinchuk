using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using laba7.Models;
using Microsoft.Owin.Host.SystemWeb;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace laba7
{
    public partial class _Default : Page
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
            if (!AuthenticationManager.User.Identity.IsAuthenticated) Response.Redirect("/Login.aspx");
        }
    }
}