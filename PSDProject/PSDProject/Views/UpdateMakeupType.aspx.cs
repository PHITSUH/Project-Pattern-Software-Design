using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class UpdateMakeupType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("~/Views/ManageMakeup.aspx");
                }
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MakeupType mt = MakeupTypeController.findMakeupType(id);
                typeNameBox.Text = mt.MakeupTypeName;
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string name = typeNameBox.Text;
            errorMessage.Text = MakeupTypeController.validateMakeupType(name);
            if(errorMessage.Text == "")
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MakeupTypeController.updateMakeupType(id, name);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}