
namespace ClassMonitoring.uc
{
    partial class UCstudentreports
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
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvrecentstudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentstudents)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FillColor = System.Drawing.Color.Green;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1319, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(187, 43);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // timeout
            // 
            this.timeout.HeaderText = "Time Out";
            this.timeout.MinimumWidth = 6;
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // timein
            // 
            this.timein.HeaderText = "Time In";
            this.timein.MinimumWidth = 6;
            this.timein.Name = "timein";
            this.timein.ReadOnly = true;
            // 
            // student_year
            // 
            this.student_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_year.HeaderText = "Year";
            this.student_year.MinimumWidth = 6;
            this.student_year.Name = "student_year";
            this.student_year.ReadOnly = true;
            // 
            // student_section
            // 
            this.student_section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_section.HeaderText = "Section";
            this.student_section.MinimumWidth = 6;
            this.student_section.Name = "student_section";
            this.student_section.ReadOnly = true;
            // 
            // student_name
            // 
            this.student_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.student_name.HeaderText = "Name";
            this.student_name.MinimumWidth = 6;
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
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
            // dgvrecentstudents
            // 
            this.dgvrecentstudents.AllowUserToAddRows = false;
            this.dgvrecentstudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvrecentstudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
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
            this.timeout,
            this.date});
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
            this.dgvrecentstudents.Location = new System.Drawing.Point(3, 104);
            this.dgvrecentstudents.Name = "dgvrecentstudents";
            this.dgvrecentstudents.ReadOnly = true;
            this.dgvrecentstudents.RowHeadersVisible = false;
            this.dgvrecentstudents.RowHeadersWidth = 51;
            this.dgvrecentstudents.RowTemplate.Height = 55;
            this.dgvrecentstudents.Size = new System.Drawing.Size(1509, 827);
            this.dgvrecentstudents.TabIndex = 25;
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
            this.dgvrecentstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrecentstudents_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(3, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Student";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(295, 26);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = true;
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTo.Location = new System.Drawing.Point(761, 3);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(295, 43);
            this.dtpTo.TabIndex = 27;
            this.dtpTo.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "To:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = true;
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFrom.Location = new System.Drawing.Point(382, 3);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(295, 43);
            this.dtpFrom.TabIndex = 26;
            this.dtpFrom.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // btnLoad
            // 
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(1130, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(183, 43);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.19439F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.19439F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.515123F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58041F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58041F));
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpTo, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpFrom, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLoad, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1509, 49);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "`";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvrecentstudents, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.983836F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.943758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.0724F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1515, 934);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1509, 40);
            this.guna2Panel1.TabIndex = 26;
            // 
            // UCstudentreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCstudentreports";
            this.Size = new System.Drawing.Size(1515, 934);
            this.Load += new System.EventHandler(this.UCstudentreports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecentstudents)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_section;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private Guna.UI2.WinForms.Guna2DataGridView dgvrecentstudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
