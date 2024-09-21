using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class ViewTransactionDetails : System.Web.UI.Page
    {
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                id = Convert.ToInt32(Request.QueryString["id"]);
                transactionDetailView.DataSource = TransactionController.getSelectedTransactionDetail(id);
                transactionDetailView.DataBind();
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ViewTransactionHistory.aspx");
        }
    }
}