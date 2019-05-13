using laba7.Models;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laba7
{
    public partial class Services : System.Web.UI.Page
    {
        private ApplicationContext db = new ApplicationContext();

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!AuthenticationManager.User.Identity.IsAuthenticated)
            {
                Response.Redirect("/Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string price = priceTextBox.Text;

            if (name == "" || price == "")
            {
                Label1.Text = "Invalid data";
                return;
            }

            Service service = new Service()
            {
                Name = name,
                Price = Convert.ToInt32(price),
            };

            db.Services.Add(service);
            db.SaveChanges();

            nameTextBox.Text = "";
            priceTextBox.Text = "";
            Label1.Text = "";
        }
    }
}