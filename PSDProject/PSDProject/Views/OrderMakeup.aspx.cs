using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Repository
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UserController.adminAuthenticate(Session["user"]))
                {
                    //Response.Write("Test <br/>");
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }
            List<Makeup> makeups = MakeupController.getAllMakeups();
            makeupView.DataSource = makeups;
            makeupView.DataBind();
            List<Cart> carts = CartController.getAllCartsByUserId(Convert.ToInt32(Session["user"]));
                
            cartView.DataSource = carts;
            cartView.DataBind();
            if (carts != null)
            {
                clearCartButton.Visible = true;
                orderButton.Visible = true;
            }
        }

        protected void makeupView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = makeupView.Rows[e.NewSelectedIndex];
            ViewState["makeupId"] = Convert.ToInt32(row.Cells[1].Text);
            makeupSelected.Text = row.Cells[2].Text;
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(quantityBox.Text);
            errorMessage.Text = CartController.validateOrder(quantity, makeupSelected.Text);
            int userId = Convert.ToInt32(Session["user"]);
            if (errorMessage.Text == "")
            {
                CartController.addMakeupToCart(userId, Convert.ToInt32(ViewState["makeupId"].ToString()), quantity);
                Response.Redirect("~/Views/OrderMakeup.aspx");
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void clearCartButton_Click(object sender, EventArgs e)
        {
            CartController.clearAllUserCart(Convert.ToInt32(Session["user"]));
            Response.Redirect("~/Views/OrderMakeup.aspx");
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            TransactionController.makeOrder(Convert.ToInt32(Session["user"]));
            Response.Redirect("~/Views/OrderMakeup.aspx");
        }
    }
}