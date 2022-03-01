using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication
{
    public partial class Default : System.Web.UI.Page
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterData();
        }

        private void RepeaterData()
        {
            cn.Open();
            qry = "Select * from StudentInfo";
            cmd = new SqlCommand(qry, cn);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            cn.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            cn.Open();
            qry = "insert into StudentInfo values ('" + txtName.Text + "'," + txtAge.Text + ")";
            cmd = new SqlCommand(qry, cn);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Record Inserted !') </script>");
            cn.Close();
            RepeaterData();
        }

        protected void DeleteStudent(object sender, EventArgs e)
        {
            int studentID = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblStudentID") as Label).Text);
            cn.Open();
            qry = "DELETE FROM StudentInfo WHERE ID=" + studentID;
            cmd = new SqlCommand(qry, cn);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Record Deleted !') </script>");
            cn.Close();
            RepeaterData();
        }
    }
}
