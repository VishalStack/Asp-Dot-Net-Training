using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDoperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void GetEmployeeDetails()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Emp_table", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Load(sdr);
            
           // da.Fill(dt);
            EmployeeGridView.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Emp_Table values (@ID,@Name,@Salary,@City)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@City", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Successfully Added");
            GetEmployeeDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                GetEmployeeDetails();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Emp_Table set EmployeeName=@Name, EmployeeSalary=@Salary ,EmployeeCity=@City where EmployeeId=@ID", con);

            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@City", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
            GetEmployeeDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee ? ", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Emp_table where EmployeeId=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", "");
                    cmd.Parameters.AddWithValue("@Salary", 0);
                    cmd.Parameters.AddWithValue("@City", "");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetEmployeeDetails();
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FAG71FE;Initial Catalog=Employee;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Emp_table WHERE EmployeeId=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", "");
                cmd.Parameters.AddWithValue("@Salary", 0);
                cmd.Parameters.AddWithValue("@City", "");

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textBox2.Text = dr["EmployeeName"].ToString();
                    textBox3.Text = dr["EmployeeSalary"].ToString();
                    textBox4.Text = dr["EmployeeCity"].ToString();

                }
                else
                {
                    MessageBox.Show("No record found with this id", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter employee id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetEmployeeDetails();
        }
    }
}
