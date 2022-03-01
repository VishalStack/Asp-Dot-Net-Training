using System;

namespace CRUDoperation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblempid = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempsalary = new System.Windows.Forms.Label();
            this.lblempcity = new System.Windows.Forms.Label();
            this.Btnfind = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtempsalary = new System.Windows.Forms.TextBox();
            this.txtempcity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.Location = new System.Drawing.Point(32, 47);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(182, 32);
            this.lblempid.TabIndex = 0;
            this.lblempid.Text = "Employee Id";
            this.lblempid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(32, 109);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(236, 32);
            this.lblempname.TabIndex = 1;
            this.lblempname.Text = "Employee Name";
            // 
            // lblempsalary
            // 
            this.lblempsalary.AutoSize = true;
            this.lblempsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempsalary.Location = new System.Drawing.Point(32, 174);
            this.lblempsalary.Name = "lblempsalary";
            this.lblempsalary.Size = new System.Drawing.Size(244, 32);
            this.lblempsalary.TabIndex = 2;
            this.lblempsalary.Text = "Employee Salary";
            this.lblempsalary.Click += new System.EventHandler(this.txtempsalary_Click);
            // 
            // lblempcity
            // 
            this.lblempcity.AutoSize = true;
            this.lblempcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempcity.Location = new System.Drawing.Point(32, 242);
            this.lblempcity.Name = "lblempcity";
            this.lblempcity.Size = new System.Drawing.Size(210, 32);
            this.lblempcity.TabIndex = 3;
            this.lblempcity.Text = "Employee City";
            this.lblempcity.Click += new System.EventHandler(this.txtempcity_Click);
            // 
            // Btnfind
            // 
            this.Btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfind.Location = new System.Drawing.Point(691, 32);
            this.Btnfind.Name = "Btnfind";
            this.Btnfind.Size = new System.Drawing.Size(311, 60);
            this.Btnfind.TabIndex = 4;
            this.Btnfind.Text = "Find Employee";
            this.Btnfind.UseVisualStyleBackColor = true;
            this.Btnfind.Click += new System.EventHandler(this.Btnfind_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsave.Location = new System.Drawing.Point(38, 319);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(290, 60);
            this.Btnsave.TabIndex = 5;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = true;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Btnupdate
            // 
            this.Btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnupdate.Location = new System.Drawing.Point(388, 319);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(278, 60);
            this.Btnupdate.TabIndex = 6;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.UseVisualStyleBackColor = true;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndelete.Location = new System.Drawing.Point(724, 319);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(278, 60);
            this.Btndelete.TabIndex = 7;
            this.Btndelete.Text = "Delete";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(964, 233);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtempid
            // 
            this.txtempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.Location = new System.Drawing.Point(331, 32);
            this.txtempid.Multiline = true;
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(335, 60);
            this.txtempid.TabIndex = 9;
            // 
            // txtempname
            // 
            this.txtempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.Location = new System.Drawing.Point(331, 98);
            this.txtempname.Multiline = true;
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(671, 58);
            this.txtempname.TabIndex = 10;
            // 
            // txtempsalary
            // 
            this.txtempsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsalary.Location = new System.Drawing.Point(331, 164);
            this.txtempsalary.Multiline = true;
            this.txtempsalary.Name = "txtempsalary";
            this.txtempsalary.Size = new System.Drawing.Size(671, 57);
            this.txtempsalary.TabIndex = 11;
            // 
            // txtempcity
            // 
            this.txtempcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempcity.Location = new System.Drawing.Point(331, 227);
            this.txtempcity.Multiline = true;
            this.txtempcity.Name = "txtempcity";
            this.txtempcity.Size = new System.Drawing.Size(671, 57);
            this.txtempcity.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 640);
            this.Controls.Add(this.txtempcity);
            this.Controls.Add(this.txtempsalary);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnupdate);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.Btnfind);
            this.Controls.Add(this.lblempcity);
            this.Controls.Add(this.lblempsalary);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        private void txtempcity_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempsalary;
        private System.Windows.Forms.Label lblempcity;
        private System.Windows.Forms.Button Btnfind;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtempsalary;
        private System.Windows.Forms.TextBox txtempcity;
    }
}

