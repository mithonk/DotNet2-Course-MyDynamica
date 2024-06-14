namespace WinFormsApp1
{
    partial class DBconnection
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
            btnTest = new Button();
            insertData = new Button();
            viewData = new Button();
            dataGridView1 = new DataGridView();
            editData = new Button();
            button1 = new Button();
            dbFemale = new RadioButton();
            dbGrade = new ComboBox();
            dbMale = new RadioButton();
            groupBox1 = new GroupBox();
            dbSubmit = new Button();
            dbLname = new TextBox();
            dbAddress = new TextBox();
            dbFname = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            dbNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(142, 29);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // insertData
            // 
            insertData.Location = new Point(160, 12);
            insertData.Name = "insertData";
            insertData.Size = new Size(142, 29);
            insertData.TabIndex = 0;
            insertData.Text = "Create Data";
            insertData.UseVisualStyleBackColor = true;
            insertData.Click += insertData_Click;
            // 
            // viewData
            // 
            viewData.Location = new Point(308, 12);
            viewData.Name = "viewData";
            viewData.Size = new Size(142, 29);
            viewData.TabIndex = 0;
            viewData.Text = "View Data";
            viewData.UseVisualStyleBackColor = true;
            viewData.Click += viewData_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(797, 370);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // editData
            // 
            editData.Location = new Point(456, 12);
            editData.Name = "editData";
            editData.Size = new Size(142, 29);
            editData.TabIndex = 0;
            editData.Text = "Edit Data";
            editData.UseVisualStyleBackColor = true;
            editData.Click += editData_Click;
            // 
            // button1
            // 
            button1.Location = new Point(604, 12);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 0;
            button1.Text = "Delete Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += deleteData_Click;
            // 
            // dbFemale
            // 
            dbFemale.AutoSize = true;
            dbFemale.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbFemale.Location = new Point(1047, 130);
            dbFemale.Name = "dbFemale";
            dbFemale.Size = new Size(85, 24);
            dbFemale.TabIndex = 31;
            dbFemale.TabStop = true;
            dbFemale.Text = "Female";
            dbFemale.UseVisualStyleBackColor = true;
            // 
            // dbGrade
            // 
            dbGrade.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbGrade.FormattingEnabled = true;
            dbGrade.Items.AddRange(new object[] { "10A", "10B", "10C", "11A", "11B", "11C" });
            dbGrade.Location = new Point(965, 163);
            dbGrade.Name = "dbGrade";
            dbGrade.Size = new Size(251, 28);
            dbGrade.TabIndex = 32;
            // 
            // dbMale
            // 
            dbMale.AutoSize = true;
            dbMale.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbMale.Location = new Point(965, 130);
            dbMale.Name = "dbMale";
            dbMale.Size = new Size(66, 24);
            dbMale.TabIndex = 30;
            dbMale.TabStop = true;
            dbMale.Text = "Male";
            dbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            groupBox1.Location = new Point(809, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 8);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // dbSubmit
            // 
            dbSubmit.Font = new Font("Cambria", 12F);
            dbSubmit.Location = new Point(1108, 325);
            dbSubmit.Name = "dbSubmit";
            dbSubmit.Size = new Size(108, 65);
            dbSubmit.TabIndex = 35;
            dbSubmit.Text = "Create";
            dbSubmit.UseVisualStyleBackColor = true;
            dbSubmit.Click += dbSubmit_Click;
            // 
            // dbLname
            // 
            dbLname.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbLname.Location = new Point(965, 94);
            dbLname.Name = "dbLname";
            dbLname.Size = new Size(251, 27);
            dbLname.TabIndex = 29;
            // 
            // dbAddress
            // 
            dbAddress.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbAddress.Location = new Point(965, 197);
            dbAddress.Multiline = true;
            dbAddress.Name = "dbAddress";
            dbAddress.Size = new Size(251, 108);
            dbAddress.TabIndex = 34;
            // 
            // dbFname
            // 
            dbFname.Font = new Font("Microsoft Sans Serif", 10.2F);
            dbFname.Location = new Point(965, 56);
            dbFname.Name = "dbFname";
            dbFname.Size = new Size(251, 27);
            dbFname.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(837, 131);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 23;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.Location = new Point(837, 214);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 24;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.Location = new Point(837, 168);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 25;
            label4.Text = "Grade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.Location = new Point(837, 60);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 26;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(837, 98);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 27;
            label2.Text = "Last Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(837, 3);
            label6.Name = "label6";
            label6.Size = new Size(379, 40);
            label6.TabIndex = 28;
            label6.Text = "Student Registration";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dbNew
            // 
            dbNew.Font = new Font("Cambria", 12F);
            dbNew.Location = new Point(837, 325);
            dbNew.Name = "dbNew";
            dbNew.Size = new Size(108, 65);
            dbNew.TabIndex = 35;
            dbNew.Text = "New";
            dbNew.UseVisualStyleBackColor = true;
            dbNew.Click += dbNew_Click;
            // 
            // DBconnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 436);
            Controls.Add(dbFemale);
            Controls.Add(dbGrade);
            Controls.Add(dbMale);
            Controls.Add(groupBox1);
            Controls.Add(dbNew);
            Controls.Add(dbSubmit);
            Controls.Add(dbLname);
            Controls.Add(dbAddress);
            Controls.Add(dbFname);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(editData);
            Controls.Add(viewData);
            Controls.Add(insertData);
            Controls.Add(btnTest);
            Name = "DBconnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DBconnection";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Button insertData;
        private Button viewData;
        private DataGridView dataGridView1;
        private Button editData;
        private Button button1;
        private RadioButton dbFemale;
        private ComboBox dbGrade;
        private RadioButton dbMale;
        private GroupBox groupBox1;
        private Button dbSubmit;
        private TextBox dbLname;
        public TextBox dbAddress;
        public TextBox dbFname;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Button dbNew;
    }
}