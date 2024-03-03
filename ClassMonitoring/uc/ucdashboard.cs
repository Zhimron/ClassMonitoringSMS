﻿using Attendance_Monitoring;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMonitoring.uc
{
    public partial class ucdashboard : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        database db = new database();
            public ucdashboard()
            {
                InitializeComponent();
            
                connection = new MySqlConnection();
                connection.ConnectionString = db.GetConnection();
                presentStudents();
                StudentsRefresh();

            string[] availablePorts = SerialPort.GetPortNames();
            List<string> portInfoList = new List<string>();

            foreach (string portName in availablePorts)
            {
                string deviceName = GetDeviceNameForPort(portName);
                string portInfo = $"{portName} ({deviceName})";
                portInfoList.Add(portInfo);
            }

            cmbPorts.Items.AddRange(portInfoList.ToArray());
        }
        
        private void sendingMsg()
        {
            string timeinout;
            if (radioIn.Checked)
            {
               timeinout = "Entered at school";
            }
            else
            {
                timeinout = "Exit at the school";
            }

            //String globalsms =  label7.Text + " " + timeio + " " + lblTime.Text;
            String globalsms = "Student " + lblname.Text + " is on the school " + timeinout + " @" + DateTime.Now;

            // get the selected port name from the combobox (including device name)
            string selectedportinfo = cmbPorts.SelectedItem.ToString();
            string selectedportname = selectedportinfo.Split(' ')[0]; // extract the port name

            // configure and open the selected serial port
            SerialPort serialPort1 = new SerialPort();
            serialPort1.PortName = selectedportname;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.RequestToSend;
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;
            serialPort1.NewLine = "\r\n";

            try
            {
                serialPort1.Open();

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("AT\r\n");
                    serialPort1.Write("AT+CMGF=1\r\n");
                    serialPort1.Write("AT+CMGS=" + "\"" + lblcontact.Text + "\"" + "\r\n");
                    //serialPort1.Write(globalsms + (char)26);
                    int chunkSize = 160;
                    for (int i = 0; i < globalsms.Length; i += chunkSize)
                    {
                        string chunk = globalsms.Substring(i, Math.Min(chunkSize, globalsms.Length - i));
                        serialPort1.Write(chunk + (char)26);
                    }

                    serialPort1.Close();

                }
                else
                {
                    MessageBox.Show("Serial port couldn't be opened.", "PORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "PORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void CountStudents(string grade, Label totalstudent)
            {
                using (MySqlConnection newlyConnection = new MySqlConnection(db.GetConnection()))
                {
                    newlyConnection.Open();
                    if (string.IsNullOrEmpty(grade))
                    {
                        using (cmd = new MySqlCommand("SELECT COUNT(*) FROM tbl_attendance_records AS t1 " +
                                               "LEFT JOIN tbl_student_profile AS t2 ON t1.student_id = t2.student_id " +
                                               "WHERE t1.date_logged = DATE(NOW()) ", newlyConnection))
                        {

                            int totalStudents = Convert.ToInt32(cmd.ExecuteScalar());

                            totalstudent.Text = totalStudents.ToString();
                        }
                    }
                    else
                    {
                        using (cmd = new MySqlCommand("select count(*) from tbl_student_profile  ", newlyConnection))
                        {
                         
                            int totalStudents = Convert.ToInt32(cmd.ExecuteScalar());

                            lbltotalstudents.Text = totalStudents.ToString();
                        }
                    }

                }
            }
        public void StudentsRefresh()
        {
          
            CountStudents("1", lbltotalpresent);
            CountStudents(null, lbltotalpresent);
        }
        public void presentStudents()
        {
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            dgvrecentstudents.Rows.Clear();
            using (connection)
            {
                connection.Open();
                using (cmd = new MySqlCommand("SELECT t1.student_id as ID, CONCAT(t1.first_name,' ',LEFT(t1.middle_name, 1),'.' ,' ', t1.last_name) as fullname, t1.year_level, t1.section, TIME_FORMAT(t2.time_in, '%H:%i:%s') as time_in, TIME_FORMAT(t2.time_out, '%H:%i:%s') as time_out " +
                    "FROM tbl_attendance_records as t2 " +
                    "LEFT JOIN tbl_student_profile AS t1 ON t1.student_id = t2.student_id  where DATE(date_logged) = '" + formattedDate + "' " +
                    "ORDER BY date_logged DESC LIMIT 5", connection))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string timeIn = FormatTime(dr["time_in"].ToString());
                        string timeOut = FormatTime(dr["time_out"].ToString());

                        dgvrecentstudents.Rows.Add(dr["ID"].ToString(), dr["fullname"].ToString(), dr["section"].ToString(), dr["year_level"].ToString(), timeIn, timeOut);
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


        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCdashboard_Load(object sender, EventArgs e)
        {

            presentStudents();
            StudentsRefresh();

        }
        private string GetDeviceNameForPort(string portName)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%{portName}%'");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["Caption"] != null)
                {
                    return queryObj["Caption"].ToString();
                }
            }
            return "Unknown Device";
        }

        public void StudentData()
        {
            connection.Close();
            connection.Open();

            string query = "SELECT * FROM tbl_student_profile WHERE student_id = '" + txtSearch.Text + "'";

            cmd = new MySqlCommand(query, connection);

            da = new MySqlDataAdapter(cmd);

            DataTable table = new   DataTable();

            da.Fill(table);

            // Check if there is no data in the DataTable
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Invalid ID");

            }
            else
            {
                lblstudentid.Text = table.Rows[0][1].ToString();
                lblyear.Text = table.Rows[0][7].ToString();
                lblsection.Text = table.Rows[0][8].ToString();
                lblcontact.Text = table.Rows[0][12].ToString();
                lblname.Text = table.Rows[0][4].ToString() + " " + table.Rows[0][5].ToString() + " " + table.Rows[0][6].ToString();
                //byte[] img = (byte[])table.Rows[0][9];
                //MemoryStream ms = new MemoryStream(img);
                //studentpic.Image = Image.FromStream(ms);

                //  EnterStudent();

            }
            txtSearch.Clear();
            txtSearch.Focus();

            da.Dispose();
            connection.Close();

        }

        public void EnterStudent()
        {
            if (radioIn.Checked == true)
            {
                connection.Close();
                connection.Open();

                string query = "INSERT INTO tbl_attendance_records (student_id, time_in, date_logged) " +
                    "VALUES (@student_id, CONVERT_TZ(CURRENT_TIMESTAMP, '+00:00', '+00:00'), CONVERT_TZ(CURRENT_TIMESTAMP, '+00:00', '+00:00'))";


                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", lblstudentid.Text);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
                StudentsRefresh();
                presentStudents();
                sendingMsg();


            }
            else
            {
                connection.Close();
                connection.Open();

                string query = "UPDATE tbl_attendance_records " +
                "SET time_out = CONVERT_TZ(CURRENT_TIMESTAMP, '+00:00', '+00:00') " +
                "WHERE student_id = @student_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@student_id", lblstudentid.Text);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                StudentsRefresh();
                presentStudents();
                sendingMsg();

            }
        }

        public void SelectCount()
        {
           
            connection.Open();

            // Format DateTime.Now as 'yyyy-MM-dd' for the SQL query
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); // Change the format to "yyyy-MM-dd"

            string query = "SELECT * FROM monitoringdb.tbl_attendance_records WHERE student_id = @StudentId AND DATE(date_logged) = @CurrentDate";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StudentId", txtSearch.Text);
                cmd.Parameters.AddWithValue("@CurrentDate", currentDate);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    da.Fill(table);
                    int rowCount = table.Rows.Count;
                    if (table.Rows.Count != 0)
                    {
                        StudentData();
                        EnterStudent();
                        txtSearch.Clear();
                        da.Dispose();
                        connection.Close();

                        return;

                    }
                    else
                    {

                        StudentData();
                        EnterStudent();
                        txtSearch.Clear();
                        da.Dispose();
                        connection.Close();

                        return;

                    }

                }
            }
        }


       
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectCount();
               
            }
        }

        private void radioIn_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void radioOut_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void lbltotalpresent_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
