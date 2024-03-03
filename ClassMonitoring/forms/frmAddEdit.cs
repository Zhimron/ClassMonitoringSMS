using Attendance_Monitoring;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMonitoring.forms
{
    public partial class frmAddEdit : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        // MySqlDataReader dr;
        database db = new database();
        public frmAddEdit()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            LoadDataIntoComboBox("year", cmbyear);
            LoadDataIntoComboBox("section", cmbsection);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadDataIntoComboBox(string type, ComboBox cmb)
        {
            string query = $"SELECT {type} FROM tbl_sections GROUP BY {type}";

            try
            {
                connection.Open();

                cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                cmb.DataSource = table;
                cmb.DisplayMember = type;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public void Clear()
        {
            txtID.Clear();
            txtLRN.Clear();
            txtRFID.Clear();
            txtfname.Clear();
            txtmname.Clear();
            txtlname.Clear();
            txtguardian.Clear();
            txtcontact.Clear();
            studentpic.Image = null;
        }
        public void UpdateStudent()

        {

            if (pictureBox2.Image != null)
            {

                if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" )
                {
                    MessageBox.Show("Please Complete The Details");
                    return;
                }
                connection.Open();

                string query = "UPDATE tbl_student_profile SET " +
                   "lrn = @lrn, " +
                   "rfid = @rfid, " +
                   "first_name = @first_name, " +
                   "middle_name = @middle_name, " +
                   "last_name = @last_name, " +
                   "year_level = @year_level, " +
                   "section = @section, " +
                   "guardian_name = @guardian_name, " +
                   "contact_no = @contact_no," +
                   "image = @Image " +
                   "WHERE student_id = @student_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@lrn", txtLRN.Text);
                    cmd.Parameters.AddWithValue("@rfid", txtRFID.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@middle_name", txtmname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@year_level", cmbyear.Text);
                    cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                    cmd.Parameters.AddWithValue("@guardian_name", txtguardian.Text);
                    cmd.Parameters.AddWithValue("@contact_no", txtcontact.Text);
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    cmd.Parameters.Add("@Image", MySqlDbType.Blob).Value = ms.ToArray();
                    cmd.ExecuteNonQuery();




                }

                connection.Close();
                MessageBox.Show("Student Profile Updated!");
                Clear();
                Hide();

            }
            else
            {

                if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" )
                {
                    MessageBox.Show("Please Complete The Details");
                    return;
                }
                connection.Open();

                string query = "UPDATE tbl_student_profile SET " +
                   "lrn = @lrn, " +
                   "rfid = @rfid, " +
                   "first_name = @first_name, " +
                   "middle_name = @middle_name, " +
                   "last_name = @last_name, " +
                   "year_level = @year_level, " +
                   "section = @section, " +
                   "guardian_name = @guardian_name, " +
                   "contact_no = @contact_no WHERE student_id = @student_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@lrn", txtLRN.Text);
                    cmd.Parameters.AddWithValue("@rfid", txtRFID.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@middle_name", txtmname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@year_level", cmbyear.Text);
                    cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                    cmd.Parameters.AddWithValue("@guardian_name", txtguardian.Text);
                    cmd.Parameters.AddWithValue("@contact_no", txtcontact.Text);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Student Profile Updated!");
                Clear();
                Hide();

            }



        }
        public void AddStudent()
        {
            if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" | studentpic.Image == null)
            {
                MessageBox.Show("Please Complete The Details");
                return;
            }
            connection.Open();

            string query = "INSERT INTO tbl_student_profile (student_id, lrn, rfid, first_name, middle_name, last_name, year_level, section, guardian_name, contact_no, image) " +
                           "VALUES (@student_id, @lrn, @rfid, @first_name, @middle_name, @last_name, @year_level, @section, @guardian_name, @contact_no, @Image)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))

            {
                cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                cmd.Parameters.AddWithValue("@lrn", txtLRN.Text);
                cmd.Parameters.AddWithValue("@rfid", txtRFID.Text);
                cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                cmd.Parameters.AddWithValue("@middle_name", txtmname.Text);
                cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                cmd.Parameters.AddWithValue("@year_level", cmbyear.Text);
                cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                cmd.Parameters.AddWithValue("@guardian_name", txtguardian.Text);
                cmd.Parameters.AddWithValue("@contact_no", txtcontact.Text);
                MemoryStream ms = new MemoryStream();
                studentpic.Image.Save(ms, studentpic.Image.RawFormat);
                cmd.Parameters.AddWithValue("@Image", ms.ToArray());
                cmd.ExecuteNonQuery();
            }

            connection.Close();
            MessageBox.Show("Student Added!");
            Clear();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            userControl.BringToFront();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudent();

        }

   
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pictureBox2.Image = image;
                studentpic.Image = image;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            StudentData();
        }

        public void StudentData()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM tbl_student_profile WHERE student_id = '" + txtID.Text + "'";
                cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    byte[] img = (byte[])table.Rows[0][9];
                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        studentpic.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student data: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            AddStudent();
        }
    }
}
