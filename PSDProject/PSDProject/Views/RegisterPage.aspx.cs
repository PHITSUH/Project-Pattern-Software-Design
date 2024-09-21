using PSDProject.Controller;
using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            String username = usernameBox.Text;
            String gender = genderGroup.SelectedItem.Text;
            String password = passwordBox.Text;
            String email = emailBox.Text;
            String confirm = confirmBox.Text;
            String date = dateBox.Text;
            errorMessage.Text = UserController.registerUser(username, email, gender, password, confirm, date);
            if (errorMessage.Text == null || errorMessage.Text == "")
            {
                UserController.registerUser(username, email, gender, password, date);
                User user = UserController.findUser(username);
                Session["user"] = user.UserID;
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        
    }
}