using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Monitoring.Forms
{
    public partial class frmDashboard : Form
    {

        private Guna2Button activeBtn;

        public frmDashboard()
        {
            InitializeComponent();
            btnClass.Click += btnClass_Click;
            btnSetup.Click += btnSetup_Click;

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
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
        public void CloseButton( )
        {
            if (activeBtn != null)
            {
                activeBtn.TextAlign = HorizontalAlignment.Left;
                activeBtn.ForeColor = Color.White;
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Code for painting the panel if needed
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Code to execute when the form loads
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            
            OpenButton(sender,btnhome.Text);

            UserControls.UCdashboard uc = new UserControls.UCdashboard();
            uc.Dock = DockStyle.Fill;
            addUserControl(uc);
        }
        private void btnstudents_Click(object sender, EventArgs e)
        {

            OpenButton(sender, btnstudents.Text);

            UserControls.UCstudents uc = new UserControls.UCstudents();
            uc.Dock = DockStyle.Fill;
            addUserControl(uc);
        }


        private void btnadmins_Click(object sender, EventArgs e)
        {
            OpenButton(sender, btnadmins.Text);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenButton(sender, btnUsers.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenButton(sender, btnReports.Text);
            UserControls.UCStudentReports uc = new UserControls.UCStudentReports();
            uc.Dock = DockStyle.Fill;
            addUserControl(uc);
        }


       


        private void btnClass_Click_1(object sender, EventArgs e)
        {
            OpenButton(btnClass, btnClass.Text);
            UserControls.UCclass uc = new UserControls.UCclass();
            uc.Dock = DockStyle.Fill;
            addUserControl(uc);
        }
    }
}
