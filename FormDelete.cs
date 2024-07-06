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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.Forms
{
    public partial class FormDelete : Form
    {
        public FormDelete()
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

                int memberID;
                int.TryParse(textBox1.Text, out memberID);
                int appID;
                int.TryParse(textBox2.Text, out appID);
                string name = textBox3.Text;


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query2 = "SELECT COUNT(*) FROM Appointment WHERE AppointmentID=@appID";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@appID", appID);
                    int count = (int)cmd2.ExecuteScalar();

                    if (count > 0)
                    {
                        string query4 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID;";
                        SqlCommand cmd4 = new SqlCommand(query4, conn);
                        cmd4.Parameters.AddWithValue("@memberID", memberID);
                        int count4 = (int)cmd4.ExecuteScalar();

                        if (count4 > 0)
                        {
                            string query3 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID AND Username=@name;";
                            SqlCommand cmd3 = new SqlCommand(query3, conn);
                            cmd3.Parameters.AddWithValue("@memberID", memberID);
                            cmd3.Parameters.AddWithValue("@name", name);
                            int count2 = (int)cmd3.ExecuteScalar();

                            if (count2 > 0)
                            {
                                string query1 = "DELETE FROM Appointment WHERE AppointmentID=@appID;";
                                SqlCommand cmd1 = new SqlCommand(query1, conn);

                                cmd1.Parameters.AddWithValue("@appID", appID);
                                cmd1.ExecuteScalar();

                                MessageBox.Show("Appointment Deleted");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong Credentials!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Member does not exist!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Appointment not found!");
                        this.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
