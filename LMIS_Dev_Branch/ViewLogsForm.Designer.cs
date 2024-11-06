namespace LMIS_Dev_Branch
{
    partial class ViewLogsForm
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
            dgvLogs = new DataGridView();
            Activity = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            dtpStartDate = new DateTimePicker();
            lblStrtDate = new Label();
            lblEndDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblUserFilter = new Label();
            cmbUserFilter = new ComboBox();
            btnSearchLogs = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { Activity, User, Date, Time });
            dgvLogs.Location = new Point(35, 134);
            dgvLogs.Margin = new Padding(2, 2, 2, 2);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.Size = new Size(490, 210);
            dgvLogs.TabIndex = 0;
            dgvLogs.CellContentClick += dgvLogs_CellContentClick;
            // 
            // Activity
            // 
            Activity.HeaderText = "Activity";
            Activity.MinimumWidth = 8;
            Activity.Name = "Activity";
            Activity.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 150;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(35, 35);
            dtpStartDate.Margin = new Padding(2, 2, 2, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(211, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // lblStrtDate
            // 
            lblStrtDate.AutoSize = true;
            lblStrtDate.Location = new Point(35, 13);
            lblStrtDate.Margin = new Padding(2, 0, 2, 0);
            lblStrtDate.Name = "lblStrtDate";
            lblStrtDate.Size = new Size(58, 15);
            lblStrtDate.TabIndex = 2;
            lblStrtDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(384, 13);
            lblEndDate.Margin = new Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(54, 15);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "End Date";
            lblEndDate.Click += lblEndDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(384, 35);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblUserFilter
            // 
            lblUserFilter.AutoSize = true;
            lblUserFilter.Location = new Point(35, 62);
            lblUserFilter.Margin = new Padding(2, 0, 2, 0);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new Size(59, 15);
            lblUserFilter.TabIndex = 5;
            lblUserFilter.Text = "User Filter";
            // 
            // cmbUserFilter
            // 
            cmbUserFilter.FormattingEnabled = true;
            cmbUserFilter.Location = new Point(35, 86);
            cmbUserFilter.Margin = new Padding(2, 2, 2, 2);
            cmbUserFilter.Name = "cmbUserFilter";
            cmbUserFilter.Size = new Size(115, 23);
            cmbUserFilter.TabIndex = 6;
            // 
            // btnSearchLogs
            // 
            btnSearchLogs.BackColor = Color.LightBlue;
            btnSearchLogs.Location = new Point(276, 33);
            btnSearchLogs.Margin = new Padding(2, 2, 2, 2);
            btnSearchLogs.Name = "btnSearchLogs";
            btnSearchLogs.Size = new Size(78, 25);
            btnSearchLogs.TabIndex = 7;
            btnSearchLogs.Text = "Search Logs";
            btnSearchLogs.UseVisualStyleBackColor = false;
            // 
            // ViewLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 370);
            Controls.Add(btnSearchLogs);
            Controls.Add(cmbUserFilter);
            Controls.Add(lblUserFilter);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEndDate);
            Controls.Add(lblStrtDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dgvLogs);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ViewLogsForm";
            Text = "ViewLogsForm";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private DataGridViewTextBoxColumn Activity;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DateTimePicker dtpStartDate;
        private Label lblStrtDate;
        private Label lblEndDate;
        private DateTimePicker dateTimePicker1;
        private Label lblUserFilter;
        private ComboBox cmbUserFilter;
        private Button btnSearchLogs;
    }
}