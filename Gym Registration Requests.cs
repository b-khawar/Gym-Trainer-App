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
using System.Xml.Linq;

namespace WindowsFormsApp3.Forms
{
    public partial class Gym_Registration_Requests : Form
    {
        public Gym_Registration_Requests()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Gym_Registration_Requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet1.RegistrationRequests' table. You can move, or remove it, as needed.
            this.registrationRequestsTableAdapter.Fill(this.dB_PROJECTDataSet1.RegistrationRequests);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            int requestID;
            int.TryParse(textBox2.Text, out requestID);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query2 = "SELECT COUNT(*) FROM RegistrationRequests WHERE RequestID=@id;";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@id", requestID);
                int count = (int)cmd2.ExecuteScalar();

                if (count > 0)
                {
                    string query3 = "SELECT GymName FROM RegistrationRequests WHERE RequestID=@id;";
                    SqlCommand cmd3 = new SqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@id", requestID);
                    string name = (string)cmd3.ExecuteScalar();

                    string query4 = "SELECT OwnershipInfo FROM RegistrationRequests WHERE RequestID=@id;";
                    SqlCommand cmd4 = new SqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@id", requestID);
                    string info = (string)cmd4.ExecuteScalar();

                    string query5 = "SELECT CurrentActiveMembers FROM RegistrationRequests WHERE RequestID=@id;";
                    SqlCommand cmd5 = new SqlCommand(query5, conn);
                    cmd5.Parameters.AddWithValue("@id", requestID);
                    int members = (int)cmd5.ExecuteScalar();

                    string query6 = "INSERT INTO GYM(CurrentActiveMembers, GymName, OwnerInfo) VALUES(" + members + ", \'" + name + "\', \'" + info + "\');";
                    SqlCommand cmd6 = new SqlCommand(query6, conn);
                    cmd6.ExecuteNonQuery();

                    string query1 = "DELETE FROM RegistrationRequests WHERE RequestID=@id;";
                    SqlCommand cmd1 = new SqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@id", requestID);
                    cmd1.ExecuteNonQuery();

                    this.registrationRequestsTableAdapter.Fill(this.dB_PROJECTDataSet1.RegistrationRequests);
                    textBox2.Text = "";

                    MessageBox.Show("Gym has been added!");
                }
                else
                {
                    MessageBox.Show("Enter a valid Request ID");
                }
            }
        }
    }
}
