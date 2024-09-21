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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                int id = (Int32)Session["user"];
                User user = UserController.getUser(id);
                pageTitle.InnerText = "Welcome, " + user.UserRole + " " + user.Username;
                if (UserController.roleIsAdmin(id))
                {
                    customerView.DataSource = UserController.getAllUsers();
                    customerView.DataBind();
                }
            }
        }
    }
}