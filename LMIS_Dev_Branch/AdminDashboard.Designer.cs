namespace LMIS_Dev_Branch
{
    partial class frmAdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblAdminDashboard = new Label();
            btnManageUsers = new Button();
            btnManageTemplates = new Button();
            btnViewLogs = new Button();
            btnApproveRequests = new Button();
            dgvUsers = new DataGridView();
            cmbTemplates = new ComboBox();
            lblSelectTemplate = new Label();
            mstFrmAdminDashboard = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            searchCoursesToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            registerStudentToolStripMenuItem = new ToolStripMenuItem();
            findStudentsToolStripMenuItem = new ToolStripMenuItem();
            enrollmentsToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentToolStripMenuItem = new ToolStripMenuItem();
            viewEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            mstFrmAdminDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdminDashboard
            // 
            lblAdminDashboard.Anchor = AnchorStyles.None;
            lblAdminDashboard.AutoSize = true;
            lblAdminDashboard.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminDashboard.ForeColor = Color.DodgerBlue;
            lblAdminDashboard.Location = new Point(230, 51);
            lblAdminDashboard.Margin = new Padding(2, 0, 2, 0);
            lblAdminDashboard.Name = "lblAdminDashboard";
            lblAdminDashboard.Size = new Size(249, 37);
            lblAdminDashboard.TabIndex = 0;
            lblAdminDashboard.Text = "Admin Dashboard";
            lblAdminDashboard.Click += lblAdminDashboard_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.LightGreen;
            btnManageUsers.Location = new Point(35, 106);
            btnManageUsers.Margin = new Padding(2);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(119, 24);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnManageTemplates
            // 
            btnManageTemplates.BackColor = Color.LightYellow;
            btnManageTemplates.Location = new Point(35, 134);
            btnManageTemplates.Margin = new Padding(2);
            btnManageTemplates.Name = "btnManageTemplates";
            btnManageTemplates.Size = new Size(119, 24);
            btnManageTemplates.TabIndex = 2;
            btnManageTemplates.Text = "Manage Templates";
            btnManageTemplates.UseVisualStyleBackColor = false;
            // 
            // btnViewLogs
            // 
            btnViewLogs.BackColor = Color.LightBlue;
            btnViewLogs.Location = new Point(35, 162);
            btnViewLogs.Margin = new Padding(2);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(119, 24);
            btnViewLogs.TabIndex = 3;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = false;
            // 
            // btnApproveRequests
            // 
            btnApproveRequests.BackColor = Color.LightCoral;
            btnApproveRequests.Location = new Point(35, 190);
            btnApproveRequests.Margin = new Padding(2);
            btnApproveRequests.Name = "btnApproveRequests";
            btnApproveRequests.Size = new Size(119, 24);
            btnApproveRequests.TabIndex = 4;
            btnApproveRequests.Text = "Approve Requests";
            btnApproveRequests.UseVisualStyleBackColor = false;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(230, 106);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(385, 240);
            dgvUsers.TabIndex = 5;
            // 
            // cmbTemplates
            // 
            cmbTemplates.FormattingEnabled = true;
            cmbTemplates.Location = new Point(230, 359);
            cmbTemplates.Margin = new Padding(2);
            cmbTemplates.Name = "cmbTemplates";
            cmbTemplates.Size = new Size(141, 23);
            cmbTemplates.TabIndex = 6;
            // 
            // lblSelectTemplate
            // 
            lblSelectTemplate.AutoSize = true;
            lblSelectTemplate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectTemplate.Location = new Point(35, 359);
            lblSelectTemplate.Margin = new Padding(2, 0, 2, 0);
            lblSelectTemplate.Name = "lblSelectTemplate";
            lblSelectTemplate.Size = new Size(168, 19);
            lblSelectTemplate.TabIndex = 7;
            lblSelectTemplate.Text = "Select Certificate Template";
            // 
            // mstFrmAdminDashboard
            // 
            mstFrmAdminDashboard.ImageScalingSize = new Size(24, 24);
            mstFrmAdminDashboard.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem });
            mstFrmAdminDashboard.Location = new Point(0, 0);
            mstFrmAdminDashboard.Name = "mstFrmAdminDashboard";
            mstFrmAdminDashboard.Size = new Size(792, 24);
            mstFrmAdminDashboard.TabIndex = 8;
            mstFrmAdminDashboard.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, searchCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(154, 22);
            addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // searchCoursesToolStripMenuItem
            // 
            searchCoursesToolStripMenuItem.Name = "searchCoursesToolStripMenuItem";
            searchCoursesToolStripMenuItem.Size = new Size(154, 22);
            searchCoursesToolStripMenuItem.Text = "Search Courses";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerStudentToolStripMenuItem, findStudentsToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // registerStudentToolStripMenuItem
            // 
            registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            registerStudentToolStripMenuItem.Size = new Size(160, 22);
            registerStudentToolStripMenuItem.Text = "Register Student";
            // 
            // findStudentsToolStripMenuItem
            // 
            findStudentsToolStripMenuItem.Name = "findStudentsToolStripMenuItem";
            findStudentsToolStripMenuItem.Size = new Size(160, 22);
            findStudentsToolStripMenuItem.Text = "Find Students";
            // 
            // enrollmentsToolStripMenuItem
            // 
            enrollmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentToolStripMenuItem, viewEnrollmentsToolStripMenuItem });
            enrollmentsToolStripMenuItem.Name = "enrollmentsToolStripMenuItem";
            enrollmentsToolStripMenuItem.Size = new Size(82, 20);
            enrollmentsToolStripMenuItem.Text = "Enrollments";
            // 
            // enrollStudentToolStripMenuItem
            // 
            enrollStudentToolStripMenuItem.Name = "enrollStudentToolStripMenuItem";
            enrollStudentToolStripMenuItem.Size = new Size(165, 22);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(165, 22);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 403);
            Controls.Add(mstFrmAdminDashboard);
            Controls.Add(lblSelectTemplate);
            Controls.Add(cmbTemplates);
            Controls.Add(dgvUsers);
            Controls.Add(btnApproveRequests);
            Controls.Add(btnViewLogs);
            Controls.Add(btnManageTemplates);
            Controls.Add(btnManageUsers);
            Controls.Add(lblAdminDashboard);
            Margin = new Padding(2);
            Name = "frmAdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            mstFrmAdminDashboard.ResumeLayout(false);
            mstFrmAdminDashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminDashboard;
        private Button btnManageUsers;
        private Button btnManageTemplates;
        private Button btnViewLogs;
        private Button btnApproveRequests;
        private DataGridView dgvUsers;
        private ComboBox cmbTemplates;
        private Label lblSelectTemplate;
        private MenuStrip mstFrmAdminDashboard;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem searchCoursesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem findStudentsToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
    }
}