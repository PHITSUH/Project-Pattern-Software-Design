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
    public partial class AddMakeup : System.Web.UI.Page
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

        protected void addButton_Click(object sender, EventArgs e)
        {
            string name = makeupNameBox.Text;
            string price = makeupPriceBox.Text;
            string weight = makeupWeightBox.Text;
            string brandId = makeupBrandIDBox.Text;
            string typeId = makeupTypeIDBox.Text;
            
            errorMessage.Text = MakeupController.validateMakeup(name, price, weight, brandId, typeId);
            if (errorMessage.Text == "")
            {
                MakeupController.addMakeup(name, Convert.ToInt32(price), Convert.ToInt32(weight), Convert.ToInt32(brandId)
                    , Convert.ToInt32(typeId));
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }
    }
}