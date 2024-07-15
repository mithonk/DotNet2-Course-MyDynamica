﻿namespace SchoolManagementSystem
{
    partial class subjects
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
            components = new System.ComponentModel.Container();
            deleteBtn = new Button();
            bindingSource1 = new BindingSource(components);
            search = new TextBox();
            createUpdateBtn = new Button();
            newBtn = new Button();
            label01 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            subjectIndex = new TextBox();
            label8 = new Label();
            label9 = new Label();
            subjectName = new TextBox();
            subjectNumber = new TextBox();
            dataGridView = new DataGridView();
            label2 = new Label();
            subjectOrder = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(0, 0, 64);
            deleteBtn.FlatAppearance.BorderColor = Color.White;
            deleteBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Image = Properties.Resources.delete;
            deleteBtn.Location = new Point(840, 266);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(140, 57);
            deleteBtn.TabIndex = 26;
            deleteBtn.Text = "Delete";
            deleteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(149, 6, 149);
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.ForeColor = Color.White;
            search.Location = new Point(14, 63);
            search.Margin = new Padding(5);
            search.Name = "search";
            search.Size = new Size(456, 34);
            search.TabIndex = 29;
            // 
            // createUpdateBtn
            // 
            createUpdateBtn.BackColor = Color.FromArgb(0, 0, 64);
            createUpdateBtn.BackgroundImageLayout = ImageLayout.None;
            createUpdateBtn.FlatAppearance.BorderColor = Color.White;
            createUpdateBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            createUpdateBtn.ForeColor = Color.White;
            createUpdateBtn.Image = Properties.Resources.save;
            createUpdateBtn.Location = new Point(690, 266);
            createUpdateBtn.Name = "createUpdateBtn";
            createUpdateBtn.Size = new Size(140, 57);
            createUpdateBtn.TabIndex = 27;
            createUpdateBtn.Text = "Create";
            createUpdateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // newBtn
            // 
            newBtn.BackColor = Color.FromArgb(0, 0, 64);
            newBtn.FlatAppearance.BorderColor = Color.White;
            newBtn.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold);
            newBtn.ForeColor = Color.White;
            newBtn.Image = Properties.Resources.add;
            newBtn.Location = new Point(539, 266);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(140, 57);
            newBtn.TabIndex = 28;
            newBtn.Text = "New";
            newBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            newBtn.UseVisualStyleBackColor = false;
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
            label01.Size = new Size(1026, 58);
            label01.TabIndex = 25;
            label01.Text = "Subject Registration From";
            label01.TextAlign = ContentAlignment.MiddleCenter;
            label01.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10.2F);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 1;
            label1.Text = "Subject Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(149, 6, 149);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(472, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(subjectOrder);
            groupBox1.Controls.Add(subjectIndex);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(subjectName);
            groupBox1.Controls.Add(subjectNumber);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(539, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 187);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grade Info";
            // 
            // subjectIndex
            // 
            subjectIndex.Font = new Font("Segoe UI", 9F);
            subjectIndex.Location = new Point(174, 73);
            subjectIndex.Name = "subjectIndex";
            subjectIndex.Size = new Size(250, 27);
            subjectIndex.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.2F);
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(119, 21);
            label8.TabIndex = 1;
            label8.Text = "Subject Index";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10.2F);
            label9.Location = new Point(6, 113);
            label9.Name = "label9";
            label9.Size = new Size(139, 21);
            label9.TabIndex = 1;
            label9.Text = "Subject Number";
            // 
            // subjectName
            // 
            subjectName.Font = new Font("Segoe UI", 9F);
            subjectName.Location = new Point(174, 40);
            subjectName.Name = "subjectName";
            subjectName.Size = new Size(250, 27);
            subjectName.TabIndex = 2;
            // 
            // subjectNumber
            // 
            subjectNumber.Font = new Font("Segoe UI", 9F);
            subjectNumber.Location = new Point(174, 107);
            subjectNumber.Name = "subjectNumber";
            subjectNumber.Size = new Size(250, 27);
            subjectNumber.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 101);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(519, 222);
            dataGridView.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10.2F);
            label2.Location = new Point(6, 146);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 4;
            label2.Text = "Subject Order";
            // 
            // subjectOrder
            // 
            subjectOrder.Font = new Font("Segoe UI", 9F);
            subjectOrder.Location = new Point(174, 140);
            subjectOrder.Name = "subjectOrder";
            subjectOrder.Size = new Size(250, 27);
            subjectOrder.TabIndex = 5;
            // 
            // subjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1026, 338);
            Controls.Add(deleteBtn);
            Controls.Add(search);
            Controls.Add(createUpdateBtn);
            Controls.Add(newBtn);
            Controls.Add(label01);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Name = "subjects";
            Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private BindingSource bindingSource1;
        private TextBox search;
        private Button createUpdateBtn;
        private Button newBtn;
        private Label label01;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox subjectIndex;
        private Label label8;
        private Label label9;
        private TextBox subjectName;
        private TextBox subjectNumber;
        private DataGridView dataGridView;
        private Label label2;
        private TextBox subjectOrder;
    }
}