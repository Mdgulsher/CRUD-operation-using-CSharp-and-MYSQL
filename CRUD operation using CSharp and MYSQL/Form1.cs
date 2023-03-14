using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_operation_using_CSharp_and_MYSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "SERVER= LOCALHOST;DATABASE=employeerecord;UID=root;Password=";
            string query = "INSERT INTO `employee`(`FIRSTNAME`, `LASTNAME`, `GENDER`, `POSITION`, `MI`) VALUES  ('" + this.FirstName.Text + "','" + this.LastName.Text + "','"+this.Gender.Text+"','"+this.Position.Text+"','"+this.MI.Text+"')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("succesfull saved");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connection = "SERVER= LOCALHOST;DATABASE=employeerecord;UID=root;Password=";
            string query = "UPDATE employee SET FIRSTNAME='" + this.FirstName.Text + "',MI='" + this.MI.Text + "',LASTNAME='" + this.LastName.Text + "',GENDER='" + this.Gender.Text + "',POSITION='" + this.Position.Text + "' WHERE EMPID='" + this.EMPID.Text + "' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record hsa been sucessfully updtaed");
            conn.Close();

        }

        private void btnloaddata_Click(object sender, EventArgs e)
        {
            string connection = "SERVER= LOCALHOST;DATABASE=employeerecord;UID=root;Password=";
            string query = "SELECT * FROM employee";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand=cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string connection = "SERVER= LOCALHOST;DATABASE=employeerecord;UID=root;Password=";
            string query = "DELETE FROM employee WHERE EMPID='"+this.EMPID.Text+"'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr= cmd.ExecuteReader();
            MessageBox.Show("data deleted");
            conn.Close();


        }
    }
}
