namespace LMIS_Dev_Branch
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            lblSelectRole = new Label();
            comboBox1 = new ComboBox();
            lblUsername = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(385, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblSelectRole
            // 
            lblSelectRole.AutoSize = true;
            lblSelectRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectRole.ForeColor = Color.DarkBlue;
            lblSelectRole.Location = new Point(50, 220);
            lblSelectRole.Name = "lblSelectRole";
            lblSelectRole.Size = new Size(106, 25);
            lblSelectRole.TabIndex = 1;
            lblSelectRole.Text = "Select Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Users" });
            comboBox1.Location = new Point(50, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(353, 33);
            comboBox1.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkBlue;
            lblUsername.Location = new Point(50, 294);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 322);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your username";
            textBox1.Size = new Size(353, 31);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(50, 369);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 409);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(353, 31);
            textBox2.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 524);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblUsername);
            Controls.Add(comboBox1);
            Controls.Add(lblSelectRole);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSelectRole;
        private ComboBox comboBox1;
        private Label lblUsername;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
    }
}