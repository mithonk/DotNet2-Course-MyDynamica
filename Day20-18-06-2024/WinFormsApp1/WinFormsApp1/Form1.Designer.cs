namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            form1Fname = new TextBox();
            viewForm2 = new Button();
            label2 = new Label();
            form1Lname = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            form1Female = new RadioButton();
            form1Male = new RadioButton();
            label4 = new Label();
            form1Grade = new ComboBox();
            label5 = new Label();
            form1Address = new TextBox();
            viewForm3 = new Button();
            label6 = new Label();
            label1 = new Label();
            form1Save = new Button();
            SuspendLayout();
            // 
            // form1Fname
            // 
            form1Fname.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Fname.Location = new Point(140, 47);
            form1Fname.Name = "form1Fname";
            form1Fname.Size = new Size(251, 27);
            form1Fname.TabIndex = 0;
            // 
            // viewForm2
            // 
            viewForm2.Font = new Font("Cambria", 12F);
            viewForm2.Location = new Point(169, 316);
            viewForm2.Name = "viewForm2";
            viewForm2.Size = new Size(108, 65);
            viewForm2.TabIndex = 6;
            viewForm2.Text = "View Form 2";
            viewForm2.UseVisualStyleBackColor = true;
            viewForm2.Click += viewForm2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // form1Lname
            // 
            form1Lname.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Lname.Location = new Point(140, 85);
            form1Lname.Name = "form1Lname";
            form1Lname.Size = new Size(251, 27);
            form1Lname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 0;
            label3.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(-17, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 8);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // form1Female
            // 
            form1Female.AutoSize = true;
            form1Female.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Female.Location = new Point(222, 121);
            form1Female.Name = "form1Female";
            form1Female.Size = new Size(85, 24);
            form1Female.TabIndex = 3;
            form1Female.TabStop = true;
            form1Female.Text = "Female";
            form1Female.UseVisualStyleBackColor = true;
            // 
            // form1Male
            // 
            form1Male.AutoSize = true;
            form1Male.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Male.Location = new Point(140, 121);
            form1Male.Name = "form1Male";
            form1Male.Size = new Size(66, 24);
            form1Male.TabIndex = 2;
            form1Male.TabStop = true;
            form1Male.Text = "Male";
            form1Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 0;
            label4.Text = "Grade";
            // 
            // form1Grade
            // 
            form1Grade.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Grade.FormattingEnabled = true;
            form1Grade.Items.AddRange(new object[] { "10A", "10B", "10C", "11A", "11B", "11C" });
            form1Grade.Location = new Point(140, 154);
            form1Grade.Name = "form1Grade";
            form1Grade.Size = new Size(251, 28);
            form1Grade.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // form1Address
            // 
            form1Address.Font = new Font("Microsoft Sans Serif", 10.2F);
            form1Address.Location = new Point(140, 188);
            form1Address.Multiline = true;
            form1Address.Name = "form1Address";
            form1Address.Size = new Size(251, 108);
            form1Address.TabIndex = 5;
            // 
            // viewForm3
            // 
            viewForm3.Font = new Font("Cambria", 12F);
            viewForm3.Location = new Point(283, 316);
            viewForm3.Name = "viewForm3";
            viewForm3.Size = new Size(108, 65);
            viewForm3.TabIndex = 7;
            viewForm3.Text = "View Form 3";
            viewForm3.UseVisualStyleBackColor = true;
            viewForm3.Click += viewForm3_Click;
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
            label6.TabIndex = 0;
            label6.Text = "Student Registration";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // form1Save
            // 
            form1Save.Font = new Font("Cambria", 12F);
            form1Save.Location = new Point(55, 316);
            form1Save.Name = "form1Save";
            form1Save.Size = new Size(108, 65);
            form1Save.TabIndex = 6;
            form1Save.Text = "Save";
            form1Save.UseVisualStyleBackColor = true;
            form1Save.Click += form1Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 385);
            Controls.Add(form1Female);
            Controls.Add(form1Grade);
            Controls.Add(form1Male);
            Controls.Add(groupBox1);
            Controls.Add(viewForm3);
            Controls.Add(form1Save);
            Controls.Add(viewForm2);
            Controls.Add(form1Lname);
            Controls.Add(form1Address);
            Controls.Add(form1Fname);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button viewForm2;
        private Label label2;
        private TextBox form1Lname;
        public TextBox form1Fname;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton form1Female;
        private RadioButton form1Male;
        private Label label4;
        private ComboBox form1Grade;
        private Label label5;
        public TextBox form1Address;
        private Button viewForm3;
        private Label label6;
        private Label label1;
        private Button form1Save;
    }
}
