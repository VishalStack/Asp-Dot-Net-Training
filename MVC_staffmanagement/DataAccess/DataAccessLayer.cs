using MVC_staffmanagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_staffmanagement.DataAccess
{
    public class DataAccessLayer
    {

        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = "Data Source=DESKTOP-FAG71FE;Initial Catalog=stackdb;Integrated Security=True";
            con = new SqlConnection(constr);

        }
        public bool InsertData(Staff objstaff)

        {
                connection();

                SqlCommand cmd = new SqlCommand("insert into staffdetail(id,fullName,dob,mob,mailid,gender) values(@id,@fullName,@dob,@mob,@mailid,@gender)", con);

                cmd.Parameters.AddWithValue("@id",objstaff.id);

                cmd.Parameters.AddWithValue("@fullName",objstaff.fullName);

                cmd.Parameters.AddWithValue("@dob",objstaff.dob );

                cmd.Parameters.AddWithValue("@mob",objstaff.mob );

                cmd.Parameters.AddWithValue("@mailid",objstaff.mailid);

                cmd.Parameters.AddWithValue("@gender", objstaff.gender);
               
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

        public List<Staff> ShowStaffList()
        {
            connection();
            List<Staff> ShowStaffList = new List<Staff>();


            SqlCommand com = new SqlCommand("select * from staffdetail", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {

                ShowStaffList.Add(

                    new Staff
                    {

                        id = Convert.ToInt32(dr["id"]),
                        fullName = Convert.ToString(dr["fullName"]),
                        dob = Convert.ToDateTime(dr["dob"]),
                        mob = Convert.ToString(dr["mob"]),
                        mailid = Convert.ToString(dr["mailid"]),
                        gender = Convert.ToString(dr["gender"])

                    }
                    );
            }

            return ShowStaffList;
        }

        public bool UpdateData(Staff objstaff)
        {

            connection();
            SqlCommand com = new SqlCommand("update staffdetail set id=@id , fullName=@fullName ,dob=@dob, mob=@mob ,mailid=@mailid,gender=@gender  where id= @id", con);

            com.Parameters.AddWithValue("@id", objstaff.id);
            com.Parameters.AddWithValue("@fullName", objstaff.fullName);
            com.Parameters.AddWithValue("@dob", objstaff.dob);
            com.Parameters.AddWithValue("@mob", objstaff.mob);
            com.Parameters.AddWithValue("@mailid", objstaff.mailid);
            com.Parameters.AddWithValue("@gender", objstaff.gender);
            con.Open();
            int i = com.ExecuteNonQuery();
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

        public bool DeleteData(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("delete from staffdetail where id=@id", con);

            com.Parameters.AddWithValue("@id", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
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


    }
}