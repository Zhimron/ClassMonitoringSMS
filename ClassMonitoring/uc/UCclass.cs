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
    public partial class UCclass : UserControl
    {

        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        database db = new database();
        public UCclass()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            LoadDataIntoComboBox("year", cmbyear);
            LoadteacherIntoComboBox(cmbTeacher);
            LoadDataIntoComboBox("section", cmbclass);
            
        }
        private void LoadDataIntoComboBox(string type, ComboBox cmb)
        {
            // MySQL query to retrieve data
            string query = $"SELECT {type} FROM tbl_sections GROUP BY {type}";

            try
            {
                // Establishing connection to MySQL Server
                using (connection = new MySqlConnection(db.GetConnection()))
                {
                    // Opening connection
                    
                    connection.Open();

                    // Creating command object with the query and connection
                    using (cmd = new MySqlCommand(query, connection))
                    {
                        // Creating data adapter
                        da = new MySqlDataAdapter(cmd);

                        // Creating dataset to hold the data
                        var dataSet = new System.Data.DataSet();

                        // Filling the dataset with data from data adapter
                        da.Fill(dataSet);

                        // Binding the dataset to the ComboBox
                        cmb.DataSource = dataSet.Tables[0];
                        cmb.DisplayMember = type;
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handling any exceptions
                MessageBox.Show("Error__data: " + ex.Message);
            }
        
        }
        private void LoadteacherIntoComboBox( ComboBox cmb)
        {
            // MySQL query to retrieve data
            string query = $"SELECT name,id FROM tbl_users WHERE user_type != 'ADMIN'";

            try
            {
                // Establishing connection to MySQL Server
                using (connection = new MySqlConnection(db.GetConnection()))
                {
                    // Opening connection

                    connection.Open();

                    // Creating command object with the query and connection
                    using (cmd = new MySqlCommand(query, connection))
                    {
                        // Creating data adapter
                        da = new MySqlDataAdapter(cmd);

                        // Creating dataset to hold the data
                        var dataSet = new System.Data.DataSet();

                        // Filling the dataset with data from data adapter
                        da.Fill(dataSet);

                        // Binding the dataset to the ComboBox
                        cmb.DataSource = dataSet.Tables[0];
                        cmb.DisplayMember ="name";
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handling any exceptions
                MessageBox.Show("Error_combo_teacher: " + ex.Message);
            }
         
        }
     

        public void LoadTeachersData()
        {
            try
            {
                dgvteacherstudents.Rows.Clear();
                using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
                {
                    newConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT t1.name, t2.teacher_student_section, t2.teacher_student_year FROM monitoringsmsdb.tbl_users AS t1 JOIN monitoringsmsdb.tbl_teacher_student AS t2 ON t2.teachers_id = t1.id WHERE t1.user_type = 'Teacher'", newConnection))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dgvteacherstudents.Rows.Add(dr["name"].ToString(), dr["teacher_student_section"].ToString(), dr["teacher_student_year"].ToString(),"Delete");
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
                string countQuery = "SELECT COUNT(*)FROM tbl_teacher_student as t1 " +
                    "left join tbl_users as t2 on t1.teachers_id = t2.id " +
                    "WHERE teacher_student_section = @teacher_student_section " +
                    "AND teacher_student_year = @teacher_student_year";
                string insertQuery = "INSERT INTO tbl_teacher_student (teachers_id, teacher_student_section, teacher_student_year) " +
                    "SELECT id, @teacher_student_section, @teacher_student_year " +
                    "FROM tbl_users " +
                    "WHERE name = @teachers_name ";

                using (MySqlConnection newlyConnection = new MySqlConnection(db.GetConnection()))
                {
                    newlyConnection.Open();

                    // Check if the combination already exists
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, newlyConnection))
                    {
                        countCmd.Parameters.AddWithValue("@id", cmbTeacher.Text);
                        countCmd.Parameters.AddWithValue("@teacher_student_section", cmbclass.Text);
                        countCmd.Parameters.AddWithValue("@teacher_student_year", cmbyear.Text);

                        int count = Convert.ToInt32(countCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // If count is zero, proceed with insertion
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, newlyConnection))
                            {
                                insertCmd.Parameters.AddWithValue("@teachers_name", cmbTeacher.Text);
                                insertCmd.Parameters.AddWithValue("@teacher_student_section", cmbclass.Text);
                                insertCmd.Parameters.AddWithValue("@teacher_student_year", cmbyear.Text);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Teacher Added!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The teacher is already assigned to the specified section and year.");
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
            dgvteacherstudents.Rows.Clear();

            using (MySqlConnection newlyConnection = new MySqlConnection(db.GetConnection()))
            {
                newlyConnection.Open();

                string query = "SELECT t2.name,t1.teacher_student_section,t1.teacher_student_year FROM tbl_teacher_student as t1 join tbl_users as t2 on t1.teachers_id = t2.id WHERE t2.name like @searchText";
                cmd = new MySqlCommand(query, newlyConnection);
                cmd.Parameters.AddWithValue("@searchText", "%" + txtsearch.Text + "%");
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvteacherstudents.Rows.Add(dr["name"].ToString(), dr["teacher_student_section"].ToString(), dr["teacher_student_year"].ToString(),"DELETE");
                }

                dr.Close();
                newlyConnection.Close();
            }
        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCclass_Load(object sender, EventArgs e)
        {
            LoadTeachersData();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
                       

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Addteacher();
            LoadTeachersData();
        }

        private void cmbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dgvteacherstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = !tableLayoutPanel3.Visible;
           
        }

        private void dgvteacherstudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvteacherstudents.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Advisory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string teacher_name = "";
                string section = "";
                string year = "";
                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection newlyrConnection = new MySqlConnection(db.GetConnection()))
                    {
                        newlyrConnection.Open();
                        int rowIndex = e.RowIndex;
                        teacher_name = dgvteacherstudents[0, rowIndex].Value.ToString();
                        section = dgvteacherstudents[1, rowIndex].Value.ToString();
                        year = dgvteacherstudents[2, rowIndex].Value.ToString();
                        cmd = new MySqlCommand("DELETE FROM tbl_teacher_student WHERE teachers_id IN(SELECT id FROM tbl_users WHERE name = '" + teacher_name + "')  AND teacher_student_section = '"+section+"' AND teacher_student_year = '"+year+"'; ", newlyrConnection);
                        cmd.ExecuteNonQuery();
                        newlyrConnection.Close();
                        MessageBox.Show("Advisory Deleted!");
                        LoadTeachersData();
                    }

                }
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
