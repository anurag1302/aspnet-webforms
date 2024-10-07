using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSample
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGrid();
            }

        }

        protected void gridViewEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gridViewEmployee.Rows)
            {
                var checkBox = (CheckBox)row.FindControl("chkRow");
                if (checkBox != null && checkBox.Checked)
                {
                    string id = gridViewEmployee.DataKeys[row.RowIndex].Value.ToString();
                    string name = row.Cells[2].Text;
                    string city = row.Cells[3].Text;

                    Response.Write($"Selected Rows Data: ID = {id}, Name = {name}, City = {city} <br/>");
                }
            }
        }

        protected void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkHeader = (CheckBox)sender;
            foreach(GridViewRow row in gridViewEmployee.Rows)
            {
                CheckBox checkRow = (CheckBox)row.FindControl("chkRow");
                if(checkRow  != null) {
                    checkRow.Checked = checkHeader.Checked;
                }
            }
        }

        public void BindGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("City");

            dt.Rows.Add("101", "John1", "NY1");
            dt.Rows.Add("102", "John2", "NY2");
            dt.Rows.Add("103", "John3", "NY3");
            dt.Rows.Add("104", "John4", "NY4");
            dt.Rows.Add("105", "John5", "NY5");
            dt.Rows.Add("106", "John6", "NY6");
            dt.Rows.Add("107", "John7", "NY7");

            gridViewEmployee.DataSource = dt;
            gridViewEmployee.DataBind();
        }
    }
}