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
    public partial class UCstudents : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        database db = new database();
        public UCstudents()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
        }
        public void SearchData()
        {
            gridView.Rows.Clear();

            connection.Open();
            string query = "SELECT * FROM tbl_student_profile WHERE student_id LIKE @searchText";
            cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@searchText", "%" + txtSearch.Text + "%");
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                gridView.Rows.Add(dr["student_id"].ToString(), dr["lrn"].ToString(), dr["rfid"].ToString(), dr["first_name"].ToString(), dr["middle_name"].ToString(), dr["last_name"].ToString(), dr["year_level"].ToString(), dr["section"].ToString(), dr["guardian_name"].ToString(), dr["contact_no"].ToString());
            }

            dr.Close();
            connection.Close();
        }


        public void LoadData()
        {
            gridView.Rows.Clear();

            connection.Open();
            cmd = new MySqlCommand("select * from tbl_student_profile", connection);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                gridView.Rows.Add(dr["student_id"].ToString(), dr["lrn"].ToString(), dr["rfid"].ToString(), dr["first_name"].ToString(), dr["middle_name"].ToString(), dr["last_name"].ToString(), dr["year_level"].ToString(), dr["section"].ToString(), dr["guardian_name"].ToString(), dr["contact_no"].ToString());

            }
            dr.Close();
            connection.Close();
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            forms.frmAddEdit form = new forms.frmAddEdit();
            form.txtID.Enabled = true;
            form.btnUpdate.Enabled = false;
            form.ShowDialog();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not in the header row
            if (e.RowIndex >= 0)
            {
                forms.frmAddEdit form = new forms.frmAddEdit();
                if (gridView.Columns[e.ColumnIndex].Name == "edit")
                {
                    int rowIndex = e.RowIndex;
                    form.txtID.Text = gridView[0, rowIndex].Value.ToString();
                    form.txtLRN.Text = gridView[1, rowIndex].Value.ToString();
                    form.txtRFID.Text = gridView[2, rowIndex].Value.ToString();
                    form.txtfname.Text = gridView[3, rowIndex].Value.ToString();
                    form.txtmname.Text = gridView[4, rowIndex].Value.ToString();
                    form.txtlname.Text = gridView[5, rowIndex].Value.ToString();
                    
                    form.txtguardian.Text = gridView[8, rowIndex].Value.ToString();
                    form.txtcontact.Text = gridView[9, rowIndex].Value.ToString();

                    form.btnSave.Enabled = false;
                    form.btnUpdate.Enabled = true;
                    form.txtID.Enabled = false;
                    form.ShowDialog();
                }

                if (gridView.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this Student Profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    string pcode = "";
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        int rowIndex = e.RowIndex;
                        pcode = gridView[0, rowIndex].Value.ToString();
                        cmd = new MySqlCommand("delete from tbl_student_profile WHERE student_id like '" + pcode + "'", connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Student Profile Deleted!");
                        LoadData();
                    }
                }
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchData();
        }

        private void UCstudents_Load_1(object sender, EventArgs e)
        {
            LoadData();
            Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
