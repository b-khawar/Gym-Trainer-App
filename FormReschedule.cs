using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormReschedule : Form
    {
        public FormReschedule()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || dateTimePicker1.Checked == false)
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
                int duration;
                int.TryParse(textBox4.Text, out duration);
                DateTime apptime;
                apptime = dateTimePicker1.Value;
                string format = "yyyy-MM-dd HH:mm:ss";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query4 = "SELECT COUNT(*) FROM Appointment WHERE AppointmentID=@appID";
                    SqlCommand cmd4 = new SqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@appID", appID);
                    int count4 = (int)cmd4.ExecuteScalar();

                    if (count4 > 0)
                    {
                        string query2 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID;";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@memberID", memberID);
                        int count = (int)cmd2.ExecuteScalar();

                        if (count > 0)
                        {
                            string query3 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID AND Username=@name;";
                            SqlCommand cmd3 = new SqlCommand(query3, conn);
                            cmd3.Parameters.AddWithValue("@memberID", memberID);
                            cmd3.Parameters.AddWithValue("@name", name);
                            int count2 = (int)cmd3.ExecuteScalar();

                            if (count2 > 0)
                            {
                                string query1 = "UPDATE Appointment SET MemberID=@memberID, MemberName=@name, AppointmentTime=@appTime, DurationInMinutes=@duration WHERE AppointmentID=@appID;";
                                SqlCommand cmd1 = new SqlCommand(query1, conn);

                                cmd1.Parameters.AddWithValue("@memberID", memberID);
                                cmd1.Parameters.AddWithValue("@name", name);
                                cmd1.Parameters.AddWithValue("@appTime", apptime.ToString(format));
                                cmd1.Parameters.AddWithValue("@duration", duration);
                                cmd1.Parameters.AddWithValue("@appID", appID);
                                cmd1.ExecuteScalar();

                                MessageBox.Show("Appointment Re-Scheduled!");
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
                        MessageBox.Show("Appointment is not scheduled! You have to schedule it first!");
                        this.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
