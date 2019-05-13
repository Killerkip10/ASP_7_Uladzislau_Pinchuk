using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Claims;
using Microsoft.Owin.Security;
using laba7.Models;

namespace laba7
{
    public partial class Customers : System.Web.UI.Page
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

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            string age = ageTextBox.Text;
            string gender = genderTextBox.Text;
            string job = jobTextBox.Text;
            string weight = weightTextBox.Text;
            string width = widthTextBox.Text;
            string passport = PassportTextBox.Text;
            string nationalityId = DropDownList1.SelectedItem.Value;

            if (fullName == "" 
                || age == ""
                || gender == ""
                || job == ""
                || weight == ""
                || width == ""
                || passport == ""
                || nationalityId == ""
            )
            {
                Label1.Text = "Invalid data";
                return;
            }

            Customer customer = new Customer()
            {
                FullName = fullName,
                Age = Convert.ToInt32(age),
                Gender = gender,
                Job = job,
                Weight = Convert.ToInt32(weight),
                Width = Convert.ToInt32(width),
                Passport = passport,
                NationalityId = Convert.ToInt32(nationalityId),
            };

            db.Customers.Add(customer);
            db.SaveChanges();

            Label1.Text = "";
            fullNameTextBox.Text = "";
            ageTextBox.Text = "";
            genderTextBox.Text = "";
            jobTextBox.Text = "";
            weightTextBox.Text = "";
            widthTextBox.Text = "";
            PassportTextBox.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}