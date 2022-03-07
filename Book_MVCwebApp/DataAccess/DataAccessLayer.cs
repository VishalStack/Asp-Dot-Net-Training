using Book_MVCwebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Book_MVCwebApp.DataAccess
{
    public class DataAccessLayer
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = "Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True";
            con = new SqlConnection(constr);

        }
        public bool AddBookData(Book obj)
        {

            connection();
            SqlCommand com = new SqlCommand("insert into bookdetail(BookId,BookName,AuthorName,BookDescription) values(@BookId,@BookName,@AuthorName,@BookDescription)", con);
            com.Parameters.AddWithValue("@BookId", obj.BookId);
            com.Parameters.AddWithValue("@BookName", obj.BookName);
            com.Parameters.AddWithValue("@AuthorName", obj.AuthorName);
            com.Parameters.AddWithValue("@BookDescription", obj.BookDescription);

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

        public List<Book> GetBookData()
        {
            connection();
            List<Book> GetBookData = new List<Book>();


            SqlCommand com = new SqlCommand("select * from bookdetail", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            //Bind EmpModel generic list using dataRow     
            foreach (DataRow dr in dt.Rows)
            {

                GetBookData.Add(

                    new Book
                    {

                        BookId = Convert.ToInt32(dr["BookId"]),
                        BookName = Convert.ToString(dr["BookName"]),
                        AuthorName = Convert.ToString(dr["AuthorName"]),
                        BookDescription = Convert.ToString(dr["BookDescription"])

                    }
                    );
            }

            return GetBookData;
        }


        public bool UpdateData(Book obj)
        {

            connection();
            SqlCommand com = new SqlCommand("update bookdetail set BookId=@BookId , BookName=@BookName ,AuthorName=@AuthorName, BookDescription=@BookDescription where BookId= @BookId", con);

            com.Parameters.AddWithValue("@BookId", obj.BookId);
            com.Parameters.AddWithValue("@BookName", obj.BookName);
            com.Parameters.AddWithValue("@AuthorName", obj.AuthorName);
            com.Parameters.AddWithValue("@BookDescription", obj.BookDescription);
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
        //To delete Employee details    
        public bool DeleteData(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("delete from bookdetail where BookId=@BookId", con);
            
            com.Parameters.AddWithValue("@BookId", Id);

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