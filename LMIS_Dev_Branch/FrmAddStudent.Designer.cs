namespace LMIS_Dev_Branch
{
    partial class FrmAddStudent
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 365);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Details";
            // 
            // button1
            // 
            button1.Location = new Point(13, 286);
            button1.Name = "button1";
            button1.Size = new Size(336, 28);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 320);
            button2.Name = "button2";
            button2.Size = new Size(336, 28);
            button2.TabIndex = 2;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(149, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 13;
            label5.Text = "Student Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 171);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 171);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 109);
            textBox2.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(149, 133);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 8;
            label3.Text = "Registration Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(149, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // FrmAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 421);
            Controls.Add(groupBox1);
            Name = "FrmAddStudent";
            Text = "Add Student";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}