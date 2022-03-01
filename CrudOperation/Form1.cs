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

namespace CrudOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        private Button Btnfind;
        private DataGridView dataGridView1;
        private Button Btnsave;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Label lblempid;
        private Label lblempname;
        private Label lblempsalary;
        private Label lblempcity;
        private TextBox txtempid;
        private TextBox txtempname;
        private TextBox txtempsalary;
        private TextBox txtempcity;
        SqlDataReader dr;
        

        private void GetAllEmployeeRecord()
        {
            //throw new NotImplementedException();
            cmd = new SqlCommand("EmployeeCrudOperation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeId", 0);
            cmd.Parameters.AddWithValue("@EmployeeName", "");
            cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
            cmd.Parameters.AddWithValue("@EmployeeCity", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

 

        private void InitializeComponent()
        {
            this.Btnfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnsave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempsalary = new System.Windows.Forms.Label();
            this.lblempcity = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtempsalary = new System.Windows.Forms.TextBox();
            this.txtempcity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnfind
            // 
            this.Btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfind.Location = new System.Drawing.Point(718, 28);
            this.Btnfind.Name = "Btnfind";
            this.Btnfind.Size = new System.Drawing.Size(267, 47);
            this.Btnfind.TabIndex = 0;
            this.Btnfind.Text = "Find Employee";
            this.Btnfind.UseVisualStyleBackColor = true;
            this.Btnfind.Click += new System.EventHandler(this.Btnfind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 197);
            this.dataGridView1.TabIndex = 1;
            // 
            // Btnsave
            // 
            this.Btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsave.Location = new System.Drawing.Point(42, 337);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(267, 47);
            this.Btnsave.TabIndex = 2;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click_1);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(384, 337);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(267, 47);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(718, 337);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(267, 47);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(21, 40);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(294, 37);
            this.lblempid.TabIndex = 5;
            this.lblempid.Text = "Enter Employee Id";
            this.lblempid.Click += new System.EventHandler(this.lblempid_Click);
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(22, 116);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(356, 37);
            this.lblempname.TabIndex = 6;
            this.lblempname.Text = "Enter Employee Name";
            this.lblempname.Click += new System.EventHandler(this.lblempname_Click);
            // 
            // lblempsalary
            // 
            this.lblempsalary.AutoSize = true;
            this.lblempsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempsalary.Location = new System.Drawing.Point(21, 184);
            this.lblempsalary.Name = "lblempsalary";
            this.lblempsalary.Size = new System.Drawing.Size(362, 37);
            this.lblempsalary.TabIndex = 7;
            this.lblempsalary.Text = "Enter Employee Salary";
            this.lblempsalary.Click += new System.EventHandler(this.lblempsalary_Click);
            // 
            // lblempcity
            // 
            this.lblempcity.AutoSize = true;
            this.lblempcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempcity.Location = new System.Drawing.Point(21, 265);
            this.lblempcity.Name = "lblempcity";
            this.lblempcity.Size = new System.Drawing.Size(324, 37);
            this.lblempcity.TabIndex = 8;
            this.lblempcity.Text = "Enter Employee City";
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(384, 30);
            this.txtempid.Multiline = true;
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(318, 47);
            this.txtempid.TabIndex = 9;
            // 
            // txtempname
            // 
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(384, 106);
            this.txtempname.Multiline = true;
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(601, 47);
            this.txtempname.TabIndex = 10;
            // 
            // txtempsalary
            // 
            this.txtempsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsalary.Location = new System.Drawing.Point(384, 181);
            this.txtempsalary.Multiline = true;
            this.txtempsalary.Name = "txtempsalary";
            this.txtempsalary.Size = new System.Drawing.Size(601, 47);
            this.txtempsalary.TabIndex = 11;
            // 
            // txtempcity
            // 
            this.txtempcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempcity.Location = new System.Drawing.Point(384, 262);
            this.txtempcity.Multiline = true;
            this.txtempcity.Name = "txtempcity";
            this.txtempcity.Size = new System.Drawing.Size(601, 47);
            this.txtempcity.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1039, 625);
            this.Controls.Add(this.txtempcity);
            this.Controls.Add(this.txtempsalary);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lblempcity);
            this.Controls.Add(this.lblempsalary);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btnfind);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblempsalary_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblempname_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblempid_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kirta\source\repos\CrudOperation\Crud.mdf;Integrated Security=True");
            cn.Open();
            //bind data in data grid view  
            GetAllEmployeeRecord();

            //disable delete and update button on load  
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }


        private void Btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtempcity.Text != string.Empty && txtempname.Text != string.Empty && txtempsalary.Text != string.Empty)
            {
                cmd = new SqlCommand("EmployeeCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", 0);
                cmd.Parameters.AddWithValue("@EmployeeName", txtempname.Text);
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@EmployeeSalary", txtempsalary.Text);
                cmd.Parameters.AddWithValue("@EmployeeCity", txtempcity.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllEmployeeRecord();
                txtempcity.Text = "";
                txtempid.Text = "";
                txtempname.Text = "";
                txtempsalary.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtempcity.Text != string.Empty && txtempid.Text != string.Empty && txtempname.Text != string.Empty && txtempsalary.Text != string.Empty)
            {
                cmd = new SqlCommand("EmployeeCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", txtempid.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", txtempname.Text);
                cmd.Parameters.AddWithValue("@EmployeeSalary", txtempsalary.Text);
                cmd.Parameters.AddWithValue("@EmployeeCity", txtempcity.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllEmployeeRecord();
                BtnDelete.Enabled = false;
                BtnUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnfind_Click(object sender, EventArgs e)
        {
            if (txtempid.Text != string.Empty)
            {

                cmd = new SqlCommand("EmployeeCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employeeid", txtempid.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", "");
                cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
                cmd.Parameters.AddWithValue("@EmployeeCity", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtempname.Text = dr["EmployeeName"].ToString();
                    txtempsalary.Text = dr["EmployeeSalary"].ToString();
                    txtempcity.Text = dr["EmployeeCity"].ToString();
                    BtnUpdate.Enabled = true;
                    BtnDelete.Enabled = true;
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtempid.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee ? ", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {

                    cmd = new SqlCommand("EmployeeCrudOperation", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Employeeid", txtempid.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", "");
                    cmd.Parameters.AddWithValue("@EmployeeSalary", 0);
                    cmd.Parameters.AddWithValue("@EmployeeCity", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllEmployeeRecord();
                    txtempcity.Text = "";
                    txtempid.Text = "";
                    txtempname.Text = "";
                    txtempsalary.Text = "";
                    BtnDelete.Enabled = false;
                    BtnUpdate.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
