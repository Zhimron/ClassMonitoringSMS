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


namespace Attendance_Monitoring.UserControls
{
    public partial class UCclass : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ClassDB db = new ClassDB();
        public UCclass()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = db.GetConnection();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadTeachersData()
        {

            dgvteacherstudents.Rows.Clear();
            using (connection)
            {
                connection.Open();
                using (cmd = new MySqlCommand("SELECT t1.name,t2.teacher_student_section,t2.teacher_student_year FROM monitoringsmsdb.tbl_users AS t1 left join monitoringsmsdb.tbl_teacher_student as t2 on t2.teachers_id = t2.id WHERE t1.user_type = 'Teacher' ", connection))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        dgvteacherstudents.Rows.Add( dr["name"].ToString(), dr["teacher_student_section"].ToString(), dr["teacher_student_year"].ToString());
                    }
                }
            }
        }

        private void UCclass_Load(object sender, EventArgs e)
        {
            LoadTeachersData();
        }
    }
}
