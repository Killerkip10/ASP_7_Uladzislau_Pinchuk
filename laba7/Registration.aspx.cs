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
using Microsoft.AspNet.Identity.Owin;
//using Microsoft.AspNet.WebApi.Owin;

namespace laba7
{
    public partial class Registration : System.Web.UI.Page
    {
        private ApplicationContext db = new ApplicationContext();
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatingUser(object sender, LoginCancelEventArgs e)
        {
            string name = CreateUserWizard1.UserName;
            string password = CreateUserWizard1.Password;
            string email = CreateUserWizard1.Email;
            if (ModelState.IsValid)
            {
                User user = new User { UserName = name, Email = email };
                IdentityResult result = UserManager.Create(user, password);
                if (result.Succeeded)
                {
                    Response.Redirect("/Login.aspx");
                }
                else
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }
        }
    }
}