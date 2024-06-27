namespace WinFormsApp1
{
    partial class Form4
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
            form4Female = new RadioButton();
            form4Grade = new ComboBox();
            form4Male = new RadioButton();
            groupBox1 = new GroupBox();
            form4Update = new Button();
            form4Lname = new TextBox();
            form4Address = new TextBox();
            form4Fname = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // form4Female
            // 
            form4Female.AutoSize = true;
            form4Female.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Female.Location = new Point(222, 126);
            form4Female.Name = "form4Female";
            form4Female.Size = new Size(85, 24);
            form4Female.TabIndex = 17;
            form4Female.TabStop = true;
            form4Female.Text = "Female";
            form4Female.UseVisualStyleBackColor = true;
            // 
            // form4Grade
            // 
            form4Grade.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Grade.FormattingEnabled = true;
            form4Grade.Items.AddRange(new object[] { "10A", "10B", "10C", "11A", "11B", "11C" });
            form4Grade.Location = new Point(140, 159);
            form4Grade.Name = "form4Grade";
            form4Grade.Size = new Size(251, 28);
            form4Grade.TabIndex = 18;
            // 
            // form4Male
            // 
            form4Male.AutoSize = true;
            form4Male.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Male.Location = new Point(140, 126);
            form4Male.Name = "form4Male";
            form4Male.Size = new Size(66, 24);
            form4Male.TabIndex = 16;
            form4Male.TabStop = true;
            form4Male.Text = "Male";
            form4Male.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(-17, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 8);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // form4Update
            // 
            form4Update.Font = new Font("Cambria", 12F);
            form4Update.Location = new Point(283, 321);
            form4Update.Name = "form4Update";
            form4Update.Size = new Size(108, 65);
            form4Update.TabIndex = 21;
            form4Update.Text = "Update";
            form4Update.UseVisualStyleBackColor = true;
            form4Update.Click += form4Update_Click;
            // 
            // form4Lname
            // 
            form4Lname.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Lname.Location = new Point(140, 90);
            form4Lname.Name = "form4Lname";
            form4Lname.Size = new Size(251, 27);
            form4Lname.TabIndex = 15;
            // 
            // form4Address
            // 
            form4Address.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Address.Location = new Point(140, 193);
            form4Address.Multiline = true;
            form4Address.Name = "form4Address";
            form4Address.Size = new Size(251, 108);
            form4Address.TabIndex = 20;
            // 
            // form4Fname
            // 
            form4Fname.Font = new Font("Microsoft Sans Serif", 10.2F);
            form4Fname.Location = new Point(140, 52);
            form4Fname.Name = "form4Fname";
            form4Fname.Size = new Size(251, 27);
            form4Fname.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 9;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 210);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 11;
            label4.Text = "Grade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 13;
            label2.Text = "Last Name";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLight;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(403, 38);
            label6.TabIndex = 14;
            label6.Text = "Student Registration";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 390);
            Controls.Add(form4Female);
            Controls.Add(form4Grade);
            Controls.Add(form4Male);
            Controls.Add(groupBox1);
            Controls.Add(form4Update);
            Controls.Add(form4Lname);
            Controls.Add(form4Address);
            Controls.Add(form4Fname);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton form4Female;
        private ComboBox form4Grade;
        private RadioButton form4Male;
        private GroupBox groupBox1;
        private Button form4Update;
        private TextBox form4Lname;
        public TextBox form4Address;
        public TextBox form4Fname;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
    }
}