using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using webApi_CRUD.Models;

namespace webApi_CRUD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private List<Student> LoadFromDb()
        {
            List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("select * from Student",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt =new DataTable();
            da.Fill(dt);

            for(int i=0;i<dt.Rows.Count;i++)
            {
                Student student = new Student();
                student.name = dt.Rows[i]["name"].ToString();
                student.age = dt.Rows[i]["age"].ToString();
                students.Add(student);
            }


            return students;
        }

        [HttpGet]
        [Route("GetStudents")]

        public List<Student> GetStudents()
        {
            return LoadFromDb();
        }

        [HttpGet]
        [Route("GetStudentsById")]

        public List<Student> GetStudentsById(int sid)
        {
            return LoadFromDb().Where(e => e.id == sid).ToList();
        }

        [HttpPost]
        [Route("InsertStudents")]
        public string InsertStudents(Student obj)
        {
            //List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("insert into Student values ('"+obj.name+ "','" + obj.age + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return "Item added successfully..";
        }

        [HttpDelete]
        [Route("DeleteStudents")]
        public string DeleteStudents(int id)
        {
            //List<Student> students = new List<Student>();

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("delete from Student where id='" +id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return "Item Delete successfully..";
        }

    }
}
