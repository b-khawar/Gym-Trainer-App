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
using System.Xml.Linq;

namespace WindowsFormsApp3.Forms
{
    public partial class FormMemberReport : Form
    {
        public FormMemberReport()
        {
            InitializeComponent();
        }

        private void FormMemberReport_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query3 = "select Member.MemberID, Member.Username, Member.Email, Member.Passwrod, Member.GymID from Member;";
                SqlCommand command = new SqlCommand(query3, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

                int gymID;
                int.TryParse(textBox2.Text, out gymID);
                string name = textBox1.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@gymID", gymID);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string query2 = "SELECT COUNT(*) FROM Trainer WHERE Username=@name;";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@name", name);
                        int count2 = (int)cmd2.ExecuteScalar();

                        if (count2 > 0)
                        {
                            string query3 = "select Member.MemberID, Member.Username, Member.Email, Member.Passwrod, Member.GymID from Member JOIN ProfessionalTrainingSession ON Member.MemberID=ProfessionalTrainingSession.MemberID JOIN TRAINER ON ProfessionalTrainingSession.trainer_name=Trainer.Username WHERE (Trainer.username=\'" + name + "\' AND Member.GymID=" + gymID + ");";

                            SqlCommand command = new SqlCommand(query3, conn);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            guna2DataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Trainer does not exist!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gym does not exist!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

                int gymID;
                int.TryParse(textBox4.Text, out gymID);
                string planName = textBox3.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@gymID", gymID);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string query2 = "SELECT COUNT(*) FROM DietPlan WHERE PlanName=@name;";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@name", planName);
                        int count2 = (int)cmd2.ExecuteScalar();

                        if (count2 > 0)
                        {
                            string query3 = "select Member.MemberID, Member.Username, Member.Email, Member.Passwrod, Member.GymID from Member JOIN AccessDietPlan_Member ON Member.MemberID=AccessDietPlan_Member.MemberID WHERE (Member.GymID=" + gymID + " AND AccessDietPlan_Member.PlanID=(SELECT PlanID FROM DietPlan WHERE DietPlan.PlanName=\'" + planName + "\'));";

                            SqlCommand command = new SqlCommand(query3, conn);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            guna2DataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Diet Plan does not exist!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gym does not exist!");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query3 = "select Member.MemberID, Member.Username, Member.Email, Member.Passwrod, Member.GymID from Member;";
                SqlCommand command = new SqlCommand(query3, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
        }
    }
}
