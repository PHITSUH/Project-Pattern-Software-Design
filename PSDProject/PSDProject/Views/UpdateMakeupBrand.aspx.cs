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
    public partial class UpdateMakeupBrand : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                if(Request.QueryString["id"] == null)
                {
                    Response.Redirect("~/Views/ManageMakeup.aspx");
                }
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                MakeupBrand makeupBrand = MakeupBrandController.findMakeupBrand(id);
                brandNameBox.Text = makeupBrand.MakeupBrandName;
                brandRatingBox.Text = makeupBrand.MakeupBrandRating.ToString();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string name = brandNameBox.Text;
            int rating = Convert.ToInt32(brandRatingBox.Text);
            errorMessage.Text = MakeupBrandController.validateMakeupBrand(name, rating);
            if(errorMessage.Text == "")
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                MakeupBrandController.updateMakeupBrand(id, name, rating);
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}