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
    public partial class UCclassreport : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        database db = new database();
        public UCclassreport(string user_id)
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            lblid.Text = user_id;
            LoadDataIntoComboBox("teacher_student_section", cmbsection,lblid.Text);
            LoadDataIntoComboBox("teacher_student_year", cmbyear,lblid.Text);
            LoadData();


        }
        private void LoadDataIntoComboBox(string type, ComboBox cmb,string ID)
        {
            // MySQL query to retrieve data
            string query = $"SELECT {type} FROM tbl_teacher_student WHERE teachers_id = {ID} GROUP BY {type}";

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
        private string FormatTime(string time)
        {
            DateTime parsedTime;
            if (DateTime.TryParse(time, out parsedTime))
            {
                return parsedTime.ToString("hh:mm tt"); // Format time in AM/PM format
            }
            return time; // Return the original value if it cannot be parsed as a DateTime
        }
        public void LoadData()
        {
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            dgvrecentstudents.Rows.Clear();

            using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
            {
                newConnection.Open();

                string query = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                               "FROM tbl_attendance_records as t2 " +
                               "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                               "WHERE t1.year_level = @yearLevel AND t1.section = @section AND DATE(t2.date_logged) = @formattedDate";

                using (MySqlCommand cmd = new MySqlCommand(query, newConnection))
                {
                    cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                    cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                    cmd.Parameters.AddWithValue("@formattedDate", formattedDate);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string timeIn = FormatTime(dr["time_in"].ToString());
                            string timeOut = FormatTime(dr["time_out"].ToString());

                            dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut, dr["date_logged"].ToString());
                        }
                    }
                }

                string listquery = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section " +
                                               "FROM tbl_student_profile AS t1 " +
                                               "WHERE t1.year_level = @yearLevel AND t1.section = @section";

                using (MySqlCommand cmd = new MySqlCommand(listquery, newConnection))
                {
                    cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                    cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                   

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            

                            dgvliststudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString());
                        }
                    }
                }
            }
        }

        public void LoadDataWithDateRange()
        {
            dgvrecentstudents.Rows.Clear();
            dgvliststudents.Rows.Clear();
            if (txtSearch.Text == "")
            {
                string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
                string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

               

                using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
                {
                    newConnection.Open();

                    // Query for attendance records
                    string attendanceQuery = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                                             "FROM tbl_attendance_records as t2 " +
                                             "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                                             "WHERE t1.year_level = @yearLevel AND t1.section = @section AND DATE(date_logged) BETWEEN @fromDate AND @toDate";

                    using (MySqlCommand cmd = new MySqlCommand(attendanceQuery, newConnection))
                    {
                        cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                        cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                        cmd.Parameters.AddWithValue("@fromDate", fromDate);
                        cmd.Parameters.AddWithValue("@toDate", toDate);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string timeIn = FormatTime(dr["time_in"].ToString());
                                string timeOut = FormatTime(dr["time_out"].ToString());

                                dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut, dr["date_logged"].ToString());
                            }
                        }
                    }

                    // Query for student list
                    string studentListQuery = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section " +
                                               "FROM tbl_student_profile AS t1 " +
                                               "WHERE t1.year_level = @yearLevel AND t1.section = @section";

                    using (MySqlCommand cmd = new MySqlCommand(studentListQuery, newConnection))
                    {
                        cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                        cmd.Parameters.AddWithValue("@section", cmbsection.Text);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dgvliststudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString());
                            }
                        }
                    }
                }
            }
            else 
            {
                string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
                string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

                using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
                {
                    newConnection.Open();

                    // Query for attendance records
                    string attendanceQuery = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                                             "FROM tbl_attendance_records as t2 " +
                                             "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                                             "WHERE t1.year_level = @yearLevel AND t1.section = @section AND DATE(date_logged) BETWEEN @fromDate AND @toDate AND t1.student_id = @studentId";

                    using (MySqlCommand cmd = new MySqlCommand(attendanceQuery, newConnection))
                    {
                        cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                        cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                        cmd.Parameters.AddWithValue("@fromDate", fromDate);
                        cmd.Parameters.AddWithValue("@toDate", toDate);
                        cmd.Parameters.AddWithValue("@studentId", txtSearch.Text);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string timeIn = FormatTime(dr["time_in"].ToString());
                                string timeOut = FormatTime(dr["time_out"].ToString());

                                dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut, dr["date_logged"].ToString());
                            }
                        }
                    }

                    // Query for student list
                    string studentListQuery = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section " +
                                               "FROM tbl_student_profile AS t1 " +
                                               "WHERE t1.year_level = @yearLevel AND t1.section = @section AND t1.student_id = @studentId";

                    using (MySqlCommand cmd = new MySqlCommand(studentListQuery, newConnection))
                    {
                        cmd.Parameters.AddWithValue("@yearLevel", cmbyear.Text);
                        cmd.Parameters.AddWithValue("@section", cmbsection.Text);
                        cmd.Parameters.AddWithValue("@studentId", txtSearch.Text);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                dgvliststudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmyclass_Click(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
            if (dgvrecentstudents.Visible == false)
            {
                dgvrecentstudents.Visible = true;
                dgvliststudents.Visible = false;
            }
             
           
        }

        private void btnstudentin_Click(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
            if (dgvliststudents.Visible == false)
            {
                dgvliststudents.Visible = true;
                dgvrecentstudents.Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1];

                for (int i = 1; i <= dgvrecentstudents.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i] = dgvrecentstudents.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvrecentstudents.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvrecentstudents.Columns.Count; j++)
                    {
                        if (dgvrecentstudents.Rows[i].Cells[j].Value != null)
                        {
                            if (j == 6 && dgvrecentstudents.Rows[i].Cells[j].Value is DateTime dateTimeValue)
                            {
                                excelWorksheet.Cells[i + 2, j + 1] = dateTimeValue.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                excelWorksheet.Cells[i + 2, j + 1] = dgvrecentstudents.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                }

                excelWorkbook.SaveAs(filePath);
                excelWorkbook.Close();
                excelApp.Quit();
            }
        }

        private void btnexportclass_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1];

                for (int i = 1; i <= dgvliststudents.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i] = dgvliststudents.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvliststudents.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvliststudents.Columns.Count; j++)
                    {
                        if (dgvliststudents.Rows[i].Cells[j].Value != null)
                        {
                            if (j == 6 && dgvliststudents.Rows[i].Cells[j].Value is DateTime dateTimeValue)
                            {
                                excelWorksheet.Cells[i + 2, j + 1] = dateTimeValue.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                excelWorksheet.Cells[i + 2, j + 1] = dgvliststudents.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                }

                excelWorkbook.SaveAs(filePath);
                excelWorkbook.Close();
                excelApp.Quit();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
        }
    }
}
