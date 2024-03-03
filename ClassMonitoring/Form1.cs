using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Monitoring;
using MySql.Data.MySqlClient;

namespace ClassMonitoring
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        database db = new database();
        public frmLogin()
        {
            InitializeComponent();
            
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Login()
        {

            string _fullname = "";
            string _type = "";
            string _username = "";

            string _id = "";
            connection.Open();
            cmd = new MySqlCommand("select * from tbl_users where username = @user_name AND password = @password", connection);
            cmd.Parameters.AddWithValue("@user_name", txtuser.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            dr = cmd.ExecuteReader();
            dr.Read();


            if (dr.HasRows)
            {

                _fullname = dr["name"].ToString();
                _type = dr["user_type"].ToString();
                _username = dr["username"].ToString();
                _id = dr["id"].ToString();
                MessageBox.Show("Welcome " + _fullname); ;
                forms.frmdashboard dash = new forms.frmdashboard(_type, _username,_id) ;
                dash.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }
            connection.Close();


        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
