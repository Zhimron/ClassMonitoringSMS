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
using MySql.Data;
namespace Attendance_Monitoring
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ClassDB db = new ClassDB();
        public frmLogin()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
        }

        void Login()    
        {

            string _fullname = "";


            connection.Open();
            cmd = new MySqlCommand("select * from tbl_users where username = @user_name AND password = @password", connection);
            cmd.Parameters.AddWithValue("@user_name", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            dr = cmd.ExecuteReader();
            dr.Read();


            if (dr.HasRows)
            {

                _fullname = dr["name"].ToString();
                MessageBox.Show("Welcome " + _fullname); ;
                Forms.frmDashboard dash = new Forms.frmDashboard();
                dash.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
            connection.Close();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
