using PSDProject.Controller;
using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        public int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");    
                }
                id = (Int32)Session["user"];
                if(UserController.roleIsAdmin(id))
                {
                    A1.InnerText = "Manage Makeup";
                    A1.HRef = "ManageMakeup.aspx";
                    A2.InnerText = "Order Queue";
                    A2.HRef = "OrderQueue.aspx";
                    A3.InnerText = "Profile";
                    A3.HRef = "Profile.aspx";
                    A4.InnerText = "Transaction Report";
                    A4.HRef = "TransactionReport.aspx";
                    A5.InnerText = "History";
                    A5.HRef = "ViewTransactionHistory.aspx";
                }
                else
                {
                    A1.InnerText = "Order Makeup";
                    A1.HRef = "OrderMakeup.aspx";
                    A2.InnerText = "History";
                    A2.HRef = "ViewTransactionHistory.aspx";
                    A3.InnerText = "Profile";
                    A3.HRef = "Profile.aspx";
                }

                logoutButton.Text = "logout";
                
            }
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            HttpCookie cookie = new HttpCookie("user");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}