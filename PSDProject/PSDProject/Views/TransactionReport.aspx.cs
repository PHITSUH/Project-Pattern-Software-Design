using System;
using PSDProject.Report;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Datasets;
using PSDProject.Model;
using PSDProject.Handler;
using PSDProject.Controller;

namespace PSDProject.Views
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!UserController.adminAuthenticate(Session["user"]))
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }

            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;
            Dataset data = getData(TransactionHandler.getAllTransactionHeaders());
            report.SetDataSource(data);
        }

        private Dataset getData(List<TransactionHeader> transactions)
        {
            Dataset data = new Dataset();
            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;

            foreach(TransactionHeader t in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;
                headerTable.Rows.Add(hrow);

                foreach(TransactionDetail td in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = td.TransactionID;
                    drow["MakeupID"] = td.MakeupID;
                    drow["Quantity"] = td.Quantity;
                    detailTable.Rows.Add(drow);
                }
            }

            return data;
        }
    }
}