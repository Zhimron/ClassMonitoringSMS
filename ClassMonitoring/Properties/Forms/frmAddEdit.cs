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
using System.IO;

namespace Attendance_Monitoring.Forms
{
    public partial class frmAddEdit : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        // MySqlDataReader dr;
        ClassDB db = new ClassDB();
        public frmAddEdit()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            LoadDataIntoComboBox("year",cmbyear);
            LoadDataIntoComboBox("section", cmbsection);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadDataIntoComboBox(string type,ComboBox cmb)
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
                    }
                }
            }
            catch (Exception ex)
            {
                // Handling any exceptions
                MessageBox.Show("Error: " + ex.Message);
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
            txtylvl.Clear();
            txtsection.Clear();
            txtguardian.Clear();
            txtcontact.Clear();
            studentpic.Image = null;
        }
        public void UpdateStudent()

        {

            if (pictureBox2.Image != null)
            {

                if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" | txtsection.Text == "" | txtylvl.Text == "")
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
                    cmd.Parameters.AddWithValue("@year_level", txtylvl.Text);
                    cmd.Parameters.AddWithValue("@section", txtsection.Text);
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

                if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" | txtsection.Text == "" | txtylvl.Text == "")
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
                    cmd.Parameters.AddWithValue("@year_level", txtylvl.Text);
                    cmd.Parameters.AddWithValue("@section", txtsection.Text);
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
            if (txtcontact.Text == "" | txtfname.Text == "" | txtguardian.Text == "" | txtID.Text == "" | txtlname.Text == "" | txtLRN.Text == "" | txtmname.Text == "" | txtRFID.Text == "" | txtsection.Text == "" | txtylvl.Text == "" | studentpic.Image == null)
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
                cmd.Parameters.AddWithValue("@year_level", txtylvl.Text);
                cmd.Parameters.AddWithValue("@section", txtsection.Text);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddStudent();
    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            // gridView.Rows.Clear();

            connection.Open();

            string query = "SELECT * FROM tbl_student_profile WHERE student_id = '" + txtID.Text + "'";

            cmd = new MySqlCommand(query, connection);

            da = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            // Check if there is no data in the DataTable
            if (table.Rows.Count == 0)
            {
            
            }
            else
            {
                byte[] img = (byte[])table.Rows[0][9];
                MemoryStream ms = new MemoryStream(img);
                studentpic.Image = Image.FromStream(ms);
            }


            da.Dispose();
            connection.Close();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
