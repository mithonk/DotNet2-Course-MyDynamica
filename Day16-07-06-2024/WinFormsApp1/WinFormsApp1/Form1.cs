using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.ShowDialog();
            //form1Fname.Text = f.fname;
        }

        private void viewForm3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void form1Save_Click(object sender, EventArgs e)
        {
            
            string connetionString = null;
            string gender = null;
            string sql = null;

            

            if (form1Male.Checked)
            {
                gender = "Male";
            }
            if (form1Female.Checked) {
                gender = "Female";
            }
            
            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;
            
            sql = "INSERT INTO students (first_name, last_name, grade, address, gender) VALUES ('" + form1Fname.Text + "', '" + form1Lname.Text + "', '" + form1Grade.Text + "', '" + form1Address.Text + "', '" + gender + "')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Save Sucessfully");
                form1Fname.Text = "";
                form1Lname.Text = "";
                form1Grade.Text = "";
                form1Address.Text = "";
                if (form1Male.Checked) { 
                    form1Male.Checked = false;
                }
                if (form1Female.Checked) { 
                    form1Female.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

            this.Close();
        }
    }
}
