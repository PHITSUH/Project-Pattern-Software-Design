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
    public partial class UpdateMakeup : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                Makeup makeup = MakeupController.findMakeup(id);
                makeupNameBox.Text = makeup.MakeupName;
                makeupPriceBox.Text = Convert.ToString(makeup.MakeupPrice);
                makeupWeightBox.Text = Convert.ToString(makeup.MakeupWeight);
                makeupBrandIDBox.Text = Convert.ToString(makeup.MakeupBrandID);
                makeupTypeIDBox.Text = Convert.ToString(makeup.MakeupTypeID);
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string name = makeupNameBox.Text;
            string price = makeupPriceBox.Text;
            string weight = makeupWeightBox.Text;
            string brandId = makeupBrandIDBox.Text;
            string typeId = makeupTypeIDBox.Text;
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            errorMessage.Text = MakeupController.validateMakeup( name, price, weight, brandId, typeId);
            if(errorMessage.Text == "")
            {
                MakeupController.updateMakeup(id, name, Convert.ToInt32(price), Convert.ToInt32(weight), Convert.ToInt32(brandId)
                    , Convert.ToInt32(typeId));
                Response.Redirect("~/Views/ManageMakeup.aspx");
            }
        }
    }
}