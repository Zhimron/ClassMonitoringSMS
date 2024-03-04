using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMonitoring.forms
{
    public partial class frmdashboard : Form
    {
        private Guna2Button activeBtn;
        
        public frmdashboard(string _type, string _username, string id)
        {
            InitializeComponent();
            lblusertype.Text = _type;
            lbluser.Text = _username;
            lblid.Text = id;

            timer1 = new Timer();
            timer1.Interval = 1000; // 1 second interval
            timer1.Tick += timer1_Tick;
            timer1.Start();
            UpdateDateTime();
            
        }
      
      
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlcontainer.Controls.Clear();
            pnlcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void OpenButton(Object senderBtn, string btnname)
        {
            if (senderBtn != null)
            {
                CloseButton(); // Make sure CloseButton() is a valid method.
                activeBtn = senderBtn as Guna2Button; // Use safe casting.

                if (activeBtn != null)
                {
                    lbl_identifier.Text = btnname;
                    activeBtn.TextAlign = HorizontalAlignment.Center; // No need for (HorizontalAlignment) and ContentAlignment.
                    activeBtn.ForeColor = Color.FromArgb(212, 164, 24);
                }
            }

        }
        public void CloseButton()
        {
            if (activeBtn != null)
            {
                activeBtn.TextAlign = HorizontalAlignment.Center;
                activeBtn.ForeColor = Color.White;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "ADMIN")
            {
                OpenButton(sender, btnclass.Text);
                uc.UCclass uc = new uc.UCclass();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            {
             
                MessageBox.Show("ERROR:For ADMIN only", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
          
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "ADMIN")
            {
                OpenButton(sender, btnstudent.Text);

                uc.UCstudents uc = new uc.UCstudents();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            {
                MessageBox.Show("ERROR:For ADMIN only", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "ADMIN")
            {
                OpenButton(sender, btnreports.Text);

                uc.UCstudentreports uc = new uc.UCstudentreports();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            {
                MessageBox.Show("ERROR:For ADMIN only", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
          
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "ADMIN")
            {
                OpenButton(sender, btnadmin.Text);
                uc.UCadmin uc = new uc.UCadmin();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            { 
                MessageBox.Show("ERROR:For ADMIN only", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
          

        }

        private void btnclassreport_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "Teacher")
            {
                OpenButton(sender, btnclassreport.Text);
                uc.UCclassreport uc = new uc.UCclassreport(lblid.Text);
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            {
               
                MessageBox.Show("ERROR:For TEACHERS only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            // Format the date and time using a custom format string
            string formattedDateTime = currentDateTime.ToString("h:mm:ss tt");

            // Update the label with the current date and time
            lbltime.Text = formattedDateTime;
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Format the date and time using custom format strings
            string formattedDate = currentDateTime.ToString("dddd, MMMM d, yyyy");
            string formattedTime = currentDateTime.ToString("h:mm:ss tt");

            // Update the labels with the formatted date and time
            lbldate.Text = formattedDate;
            lbltime.Text = formattedTime;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "Guard")
            {
                lbl_identifier.Text = "Home";
                uc.ucdashboard uc = new uc.ucdashboard();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }

            else
            {
                MessageBox.Show("ERROR:For Guard only", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsection_Click(object sender, EventArgs e)
        {
            if (lblusertype.Text == "ADMIN")
            {
                OpenButton(sender, btnsection.Text);
                uc.UCsection uc = new uc.UCsection();
                uc.Dock = DockStyle.Fill;
                addUserControl(uc);
            }
            else
            {

                MessageBox.Show("ERROR:For ADMIN only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
