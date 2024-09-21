using PSDProject.Controller;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            String login = UserController.loginUser(usernameBox.Text, passwordBox.Text);
            if(login != null)
            {
                errorMessage.Text = login;
                return;
            }
            User user = UserController.findUser(usernameBox.Text);
            Session["user"] = user.UserID;
            if(rememberMe.Checked)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie.Value = user.UserID.ToString();
                cookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}