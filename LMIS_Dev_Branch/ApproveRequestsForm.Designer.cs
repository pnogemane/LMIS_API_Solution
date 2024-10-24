namespace LMIS_Dev_Branch
{
    partial class ApproveRequestsForm
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
            dgvApprovalRequests = new DataGridView();
            Request_ID = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Request_Type = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            chkApproveRequest = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            btnApprove = new Button();
            btnReject = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApprovalRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvApprovalRequests
            // 
            dgvApprovalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApprovalRequests.Columns.AddRange(new DataGridViewColumn[] { Request_ID, User, Request_Type, Date, Status });
            dgvApprovalRequests.Location = new Point(35, 60);
            dgvApprovalRequests.Margin = new Padding(2, 2, 2, 2);
            dgvApprovalRequests.Name = "dgvApprovalRequests";
            dgvApprovalRequests.RowHeadersWidth = 62;
            dgvApprovalRequests.Size = new Size(581, 240);
            dgvApprovalRequests.TabIndex = 0;
            // 
            // Request_ID
            // 
            Request_ID.HeaderText = "Request ID";
            Request_ID.MinimumWidth = 8;
            Request_ID.Name = "Request_ID";
            Request_ID.Width = 150;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.Width = 150;
            // 
            // Request_Type
            // 
            Request_Type.HeaderText = "Request Type";
            Request_Type.MinimumWidth = 8;
            Request_Type.Name = "Request_Type";
            Request_Type.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // chkApproveRequest
            // 
            chkApproveRequest.AutoSize = true;
            chkApproveRequest.Location = new Point(80, 124);
            chkApproveRequest.Margin = new Padding(2, 2, 2, 2);
            chkApproveRequest.Name = "chkApproveRequest";
            chkApproveRequest.Size = new Size(82, 19);
            chkApproveRequest.TabIndex = 1;
            chkApproveRequest.Text = "Request ID";
            chkApproveRequest.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(184, 124);
            checkBox2.Margin = new Padding(2, 2, 2, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "User";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(281, 124);
            checkBox3.Margin = new Padding(2, 2, 2, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(95, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Request Type";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(396, 124);
            checkBox4.Margin = new Padding(2, 2, 2, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(50, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Date";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(503, 124);
            checkBox5.Margin = new Padding(2, 2, 2, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(54, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Satus";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.LightGreen;
            btnApprove.Location = new Point(396, 31);
            btnApprove.Margin = new Padding(2, 2, 2, 2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(78, 20);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.LightCoral;
            btnReject.Location = new Point(495, 31);
            btnReject.Margin = new Padding(2, 2, 2, 2);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(78, 20);
            btnReject.TabIndex = 7;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // ApproveRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 343);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(chkApproveRequest);
            Controls.Add(dgvApprovalRequests);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ApproveRequestsForm";
            Text = "ApproveRequestsForm";
            ((System.ComponentModel.ISupportInitialize)dgvApprovalRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApprovalRequests;
        private DataGridViewTextBoxColumn Request_ID;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Request_Type;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private CheckBox chkApproveRequest;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button btnApprove;
        private Button btnReject;
    }
}