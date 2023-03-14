
namespace CRUD_operation_using_CSharp_and_MYSQL
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
            this.EMPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnloaddata = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EMPID
            // 
            this.EMPID.Location = new System.Drawing.Point(48, 77);
            this.EMPID.Name = "EMPID";
            this.EMPID.Size = new System.Drawing.Size(204, 26);
            this.EMPID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FirstName";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(48, 169);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(204, 26);
            this.FirstName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(48, 336);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(204, 26);
            this.Gender.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(46, 446);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(204, 26);
            this.Position.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(768, 411);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(267, 602);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(152, 34);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(31, 667);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(152, 34);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnloaddata
            // 
            this.btnloaddata.Location = new System.Drawing.Point(267, 667);
            this.btnloaddata.Name = "btnloaddata";
            this.btnloaddata.Size = new System.Drawing.Size(152, 34);
            this.btnloaddata.TabIndex = 16;
            this.btnloaddata.Text = "Load Data";
            this.btnloaddata.UseVisualStyleBackColor = true;
            this.btnloaddata.Click += new System.EventHandler(this.btnloaddata_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(433, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee informatio system";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "LastName";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(48, 261);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(204, 26);
            this.LastName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "MI";
            // 
            // MI
            // 
            this.MI.Location = new System.Drawing.Point(48, 515);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(204, 26);
            this.MI.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 851);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnloaddata);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMPID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EMPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnloaddata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MI;
    }
}

