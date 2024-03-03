using Attendance_Monitoring;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMonitoring.uc
{
    public partial class UCadmin : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
       
        database db = new database();
        public UCadmin()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            LoadTeachersData();
        }
        public void LoadTeachersData()
        {
            try
            {
                dgvadmins.Rows.Clear();
                using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
                {
                    newConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT name,username,user_type FROM monitoringsmsdb.tbl_users", newConnection))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dgvadmins.Rows.Add(dr["name"].ToString(), dr["username"].ToString(), dr["user_type"].ToString(), "Delete");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in load teachers: " + e.Message);
            }
        }
        public void Addteacher()
        {
            try
            {
                string countQuery = "SELECT COUNT(*)FROM tbl_users where username = @user AND name = @name AND user_type = @type";
                string insertQuery = "INSERT INTO monitoringsmsdb.tbl_users () values(id,@name,@user,@pass,@type)";

                using (MySqlConnection newlyConnection = new MySqlConnection(db.GetConnection()))
                {
                    newlyConnection.Open();

                    // Check if the combination already exists
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, newlyConnection))
                    {
                        countCmd.Parameters.AddWithValue("@name", txtname.Text);
                        countCmd.Parameters.AddWithValue("@user", txtusername.Text);
                        
                        countCmd.Parameters.AddWithValue("@type", cmbtype.Text);

                        int count = Convert.ToInt32(countCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // If count is zero, proceed with insertion
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, newlyConnection))
                            {

                                insertCmd.Parameters.AddWithValue("@name", txtname.Text);
                                insertCmd.Parameters.AddWithValue("@user", txtusername.Text);
                                insertCmd.Parameters.AddWithValue("@pass", txtpass.Text);
                                insertCmd.Parameters.AddWithValue("@type", cmbtype.Text);
                             

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Account Added!");
                                LoadTeachersData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The account is already existed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding: " + ex.Message);
            }
        }
        public void SearchData()
        {
            dgvadmins.Rows.Clear(); // Clear existing rows

            using (MySqlConnection newlyConnection = new MySqlConnection(db.GetConnection()))
            {
                try
                {
                    newlyConnection.Open();

                    string query = "SELECT name, username, user_type FROM tbl_users WHERE name LIKE @searchText";
                    using (MySqlCommand cmd = new MySqlCommand(query, newlyConnection))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + txtsearch.Text + "%");

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dgvadmins.Rows.Add(dr["name"].ToString(), dr["username"].ToString(), dr["user_type"].ToString(), "Delete");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle exception
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Addteacher();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = !tableLayoutPanel3.Visible;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
           
        }

        private void dgvadmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvadmins.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Advisory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string name = "";
                string user = "";
                string usertype = "";
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection newlyrConnection = new MySqlConnection(db.GetConnection()))
                    {
                        newlyrConnection.Open();
                        int rowIndex = e.RowIndex;
                        name = dgvadmins[0, rowIndex].Value.ToString();
                        user = dgvadmins[1, rowIndex].Value.ToString();
                        usertype = dgvadmins[2, rowIndex].Value.ToString();
                        cmd = new MySqlCommand("DELETE FROM tbl_users WHERE  name = '" + name + "'  AND username = '" + user + "' AND user_type = '" + usertype + "'; ", newlyrConnection);
                        cmd.ExecuteNonQuery();
                        newlyrConnection.Close();
                        MessageBox.Show("Account Deleted!");
                        LoadTeachersData();
                    }

                }
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchData();
            LoadTeachersData();
        }
    }
}
