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
    public partial class UCstudentreports : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        database db = new database();
        public UCstudentreports()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
        }


        public void LoadData()
        {
            string formattedDate = DateTime.Today.ToString("yyyy-MM-dd");
            dgvrecentstudents.Rows.Clear();

            using (MySqlConnection connection = new MySqlConnection(db.GetConnection()))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT t1.student_id AS ID,
                                      CONCAT(t1.first_name, ' ', LEFT(t1.middle_name, 1), '.', ' ', t1.last_name) AS fullname,
                                      t1.year_level, t1.section,
                                      DATE_FORMAT(t2.date_logged, '%d/%m/%Y') AS date_logged,
                                      TIME_FORMAT(t2.time_in, '%H:%i:%s') AS time_in,
                                      TIME_FORMAT(t2.time_out, '%H:%i:%s') AS time_out
                                FROM tbl_attendance_records AS t2
                                LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id
                                WHERE DATE(t2.date_logged) = @date";
                    cmd.Parameters.AddWithValue("@date", formattedDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string timeIn = FormatTime(reader["time_in"].ToString());
                            string timeOut = FormatTime(reader["time_out"].ToString());

                            dgvrecentstudents.Rows.Add(reader["ID"].ToString(),
                                                       reader["fullname"].ToString(),
                                                       reader["section"].ToString(),
                                                       reader["year_level"].ToString(),
                                                       timeIn, timeOut,
                                                       reader["date_logged"].ToString());
                        }
                    }
                }
            }
        }

        private void UCstudentreports_Load(object sender, EventArgs e)
        {
            LoadData();
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
        public void LoadDataWithDateRange()
        {
            string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
            string toDate = dtpTo.Value.ToString("yyyy-MM-dd");
         
            dgvrecentstudents.Rows.Clear();

            using (MySqlConnection newConnection = new MySqlConnection(db.GetConnection()))
            {
                newConnection.Open();

                string query = "SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                               "FROM tbl_attendance_records as t2 " +
                               "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                               "WHERE DATE(date_logged) BETWEEN @FromDate AND @ToDate";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query += " AND t1.student_id LIKE @StudentID";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, newConnection))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", txtSearch.Text);
                    }

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
            }
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

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
        }

        private void dgvrecentstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
        }
    }
}
