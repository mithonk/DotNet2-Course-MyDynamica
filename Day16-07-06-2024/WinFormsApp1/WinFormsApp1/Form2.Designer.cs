namespace WinFormsApp1
{
    partial class Form2
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
            form1Address = new TextBox();
            form2Fname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // form1Address
            // 
            form1Address.Location = new Point(161, 75);
            form1Address.Name = "form1Address";
            form1Address.Size = new Size(241, 27);
            form1Address.TabIndex = 1;
            // 
            // form2Fname
            // 
            form2Fname.Location = new Point(161, 28);
            form2Fname.Name = "form2Fname";
            form2Fname.Size = new Size(241, 27);
            form2Fname.TabIndex = 0;
            form2Fname.TextChanged += form2Fname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(308, 119);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 168);
            Controls.Add(btnSubmit);
            Controls.Add(form1Address);
            Controls.Add(form2Fname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lname;
        private TextBox form2Fname;
        private Label label2;
        private Label label1;
        private Button btnSubmit;
        private TextBox form1Address;
    }
}