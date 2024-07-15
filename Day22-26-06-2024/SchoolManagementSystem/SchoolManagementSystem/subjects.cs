using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class subjects : Form
    {
        public subjects()
        {
            InitializeComponent();
        }


        private void FetchData()
        {
            string connectionString = null;
            string sql = null;

            connectionString = "Server=MITHONK\\SQLEXPRESS; Database=SchoolManagementSystem; Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            SqlCommand command;

            sql = "SELECT * FROM grades";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);

                dataGridView.DataSource = dt;
                sqlDataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection");
            }
        }

        private void ClearData()
        {
            gradeName.Clear();
            gradeGroup.Clear();
            gradeOrder.Clear();
            createUpdateBtn.Image = SchoolManagementSystem.Properties.Resources.save;
            createUpdateBtn.Text = "Create";
        }

    }
}
