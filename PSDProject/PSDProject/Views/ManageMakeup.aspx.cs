using PSDProject.Controller;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class ManageMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (!UserController.adminAuthenticate(Session["user"]))
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                }

                List<Makeup> makeups = MakeupController.getAllMakeups();
                
                makeupView.DataSource = makeups;
                makeupView.DataBind();

                List<MakeupBrand> makeupBrands = MakeupBrandController.getAllMakeupBrands();

                sort(makeupBrands);

                List<MakeupType> makeupTypes = MakeupTypeController.getAllMakeupTypes();
                makeupTypeView.DataSource = makeupTypes;
                makeupTypeView.DataBind();
            }
        }

        public void sort(List<MakeupBrand> makeupBrands)
        {
            DataTable dt = listToDataTable(makeupBrands);
            DataView dv = new DataView(dt);
            dv.Sort = "MakeupBrandRating DESC";
            makeupBrandView.DataSource = dv;
            makeupBrandView.DataBind();
        }

        public DataTable listToDataTable(List<MakeupBrand> makeupBrands)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MakeupBrandID", typeof(int));
            dt.Columns.Add("MakeupBrandName", typeof(string));
            dt.Columns.Add("MakeupBrandRating", typeof(int));

            foreach(MakeupBrand mb in makeupBrands)
            {
                DataRow dr = dt.NewRow();
                dr["MakeupBrandID"] = mb.MakeupBrandID;
                dr["MakeupBrandName"] = mb.MakeupBrandName;
                dr["MakeupBrandRating"] = mb.MakeupBrandRating;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        protected void makeupView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupView.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            MakeupController.removeMakeup(id);
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void makeupView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupView.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text;
            Response.Redirect("~/Views/UpdateMakeup.aspx?id=" + id);
        }

        protected void makeupBrandView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupBrandView.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            MakeupController.removeByBrandId(id);
            MakeupBrandController.removeMakeupBrand(id);
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void makeupBrandView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupBrandView.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text;
            Response.Redirect("~/Views/UpdateMakeupBrand.aspx?id=" + id);
        }

        protected void makeupTypeView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupTypeView.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[1].Text);
            MakeupController.removeByTypeId(id);
            MakeupTypeController.removeMakeupType(id);
            Response.Redirect("~/Views/ManageMakeup.aspx");
        }

        protected void makeupTypeView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupTypeView.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text;
            Response.Redirect("~/Views/UpdateMakeupType.aspx?id=" + id);
        }

        protected void addMakeupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/AddMakeup.aspx");
        }

        protected void addMakeupBrandButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/AddMakeupBrand.aspx");
        }

        protected void addMakeupTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/AddMakeupType.aspx");
        }
    }
}