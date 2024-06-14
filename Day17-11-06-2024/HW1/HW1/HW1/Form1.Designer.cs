namespace HW1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            viewData = new DataGridView();
            label = new Label();
            form1Grade = new TextBox();
            newBtn = new Button();
            deleteBtn = new Button();
            submitBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)viewData).BeginInit();
            SuspendLayout();
            // 
            // viewData
            // 
            viewData.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewData.Location = new Point(12, 47);
            viewData.Name = "viewData";
            viewData.RowHeadersWidth = 51;
            viewData.Size = new Size(325, 158);
            viewData.TabIndex = 0;
            viewData.SelectionChanged += viewData_SelectionChanged_1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(343, 87);
            label.Name = "label";
            label.Size = new Size(73, 21);
            label.TabIndex = 1;
            label.Text = "Grade";
            // 
            // form1Grade
            // 
            form1Grade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            form1Grade.Location = new Point(422, 78);
            form1Grade.Name = "form1Grade";
            form1Grade.Size = new Size(174, 30);
            form1Grade.TabIndex = 2;
            // 
            // newBtn
            // 
            newBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            newBtn.ForeColor = SystemColors.ButtonHighlight;
            newBtn.Image = Properties.Resources.add;
            newBtn.Location = new Point(343, 145);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(67, 56);
            newBtn.TabIndex = 3;
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackgroundImageLayout = ImageLayout.None;
            deleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            deleteBtn.Image = Properties.Resources.delete;
            deleteBtn.Location = new Point(416, 145);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(67, 56);
            deleteBtn.TabIndex = 3;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Font = new Font("Cascadia Code", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = SystemColors.ActiveCaptionText;
            submitBtn.Image = Properties.Resources.save;
            submitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            submitBtn.Location = new Point(489, 145);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(107, 56);
            submitBtn.TabIndex = 3;
            submitBtn.Text = "Create";
            submitBtn.TextAlign = ContentAlignment.MiddleRight;
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(606, 44);
            label1.TabIndex = 1;
            label1.Text = "Grade CRUD Operation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(606, 213);
            Controls.Add(submitBtn);
            Controls.Add(deleteBtn);
            Controls.Add(newBtn);
            Controls.Add(form1Grade);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(viewData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade CRUD Operation";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)viewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewData;
        private Label label;
        private TextBox form1Grade;
        private Button newBtn;
        private Button deleteBtn;
        private Button submitBtn;
        private Label label1;
    }
}
