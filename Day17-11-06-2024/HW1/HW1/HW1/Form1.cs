using HW1.Properties;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public string id;

        public Form1()
        {
            InitializeComponent();
        }

        private void FetchData()
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM grade";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                viewData.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

        }

        private void ClearData()
        {
            form1Grade.Clear();
            submitBtn.Image = HW1.Properties.Resources.save;
            submitBtn.Text = "Create";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchData();
        }


        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearData();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = viewData.CurrentRow.Cells["id"].Value.ToString();

            DialogResult DG = MessageBox.Show("Do You Want to Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (DG == DialogResult.No)
            {
                return;
            }
            string connetionString = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;
            string sql = "DELETE FROM grade WHERE id = '" + id + "'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            ClearData();
            FetchData();
        }

        private void viewData_SelectionChanged_1(object sender, EventArgs e)
        {
            if (viewData.SelectedRows.Count > 0)
            {
                submitBtn.Image = HW1.Properties.Resources.edit;
                submitBtn.Text = "Update";
                this.id = viewData.SelectedRows[0].Cells["id"].Value.ToString();
                string grade = viewData.SelectedRows[0].Cells["grade"].Value.ToString();

                form1Grade.Text = grade;

            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

           //if (submitBtn.Image == HW1.Properties.Resources.save)
            if(submitBtn.Text == "Create")
            {
                string connetionString = null;
                string sql = null;



                connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);

                SqlCommand command;

                sql = "INSERT INTO grade (grade) VALUES ('" + form1Grade.Text + "')";

                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
                ClearData();
                FetchData();
            }
            else
            {
                string connetionString = null;
                connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";



                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                SqlCommand command;
                string sql = "UPDATE [grade] SET [grade] = '" + form1Grade.Text + "' WHERE [id] = '" + this.id + "' ";

                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! " + ex.Message);
                }
            }
            ClearData();
            FetchData();
        }
    }
}
