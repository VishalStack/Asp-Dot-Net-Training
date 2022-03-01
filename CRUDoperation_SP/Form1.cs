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

namespace CRUDoperation_SP
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {

                cmd = new SqlCommand("Employee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", textBox1.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", "");
                cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
                cmd.Parameters.AddWithValue("@EmployeeCity", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["EmployeeName"].ToString();
                    textBox3.Text = dr["EmployeeSalary"].ToString();
                    textBox4.Text = dr["EmployeeCity"].ToString();
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No record found with this id", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please enter employee id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(local);Initial Catalog=Employee;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            GetAllEmployeeRecord();

            //disable delete and update button on load  
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void GetAllEmployeeRecord()
        {
            cmd = new SqlCommand("Employee", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Employeeid", 0);
            cmd.Parameters.AddWithValue("@EmployeeName", "");
            cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
            cmd.Parameters.AddWithValue("@EmployeeCity", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                cmd = new SqlCommand("Employee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", 0);
                cmd.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", textBox3.Text);
                cmd.Parameters.AddWithValue("@EmployeeCity", textBox4.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllEmployeeRecord();
                textBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty && textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                cmd = new SqlCommand("Employee", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", textBox1.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", textBox3.Text);
                cmd.Parameters.AddWithValue("@EmployeeCity", textBox4.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllEmployeeRecord();
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee ? ", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {

                    cmd = new SqlCommand("Employee", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Employeeid", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", "");
                    cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
                    cmd.Parameters.AddWithValue("@EmployeeCity", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllEmployeeRecord();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
