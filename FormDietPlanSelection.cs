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
    public partial class FormDietPlanSelection : Form
    {
        public FormDietPlanSelection()
        {
            InitializeComponent();
        }

        private void FormDietPlanSelection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet.DietPlan' table. You can move, or remove it, as needed.
            this.dietPlanTableAdapter.Fill(this.dB_PROJECTDataSet.DietPlan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
            string startPart = " PlanID<1000 AND";
            string endPart = " PlanID<1000";
            string purposePart = "";
            string typePart = "";
            string nutritionPart = "";
            string categoryPart = "";

            if (comboBox3.Text != "")
            {
                purposePart = " Purpose=\'" + comboBox3.Text + "\' AND";
            }
            if (comboBox4.Text != "")
            {
                typePart = " Type=\'" + comboBox4.Text + "\' AND";
            }
            if (comboBox5.Text != "")
            {
                nutritionPart = " Nutrition\'=" + comboBox5.Text + "\' AND";
            }


            if (comboBox1.Text == "Your Plans" && SharedData.role == 1)
            {
                categoryPart = " MemberID=" + SharedData.id + " AND";
            }
            if (comboBox1.Text == "Your Plans" && SharedData.role == 2)
            {
                categoryPart = " TrainerID=" + SharedData.id + " AND";
            }


            if (comboBox1.Text == "Plans created by other users" && SharedData.role == 1)
            {
                categoryPart = " MemberID!=" + SharedData.id + " AND";
            }
            if (comboBox1.Text == "Plans created by other users" && SharedData.role == 2)
            {
                categoryPart = " TrainerID!=" + SharedData.id + " AND";
            }


            if (comboBox1.Text == "Plans created by trainers")
            {
                categoryPart = " TrainerID IS NOT NULL AND";
            }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PlanID, PlanName, Breakfast, Lunch, Dinner FROM DietPlan WHERE(" + startPart + purposePart + typePart + nutritionPart + categoryPart + endPart + ");";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2DataGridView1.DataSource = dataTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select PlanID, PlanName, Breakfast, Lunch, Dinner from DietPlan where (select Calories from WorkoutMeal where (WorkoutMeal.MealName=DietPlan.Breakfast))<500;";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2DataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select PlanID, PlanName, Breakfast, Lunch, Dinner from DietPlan where (select SUM(Carbs) from WorkoutMeal where (WorkoutMeal.MealName=DietPlan.Breakfast OR WorkoutMeal.MealName=DietPlan.Lunch OR WorkoutMeal.MealName=DietPlan.Dinner))<50;";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2DataGridView1.DataSource = dataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
            int id;
            int.TryParse(textBox1.Text, out id);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query2 = "SELECT COUNT(*) FROM DietPlan WHERE PlanID=@planID;";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@planID", id);
                int count = (int)cmd2.ExecuteScalar();

                if (count > 0)
                {
                    if (SharedData.role == 1)
                    {
                        string query1 = "INSERT INTO AccessDietPlan_Member(PlanID, MemberID) VALUES(" + id + ", " + SharedData.id + ");";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteNonQuery();
                    }
                    else if (SharedData.role == 2)
                    {
                        string query1 = "INSERT INTO AccessDietPlan_Trainer(PlanID, TrainerID) VALUES(" + id + ", " + SharedData.id + ");";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteNonQuery();
                    }
                    MessageBox.Show("Diet Plan Adopted!");
                }
                else
                {
                    MessageBox.Show("Kindly select a Diet Plan that exists!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.dietPlanTableAdapter.Fill(this.dB_PROJECTDataSet.DietPlan);
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query3 = "select PlanID, PlanName, Breakfast, Lunch, Dinner from DietPlan;";
                SqlCommand command = new SqlCommand(query3, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
        }
    }
}