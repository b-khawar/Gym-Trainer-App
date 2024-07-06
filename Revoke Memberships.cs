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
    public partial class Revoke_Memberships : Form
    {
        public Revoke_Memberships()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == "" || customtextbox2.Texts == "" || customtextbox3.Texts == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                int gymID;
                int.TryParse(customtextbox1.Texts, out gymID);
                string gymName = customtextbox2.Texts;
                string reason = customtextbox3.Texts;
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query3 = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID";
                    SqlCommand cmd3 = new SqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@gymID", gymID);
                    int count3 = (int)cmd3.ExecuteScalar();

                    if (count3 > 0)
                    {
                        string query = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID AND GymName=@gymname";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@gymID", gymID);
                        cmd.Parameters.AddWithValue("@gymname", gymName);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            string query1 = "DELETE FROM GYM WHERE GymID=@gymID";
                            SqlCommand cmd1 = new SqlCommand(query1, conn);
                            cmd1.Parameters.AddWithValue("@gymID", gymID);
                            cmd1.ExecuteNonQuery();

                            string query2 = "INSERT INTO RevokeMembershipsOfGyms(GymName, Reason, AdminID) VALUES(\'"+gymName+"\', \'"+reason+"\', "+SharedData.id+");";
                            SqlCommand cmd2 = new SqlCommand(query2, conn);
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("Gym has been removed!");
                            customtextbox1.Texts = "";
                            customtextbox2.Texts = "";
                            customtextbox3.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Credentials");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gym does not exist");
                    }
                }
            }
        }
    }
}
