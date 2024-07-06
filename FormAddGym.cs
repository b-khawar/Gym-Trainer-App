using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAddGym : Form
    {
        public FormAddGym()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

                int currentMembers;
                int.TryParse(textBox2.Text, out currentMembers);
                string name = textBox1.Text;
                string ownerInfo = textBox3.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query2 = "SELECT COUNT(*) FROM GYM WHERE GymName=@name;";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@name", name);
                    int count = (int)cmd2.ExecuteScalar();

                    if (count == 0)
                    {
                        string query1 = "INSERT INTO RegistrationRequests(CurrentActiveMembers, GymName, OwnershipInfo) VALUES("+currentMembers+", \'"+name+"\', \'"+ownerInfo+"\');";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Request to add Gym has been sent to Admin!");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Name already exists!");
                    }
                }
            }
        }
    }
}