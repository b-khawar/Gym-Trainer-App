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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp3.Forms
{
    public partial class BookTrainingSession : Form
    {
        public BookTrainingSession()
        {
            InitializeComponent();
        }

        private void customtextbox1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (customtextbox2.Texts == "" || customtextbox3.Texts == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string trainerName = customtextbox2.Texts;
                int duration;
                int.TryParse(customtextbox3.Texts, out duration);
                string schedule = comboBox1.Text;
                DateTime selectedDate = monthCalendar1.SelectionStart;
                string format = "yyyy-MM-dd HH:mm:ss";

                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query4 = "SELECT COUNT(*) FROM Trainer WHERE Trainer.Username=@trainerName";
                    SqlCommand cmd4 = new SqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@trainerName", trainerName);
                    int count = (int)cmd4.ExecuteScalar();

                    if (count > 0)
                    {
                        string query1 = "INSERT INTO ProfessionalTrainingSession(trainer_name, duration, schedule, session_Date, MemberID) VALUES (\'" + trainerName + "\', " + duration + ", \'" + schedule + "\', \'" + selectedDate.ToString(format) + "\', " + SharedData.id + ");";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteScalar();

                        MessageBox.Show("A session has been booked!");
                        customtextbox2.Texts = "";
                        customtextbox3.Texts = "";
                    }
                    else
                    {
                        MessageBox.Show("Trainer does not exist!");
                    }
                }

                    
            }
        }

    }
}
