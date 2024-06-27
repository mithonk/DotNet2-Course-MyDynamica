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

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        string id = null;
        string firstname = null;
        string lastname = null;
        string gender = null;
        string grade = null;
        string address = null;
        public Form4(string id, string firstname, string lastname, string gender, string grade, string address)
        {
            InitializeComponent();
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.grade = grade;
            this.address = address;
            this.gender = gender;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            if (gender == "Male")
            {
                form4Male.Checked = true;
            }
            else if (gender == "Female")
            {
                form4Female.Checked = true;
            }

            form4Fname.Text = firstname;
            form4Lname.Text = lastname;
            form4Grade.Text = grade;
            form4Address.Text = address;
        }

        private void form4Update_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            
            string gender = null;
            if (form4Male.Checked)
            {
                gender = "Male";
            }
            else if (form4Female.Checked)
            {
                gender = "Female";
            }
            


            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "UPDATE [students] SET [first_name] = '"+form4Fname.Text+"', [last_name] = '"+form4Lname.Text+ "', gender = '"+gender+"', [grade] = '" + form4Grade.Text+"', [address] = '"+form4Address.Text+"' WHERE [id] = '"+this.id+"' ";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            this.Close();
        }
    }
}
