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
    public partial class FormDietPlan : Form
    {
        public FormDietPlan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormDietPlan_Load(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customtextbox1.Texts == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else {
                string planName = customtextbox1.Texts;
                string breakfastName = comboBox1.Text;
                string lunchName = comboBox3.Text;
                string dinnerName = comboBox2.Text;
                string type = comboBox6.Text;
                string purpose = comboBox4.Text;
                string nutrition = comboBox5.Text;

                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query4 = "SELECT COUNT(*) FROM DietPlan WHERE DietPlan.PlanName=@planName";
                    SqlCommand cmd4 = new SqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@planName", planName);
                    int count = (int)cmd4.ExecuteScalar();

                    if (count == 0)
                    {
                        if (SharedData.role == 1)
                        {
                            string query3 = "INSERT INTO DietPlan(PlanName, Breakfast, Lunch, Dinner, Type, Purpose, Nutrition, MemberID) VALUES(\'" + planName + "\', \'" + breakfastName + "\', \'" + lunchName + "\', \'" + dinnerName + "\', \'" + type + "\', \'" + purpose + "\', \'" + nutrition + "\', " + SharedData.id + ");";
                            SqlCommand cmd3 = new SqlCommand(query3, conn);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Diet Plan has been added!");
                            customtextbox1.Texts = "";
                        }
                        else if (SharedData.role == 2)
                        {
                            string query3 = "INSERT INTO DietPlan(PlanName, Breakfast, Lunch, Dinner, Type, Purpose, Nutrition, MemberID, TrainerID) VALUES(\'" + planName + "\', \'" + breakfastName + "\', \'" + lunchName + "\', \'" + dinnerName + "\', \'" + type + "\', \'" + purpose + "\', \'" + nutrition + "\', NULL, " + SharedData.id + ");";
                            SqlCommand cmd3 = new SqlCommand(query3, conn);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Diet Plan has been added!");
                            customtextbox1.Texts = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Plan Name aready exists!");
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
