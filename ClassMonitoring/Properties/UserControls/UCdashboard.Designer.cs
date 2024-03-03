
namespace Attendance_Monitoring.UserControls
{
    partial class UCdashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbltotalstudents = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbltotalpresent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.studentpic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvrecentstudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbPorts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioIn = new System.Windows.Forms.RadioButton();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentstudents)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.37146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.62419F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 769);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.guna2Panel12.BorderRadius = 10;
            this.guna2Panel12.BorderThickness = 5;
            this.guna2Panel12.Controls.Add(this.lbltotalstudents);
            this.guna2Panel12.Controls.Add(this.label24);
            this.guna2Panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel12.Location = new System.Drawing.Point(3, 497);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(678, 269);
            this.guna2Panel12.TabIndex = 8;
            // 
            // lbltotalstudents
            // 
            this.lbltotalstudents.AutoSize = true;
            this.lbltotalstudents.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalstudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lbltotalstudents.Location = new System.Drawing.Point(319, 112);
            this.lbltotalstudents.Name = "lbltotalstudents";
            this.lbltotalstudents.Size = new System.Drawing.Size(41, 44);
            this.lbltotalstudents.TabIndex = 1;
            this.lbltotalstudents.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(10);
            this.label24.Size = new System.Drawing.Size(289, 64);
            this.label24.TabIndex = 0;
            this.label24.Text = "Total Students";
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.guna2Panel13.BorderRadius = 10;
            this.guna2Panel13.BorderThickness = 5;
            this.guna2Panel13.Controls.Add(this.lbltotalpresent);
            this.guna2Panel13.Controls.Add(this.label1);
            this.guna2Panel13.Controls.Add(this.label26);
            this.guna2Panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel13.Location = new System.Drawing.Point(687, 497);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.Size = new System.Drawing.Size(678, 269);
            this.guna2Panel13.TabIndex = 3;
            // 
            // lbltotalpresent
            // 
            this.lbltotalpresent.AutoSize = true;
            this.lbltotalpresent.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lbltotalpresent.Location = new System.Drawing.Point(319, 112);
            this.lbltotalpresent.Name = "lbltotalpresent";
            this.lbltotalpresent.Size = new System.Drawing.Size(41, 44);
            this.lbltotalpresent.TabIndex = 2;
            this.lbltotalpresent.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(432, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Present Students";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.label26.Location = new System.Drawing.Point(47, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 23);
            this.label26.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 412);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.studentpic, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(672, 381);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // studentpic
            // 
            this.studentpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentpic.Location = new System.Drawing.Point(339, 3);
            this.studentpic.Name = "studentpic";
            this.studentpic.Size = new System.Drawing.Size(330, 375);
            this.studentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentpic.TabIndex = 30;
            this.studentpic.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42254F));
            this.tableLayoutPanel2.Controls.Add(this.lblyear, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblsection, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblstudentid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(330, 375);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Location = new System.Drawing.Point(100, 279);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(60, 23);
            this.lblyear.TabIndex = 11;
            this.lblyear.Text = "Year:";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(100, 186);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(88, 23);
            this.lblsection.TabIndex = 10;
            this.lblsection.Text = "Section:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(100, 93);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 23);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name:";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(100, 0);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(116, 23);
            this.lblstudentid.TabIndex = 8;
            this.lblstudentid.Text = "Student-ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student-ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Section:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvrecentstudents);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(687, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 412);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // dgvrecentstudents
            // 
            this.dgvrecentstudents.AllowUserToAddRows = false;
            this.dgvrecentstudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvrecentstudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrecentstudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrecentstudents.ColumnHeadersHeight = 48;
            this.dgvrecentstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrecentstudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.student_name,
            this.student_section,
            this.student_year,
            this.timein,
            this.timeout});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrecentstudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrecentstudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvrecentstudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecentstudents.Location = new System.Drawing.Point(3, 28);
            this.dgvrecentstudents.Name = "dgvrecentstudents";
            this.dgvrecentstudents.ReadOnly = true;
            this.dgvrecentstudents.RowHeadersVisible = false;
            this.dgvrecentstudents.RowHeadersWidth = 51;
            this.dgvrecentstudents.RowTemplate.Height = 55;
            this.dgvrecentstudents.Size = new System.Drawing.Size(672, 381);
            this.dgvrecentstudents.TabIndex = 0;
            this.dgvrecentstudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecentstudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvrecentstudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvrecentstudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvrecentstudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvrecentstudents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecentstudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvrecentstudents.ThemeStyle.HeaderStyle.Height = 48;
            this.dgvrecentstudents.ThemeStyle.ReadOnly = true;
            this.dgvrecentstudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvrecentstudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvrecentstudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrecentstudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvrecentstudents.ThemeStyle.RowsStyle.Height = 55;
            this.dgvrecentstudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvrecentstudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Enter Student ID here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(678, 68);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cmbPorts, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(687, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(678, 70);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // cmbPorts
            // 
            this.cmbPorts.BackColor = System.Drawing.Color.Transparent;
            this.cmbPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPorts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPorts.ItemHeight = 30;
            this.cmbPorts.Location = new System.Drawing.Point(342, 3);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(333, 36);
            this.cmbPorts.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.radioOut, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioIn, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(333, 64);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // radioOut
            // 
            this.radioOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOut.Location = new System.Drawing.Point(169, 3);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(160, 58);
            this.radioOut.TabIndex = 1;
            this.radioOut.Text = "TIME OUT";
            this.radioOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioOut.UseVisualStyleBackColor = true;
            this.radioOut.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioIn
            // 
            this.radioIn.Checked = true;
            this.radioIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIn.Location = new System.Drawing.Point(3, 3);
            this.radioIn.Name = "radioIn";
            this.radioIn.Size = new System.Drawing.Size(160, 58);
            this.radioIn.TabIndex = 0;
            this.radioIn.TabStop = true;
            this.radioIn.Text = "TIME IN";
            this.radioIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioIn.UseVisualStyleBackColor = true;
            this.radioIn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // student_id
            // 
            this.student_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.student_id.HeaderText = "Student Id";
            this.student_id.MinimumWidth = 6;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 123;
            // 
            // student_name
            // 
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_name.HeaderText = "Name";
            this.student_name.MinimumWidth = 6;
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            // 
            // student_section
            // 
            this.student_section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_section.HeaderText = "Section";
            this.student_section.MinimumWidth = 6;
            this.student_section.Name = "student_section";
            this.student_section.ReadOnly = true;
            // 
            // student_year
            // 
            this.student_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_year.HeaderText = "Year";
            this.student_year.MinimumWidth = 6;
            this.student_year.Name = "student_year";
            this.student_year.ReadOnly = true;
            // 
            // timein
            // 
            this.timein.HeaderText = "Time In";
            this.timein.MinimumWidth = 6;
            this.timein.Name = "timein";
            this.timein.ReadOnly = true;
            // 
            // timeout
            // 
            this.timeout.HeaderText = "Time Out";
            this.timeout.MinimumWidth = 6;
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // UCdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCdashboard";
            this.Size = new System.Drawing.Size(1368, 769);
            this.Load += new System.EventHandler(this.UCdashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel12.ResumeLayout(false);
            this.guna2Panel12.PerformLayout();
            this.guna2Panel13.ResumeLayout(false);
            this.guna2Panel13.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentstudents)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvrecentstudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox studentpic;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private System.Windows.Forms.Label lbltotalstudents;
        private System.Windows.Forms.Label label24;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private System.Windows.Forms.Label lbltotalpresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPorts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_section;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
    }
}
