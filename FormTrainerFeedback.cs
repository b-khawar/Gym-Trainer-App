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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3.Forms
{
    public partial class FormTrainerFeedback : Form
    {
        public FormTrainerFeedback()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false && radioButton1.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false) || (textBox1.Text == "") || (textBox2.Text == "")) {
                MessageBox.Show("Can't leave a field empty!");
            }
            else
            {
                int rating=0;
                string category="";
                string feedback = textBox1.Text;
                string trainerName = textBox2.Text;

                if (radioButton1.Checked)
                {
                    rating = 5;
                }
                else if (radioButton2.Checked)
                {
                    rating = 4;
                }
                else if (radioButton3.Checked)
                {
                    rating = 3;
                }
                else if (radioButton4.Checked)
                {
                    rating = 2;
                }
                else if (radioButton5.Checked)
                {
                    rating = 1;
                }

                if (checkBox1.Checked)
                {
                    category = "Suggestion";
                }
                else if (checkBox2.Checked)
                {
                    category = "Something is not quite right";
                }
                else if (checkBox3.Checked)
                {
                    category = "Compliment";
                }

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
                        string query1 = "INSERT INTO TrainingFeedback(Rating, Catagory, Feedback, trainer_username) VALUES (" + rating + ", \'" + category + "\', \'" + feedback + "\', \'" + trainerName + "\');";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteScalar();

                        string query2 = "SELECT FeedbackID FROM TrainingFeedback WHERE Rating=@rating AND Catagory=@category AND Feedback=@feedback;";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@rating", rating);
                        cmd2.Parameters.AddWithValue("@category", category);
                        cmd2.Parameters.AddWithValue("@feedback", feedback);
                        int fID = (int)cmd2.ExecuteScalar();

                        string query3 = "INSERT INTO Gives(FeedbackID, MemberID) VALUES(" + fID + ", " + SharedData.id + ");";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);
                        cmd3.ExecuteScalar();

                        MessageBox.Show("Your feedbabck has been recorded!");
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Trainer does not exist!");
                    }
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
