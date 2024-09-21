using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class ViewTransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                if (UserController.adminAuthenticate(Session["user"]))
                {
                    transactionHistoryView.DataSource =TransactionController.getAllTransactionHeaders();
                    transactionHistoryView.DataBind();
                }
                else
                {
                    transactionHistoryView.DataSource = TransactionController.getCustomerTransactionHeaders((Int32)Session["user"]);
                    transactionHistoryView.DataBind();
                }
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void transactionHistoryView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = transactionHistoryView.Rows[e.NewSelectedIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            Response.Redirect("~/Views/ViewTransactionDetails.aspx?id=" + id);
        }
    }
}