using Guna.UI2.WinForms;
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
    public partial class FormWorkoutPlanReport : Form
    {
        public FormWorkoutPlanReport()
        {
            InitializeComponent();
        }

        private void FormWorkoutPlanReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet1.WorkoutPlan' table. You can move, or remove it, as needed.
            this.workoutPlanTableAdapter.Fill(this.dB_PROJECTDataSet1.WorkoutPlan);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
            string startPart = " PlanID<1000 AND";
            string endPart = " PlanID<1000";
            string goalPart = "";
            string schedulePart = "";
            string experiencePart = "";
            string machinePart = "";
            string categoryPart = "";

            int experience;
            int.TryParse(textBox2.Text, out experience);

            if (comboBox3.Text != "")
            {
                goalPart = " Goal=\'" + comboBox3.Text + "\' AND";
            }
            if (comboBox4.Text != "")
            {
                schedulePart = " schedule=\'" + comboBox4.Text + "\' AND";
            }
            if (textBox2.Text != "")
            {
                experiencePart = " Experience=" + experience + " AND";
            }
            if (textBox1.Text != "")
            {
                machinePart = " Machine!=\'" + textBox1.Text + "\'";
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

                if (machinePart == "")
                {
                    string query = "SELECT PlanID, PlanName, TrainerName, restInterval FROM WorkoutPlan WHERE(" + startPart + goalPart + schedulePart + experiencePart + categoryPart + endPart + ");";
                    MessageBox.Show(query);
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;
                }
                else
                {
                    string query = "SELECT PlanID, PlanName, TrainerName, restInterval FROM WorkoutPlan WHERE(" + startPart + goalPart + schedulePart + experiencePart + categoryPart + "((SELECT COUNT(*) FROM WorkoutPlanMachine WHERE WorkoutPlan.PlanID=WorkoutPlanMachine.PlanID AND WorkoutPlanMachine.Machine!=\'" + textBox1.Text+"\')= 0)" + ");";

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;
                }
            }
        }

        private void FormWorkoutPlanReport_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet.WorkoutPlan' table. You can move, or remove it, as needed.
            this.workoutPlanTableAdapter1.Fill(this.dB_PROJECTDataSet.WorkoutPlan);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
            string startPart = " PlanID<1000 AND";
            string endPart = " PlanID<1000";
            string goalPart = "";
            string schedulePart = "";
            string experiencePart = "";
            string machinePart = "";
            string categoryPart = "";

            int experience;
            int.TryParse(textBox3.Text, out experience);

            if (comboBox2.Text != "")
            {
                goalPart = " Goal=\'" + comboBox2.Text + "\' AND";
            }
            if (comboBox6.Text != "")
            {
                schedulePart = " schedule=\'" + comboBox6.Text + "\' AND";
            }
            if (textBox3.Text != "")
            {
                experiencePart = " Experience=" + experience + " AND";
            }
            if (textBox4.Text != "")
            {
                machinePart = " Machine!=\'" + textBox4.Text + "\'";
            }


            if (comboBox5.Text == "Your Plans" && SharedData.role == 1)
            {
                categoryPart = " MemberID=" + SharedData.id + " AND";
            }
            if (comboBox5.Text == "Your Plans" && SharedData.role == 2)
            {
                categoryPart = " TrainerID=" + SharedData.id + " AND";
            }


            if (comboBox5.Text == "Plans created by other users" && SharedData.role == 1)
            {
                categoryPart = " MemberID!=" + SharedData.id + " AND";
            }
            if (comboBox5.Text == "Plans created by other users" && SharedData.role == 2)
            {
                categoryPart = " TrainerID!=" + SharedData.id + " AND";
            }


            if (comboBox5.Text == "Plans created by trainers")
            {
                categoryPart = " TrainerID IS NOT NULL AND";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (machinePart == "")
                {
                    string query = "SELECT PlanID, PlanName, TrainerName, restInterval FROM WorkoutPlan WHERE(" + startPart + goalPart + schedulePart + experiencePart + categoryPart + endPart + ");";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView2.DataSource = dataTable;
                }
                else
                {
                    string query = "SELECT PlanID, PlanName, TrainerName, restInterval FROM WorkoutPlan WHERE(" + startPart + goalPart + schedulePart + experiencePart + categoryPart + "((SELECT COUNT(*) FROM WorkoutPlanMachine WHERE WorkoutPlan.PlanID=WorkoutPlanMachine.PlanID AND WorkoutPlanMachine.Machine!=\'" + textBox1.Text + "\')= 0)" + ");";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView2.DataSource = dataTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.workoutPlanTableAdapter1.Fill(this.dB_PROJECTDataSet.WorkoutPlan);
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query3 = "SELECT PlanID, PlanName, TrainerName, restInterval FROM WorkoutPlan;";
                SqlCommand command = new SqlCommand(query3, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView2.DataSource = dataTable;
            }
        }
    }
}
