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
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                handledTransactionView.DataSource = TransactionController.getAllHandledTransactions();
                handledTransactionView.DataBind();

                unhandledTransactionView.DataSource = TransactionController.getAllUnhandledTransactions();
                unhandledTransactionView.DataBind();
            }
        }

        protected void unhandledTransactionView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = unhandledTransactionView.Rows[e.NewSelectedIndex];
            ViewState["transactionId"] = row.Cells[1].Text;
            selected.Text = row.Cells[1].Text;
        }

        protected void handleButton_Click(object sender, EventArgs e)
        {
            TransactionController.handleTransaction(Convert.ToInt32(ViewState["transactionId"].ToString()));
            Response.Redirect("~/Views/OrderQueue.aspx");
        }
    }
}