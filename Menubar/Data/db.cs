using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Menubar.Data
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        //Get Category
        public DataSet get_category()
        {
            SqlCommand com = new SqlCommand("Select * from tbl_category", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //Get Subcategory()
        public DataSet get_Subcategory(int catid)
        {
            SqlCommand com = new SqlCommand("Select * from tbl_Subcategory where Cat_id=@catid", con);
            com.Parameters.AddWithValue("@catid", catid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //Get Subtosubcategory
        public DataSet get_SubtoSubcategory(int subcatid)
        {
            SqlCommand com = new SqlCommand("Select * from tbl_subtosucategory where Subcat_id=@subcatid", con);
            com.Parameters.AddWithValue("@subcatid", subcatid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       

    }
}