namespace LMIS_Dev_Branch
{
    partial class frmLMIS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            searchCoursesToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            registerStudentToolStripMenuItem = new ToolStripMenuItem();
            findStudentsToolStripMenuItem = new ToolStripMenuItem();
            enrollmentsToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentToolStripMenuItem = new ToolStripMenuItem();
            viewEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentsToolStripMenuItem, enrollmentsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1144, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCourseToolStripMenuItem, searchCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(154, 22);
            addCourseToolStripMenuItem.Text = "Add Course";
            addCourseToolStripMenuItem.Click += addCourseToolStripMenuItem_Click;
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
            registerStudentToolStripMenuItem.Size = new Size(180, 22);
            registerStudentToolStripMenuItem.Text = "Register Student";
            registerStudentToolStripMenuItem.Click += registerStudentToolStripMenuItem_Click;
            // 
            // findStudentsToolStripMenuItem
            // 
            findStudentsToolStripMenuItem.Name = "findStudentsToolStripMenuItem";
            findStudentsToolStripMenuItem.Size = new Size(180, 22);
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
            enrollStudentToolStripMenuItem.Size = new Size(180, 22);
            enrollStudentToolStripMenuItem.Text = "Enroll Student";
            enrollStudentToolStripMenuItem.Click += enrollStudentToolStripMenuItem_Click;
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(180, 22);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 316);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(9, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(291, 105);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 74);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 39);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Course Code";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 259);
            button1.Name = "button1";
            button1.Size = new Size(297, 30);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(6, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(294, 120);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Course Dates";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Start Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(88, 66);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(354, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 398);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(709, 357);
            dataGridView1.TabIndex = 0;
            // 
            // frmLMIS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmLMIS";
            Text = "LMS";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem enrollmentsToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem registerStudentToolStripMenuItem;
        private ToolStripMenuItem findStudentsToolStripMenuItem;
        private ToolStripMenuItem searchCoursesToolStripMenuItem;
        private ToolStripMenuItem enrollStudentToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
        private Label label4;
        private Label label3;
    }
}
