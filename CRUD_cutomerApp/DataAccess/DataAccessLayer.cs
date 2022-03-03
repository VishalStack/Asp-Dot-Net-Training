using CRUD_cutomerApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_cutomerApp.DataAccess
{
    public class DataAccessLayer
    {
        public string InsertData(Customer cust)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                string mycon = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";
                con = new SqlConnection(mycon);
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerId", 0);
                cmd.Parameters.AddWithValue("@name", cust.name);
                cmd.Parameters.AddWithValue("@add", cust.add);
                cmd.Parameters.AddWithValue("@mno", cust.mno);
                cmd.Parameters.AddWithValue("@bdate", cust.bdate);
                cmd.Parameters.AddWithValue("@mailid", cust.mailid);
                cmd.Parameters.AddWithValue("@Query", 1);

                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }
        public bool UpdateData(Customer cust)

        {
            SqlConnection con = null;
            string result = "";
            
                string mycon = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";

                con = new SqlConnection(mycon);
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerId", cust.customerId);
                cmd.Parameters.AddWithValue("@name", cust.name);
                cmd.Parameters.AddWithValue("@add", cust.add);
                cmd.Parameters.AddWithValue("@mno", cust.mno);
                cmd.Parameters.AddWithValue("@bdate", cust.bdate);
                cmd.Parameters.AddWithValue("@mailid", cust.mailid);
                cmd.Parameters.AddWithValue("@Query", 2);
                con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool DeleteData(int customerId)

        {
            SqlConnection con = null;
            string result = "";
           
                string mycon = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";
                con = new SqlConnection(mycon);
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@customerId",customerId);
                cmd.Parameters.AddWithValue("@name", null);
                cmd.Parameters.AddWithValue("@add", null);
                cmd.Parameters.AddWithValue("@mno", null);
                cmd.Parameters.AddWithValue("@bdate", null);
                cmd.Parameters.AddWithValue("@mailid", null);
                cmd.Parameters.AddWithValue("@Query", 3);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            
        }

        public List<Customer> Selectalldata()

        {
            SqlConnection con = null;
            string mycon = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";
            con = new SqlConnection(mycon);
            List<Customer> custlist = new List<Customer>(); ;
            SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@customerId", null);
            cmd.Parameters.AddWithValue("@name", null);
            cmd.Parameters.AddWithValue("@add", null);
            cmd.Parameters.AddWithValue("@mno", null);
            cmd.Parameters.AddWithValue("@bdate", null);
            cmd.Parameters.AddWithValue("@mailid", null);
            cmd.Parameters.AddWithValue("@Query", 4);


            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                custlist.Add(

                    new Customer
                    {
                        customerId = Convert.ToInt32(dr["customerId"]),
                        name = Convert.ToString(dr["name"]),
                        add = Convert.ToString(dr["add"]),
                        bdate = Convert.ToDateTime(dr["bdate"]),
                        mno = Convert.ToString(dr["mno"]),
                        mailid =Convert.ToString(dr["mailid"]),

                    }
                    );
            }

            return custlist;

        }

        public Customer SelectDatabyID(string customerId)

        {
            SqlConnection con = null;
            DataSet ds = null;
            Customer cobj = null;

            try
            {
                string mycon = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";
                con = new SqlConnection(mycon);

                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Customer", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@name", null);
                cmd.Parameters.AddWithValue("@add", null);
                cmd.Parameters.AddWithValue("@mno", null);
                cmd.Parameters.AddWithValue("@bdate", null);
                cmd.Parameters.AddWithValue("@mailid", null);
                cmd.Parameters.AddWithValue("@Query", 5);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cobj = new Customer();
                    cobj.customerId = Convert.ToInt32(ds.Tables[0].Rows[i]["customerId"].ToString());
                    cobj.name = ds.Tables[0].Rows[i]["name"].ToString();
                    cobj.add = ds.Tables[0].Rows[i]["address"].ToString();
                    cobj.mno = ds.Tables[0].Rows[i]["mno"].ToString();
                    cobj.mailid = ds.Tables[0].Rows[i]["emailid"].ToString();
                    cobj.bdate = Convert.ToDateTime(ds.Tables[0].Rows[i]["bdate"].ToString());
                }
                return cobj;
            }
            catch
            {
                return cobj;
            }
            finally
            {
                con.Close();
            }
        }


    }
}