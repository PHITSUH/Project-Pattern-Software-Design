using PSDProject.Controller;
using PSDProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class AddMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }

        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string name = typeNameBox.Text;
            errorMessage.Text = MakeupTypeController.validateMakeupType(name);
            if(errorMessage.Text == "")
            {
                MakeupTypeController.addMakeup(name);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}