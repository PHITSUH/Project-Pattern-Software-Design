using PSDProject.Controller;
using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                User user = UserController.getUser(Convert.ToInt32(Session["user"]));
                usernameBox.Text = user.Username;
                emailBox.Text = user.UserEmail;
                if(user.UserGender == "Female")
                {
                    genderGroup.SelectedIndex = 0;
                }
                else
                {
                    genderGroup.SelectedIndex = 1;
                }
                dateBox.Text = user.UserDOB.ToString("yyyy-MM-dd");
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string email = emailBox.Text;
            string date = dateBox.Text;
            string gender = genderGroup.SelectedItem.Text;
            errorMessage.Text = UserController.updateUser(username, email, date, gender);
            if(errorMessage.Text == "")
            {
                UserController.updateUser(Convert.ToInt32(Session["user"]), username, email, gender, date);
                Response.Redirect("~/Views/Profile.aspx");
            }
        }

        protected void updatePassButton_Click(object sender, EventArgs e)
        {
            string oldPass = oldPassBox.Text;
            string newPass = newPassBox.Text;
            passErrorMessage.Text = UserController.updatePassword(Convert.ToInt32(Session["user"]), oldPass, newPass);
            if(passErrorMessage.Text == "")
            {
                UserController.updatePassword(Convert.ToInt32(Session["user"]), newPass);
                Response.Redirect("~/Views/Profile.aspx");
            }
        }
    }
}