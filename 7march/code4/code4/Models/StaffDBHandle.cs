using StaffMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace code4.Models
{
    public class StaffDBHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["staffconn"].ToString();
            con = new SqlConnection(constring);
        }

        // **************** ADD NEW STAFF *********************
        public bool AddStudent(StaffModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FullName", smodel.FullName);
            cmd.Parameters.AddWithValue("DOB",smodel.DOB);
            cmd.Parameters.AddWithValue("@MobNo", smodel.MobNo);
            cmd.Parameters.AddWithValue("@EmailId", smodel.EmailId);
            cmd.Parameters.AddWithValue("@Gender", smodel.Gender);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        internal bool AddStaff(StaffModel smodel)
        {
            throw new NotImplementedException();
        }

        // ********** VIEW STAFF DETAILS ********************
        public List<StaffModel> GetStaff()
        {
            connection();
            List<StaffModel> stafflist = new List<StaffModel>();
            SqlCommand cmd = new SqlCommand("GetStaffDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                stafflist.Add(
                    new StaffModel
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        FullName = Convert.ToString(dr["FullName"]),
                        DOB = Convert.ToDateTime(dr["DOB"]),
                        MobNo = Convert.ToInt32(dr["MobNo"]),
                        EmailId = Convert.ToString(dr["EmailId"]),
                        Gender = Convert.ToString(dr["Gender"])
                    });
            }
            return stafflist;
        }

        // ***************** UPDATE STAFF DETAILS *********************
        public bool UpdateDetails(StaffModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateStaffDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", smodel.Id);
            cmd.Parameters.AddWithValue("@FullName", smodel.FullName);
            cmd.Parameters.AddWithValue("DOB", smodel.DOB);
            cmd.Parameters.AddWithValue("@MobNo", smodel.MobNo);
            cmd.Parameters.AddWithValue("@EmailId", smodel.EmailId);
            cmd.Parameters.AddWithValue("@Gender", smodel.Gender);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE STAFF DETAILS *******************
        public bool DeleteStaff(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}
    

