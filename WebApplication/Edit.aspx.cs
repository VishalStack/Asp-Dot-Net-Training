using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication
{
    public partial class Edit : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string qry;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    cn.Open();
                    qry = "select * from StudentInfo where id=" + Request.QueryString["id"];
                    cmd = new SqlCommand(qry, cn);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtName.Text = dr[1].ToString();
                        txtAge.Text = dr[2].ToString();
                    }
                    cn.Close();
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            cn.Open();
            qry = "update StudentInfo set name='" + txtName.Text + "', age=" + txtAge.Text + " where id=" + Request.QueryString["id"];
            cmd = new SqlCommand(qry, cn);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Record Updated !') </script>");
            cn.Close();
        }
 
    }
}