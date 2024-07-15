namespace SchoolManagementSystem
{
    partial class DashBoard
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
            studentBtn = new Button();
            label01 = new Label();
            subjectBtn = new Button();
            gradeBtn = new Button();
            SuspendLayout();
            // 
            // studentBtn
            // 
            studentBtn.BackColor = Color.FromArgb(0, 0, 64);
            studentBtn.FlatAppearance.BorderColor = Color.White;
            studentBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            studentBtn.ForeColor = Color.White;
            studentBtn.Location = new Point(5, 61);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(308, 57);
            studentBtn.TabIndex = 32;
            studentBtn.Text = "Student";
            studentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentBtn.UseVisualStyleBackColor = false;
            studentBtn.Click += studentBtn_Click;
            // 
            // label01
            // 
            label01.BackColor = Color.Purple;
            label01.BorderStyle = BorderStyle.FixedSingle;
            label01.Dock = DockStyle.Top;
            label01.FlatStyle = FlatStyle.Popup;
            label01.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label01.ForeColor = Color.White;
            label01.ImageAlign = ContentAlignment.MiddleLeft;
            label01.Location = new Point(0, 0);
            label01.Name = "label01";
            label01.RightToLeft = RightToLeft.No;
            label01.Size = new Size(319, 58);
            label01.TabIndex = 29;
            label01.Text = "School Management System";
            label01.TextAlign = ContentAlignment.MiddleCenter;
            label01.UseCompatibleTextRendering = true;
            // 
            // subjectBtn
            // 
            subjectBtn.BackColor = Color.FromArgb(0, 0, 64);
            subjectBtn.FlatAppearance.BorderColor = Color.White;
            subjectBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            subjectBtn.ForeColor = Color.White;
            subjectBtn.Location = new Point(5, 124);
            subjectBtn.Name = "subjectBtn";
            subjectBtn.Size = new Size(308, 57);
            subjectBtn.TabIndex = 33;
            subjectBtn.Text = "Subject";
            subjectBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            subjectBtn.UseVisualStyleBackColor = false;
            subjectBtn.Click += subjectBtn_Click;
            // 
            // gradeBtn
            // 
            gradeBtn.BackColor = Color.FromArgb(0, 0, 64);
            gradeBtn.FlatAppearance.BorderColor = Color.White;
            gradeBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            gradeBtn.ForeColor = Color.White;
            gradeBtn.Location = new Point(5, 187);
            gradeBtn.Name = "gradeBtn";
            gradeBtn.Size = new Size(308, 57);
            gradeBtn.TabIndex = 34;
            gradeBtn.Text = "Grade";
            gradeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            gradeBtn.UseVisualStyleBackColor = false;
            gradeBtn.Click += gradeBtn_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(319, 255);
            Controls.Add(gradeBtn);
            Controls.Add(subjectBtn);
            Controls.Add(studentBtn);
            Controls.Add(label01);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Button studentBtn;
        private Label label01;
        private Button subjectBtn;
        private Button gradeBtn;
    }
}