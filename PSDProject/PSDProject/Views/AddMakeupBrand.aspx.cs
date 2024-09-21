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
    public partial class AddMakeupBrand : System.Web.UI.Page
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
            string name = brandNameBox.Text;
            int rating = Convert.ToInt32(brandRatingBox.Text);
            errorMessage.Text = MakeupBrandController.validateMakeupBrand(name, rating);
            if(errorMessage.Text == "")
            {
                MakeupBrandController.addMakeupBrand(name, rating);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}