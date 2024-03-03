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
namespace Attendance_Monitoring.UserControls
{
    public partial class UCStudentReports : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ClassDB db = new ClassDB();
        public UCStudentReports()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
        }
        public void LoadData()
        {
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            dgvrecentstudents.Rows.Clear();
            using (connection)
            {
                connection.Open();
                using (cmd = new MySqlCommand("SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                   "FROM tbl_attendance_records as t2 " +
                   "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id where DATE(t2.date_logged) = '" + formattedDate + "'", connection))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string timeIn = FormatTime(dr["time_in"].ToString());
                        string timeOut = FormatTime(dr["time_out"].ToString());

                        dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut, dr["date_logged"].ToString());
                    }
                }

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

            private void UCStudentReports_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataWithDateRange();
        }

        public void LoadDataWithDateRange()
        {
            if (txtSearch.Text == "")
            {
                string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
                string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

                dgvrecentstudents.Rows.Clear();
                using (connection)
                {
                    connection.Open();
                    using (cmd = new MySqlCommand("SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                        "FROM tbl_attendance_records as t2 " +
                        "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                        "WHERE DATE(date_logged) BETWEEN '" + fromDate + "' AND '" + toDate + "'", connection))
                    {
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            string timeIn = FormatTime(dr["time_in"].ToString());
                            string timeOut = FormatTime(dr["time_out"].ToString());

                            dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut, dr["date_logged"].ToString());
                        }
                    }
                }
            }
            else
            {
                string fromDate = dtpFrom.Value.ToString("yyyy-MM-dd");
                string toDate = dtpTo.Value.ToString("yyyy-MM-dd");

                dgvrecentstudents.Rows.Clear();
                using (connection)
                {
                    connection.Open();
                    using (cmd = new MySqlCommand("SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, DATE_FORMAT(t2.date_logged, '%d/%m/%Y') as date_logged, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                        "FROM tbl_attendance_records as t2 " +
                        "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id " +
                        "WHERE DATE(date_logged) BETWEEN '" + fromDate + "' AND '" + toDate + "' AND t1.student_id = '" + txtSearch.Text + "'", connection))
                    {
                        dr = cmd.ExecuteReader();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

//DataSet ds = new DataSet();
//  DataTable dt = new DataTable();
//  dt.Columns.Add("student_id", typeof(string));
//  dt.Columns.Add("time_in", typeof(string));
//  dt.Columns.Add("time_out", typeof(string));
//  dt.Columns.Add("date_logged", typeof(string));

//  foreach (DataGridViewRow dgv in dgvrecentstudents.Rows)
//  {
//     dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);

//  }
//  ds.Tables.Add(dt);
//  ds.WriteXmlSchema("users.xml");

//  Forms.frmReports form2 = new forms.frmReports();
// forms.CrystalReport1 cr = new forms.CrystalReport1();
//   cr.SetDataSource(ds);
// form2.crystalReportViewer1.ReportSource = cr;
// form2.crystalReportViewer1.Refresh();
// form2.Show();
