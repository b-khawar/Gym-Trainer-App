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

namespace WindowsFormsApp3.Forms
{
    public partial class FormWorkoutPlan : Form
    {
        public FormWorkoutPlan()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
          //  label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormWorkoutPlan_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string planName = customtextbox1.Texts;
            string schedule = comboBox4.Text;
            string trainerName = customtextbox2.Texts;
            string goal = comboBox2.Text;
            int experience;
            int.TryParse(customtextbox4.Texts, out  experience);
            string restInterval = comboBox1.Text;

            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query4 = "SELECT COUNT(*) FROM WorkoutPlan WHERE WorkoutPlan.PlanName=@planName";
                SqlCommand cmd4 = new SqlCommand(query4, conn);
                cmd4.Parameters.AddWithValue("@planName", planName);
                int count = (int)cmd4.ExecuteScalar();

                if (count == 0)
                {
                    string query2 = "SELECT COUNT(*) FROM Trainer WHERE Trainer.Username=@trainerName";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@trainerName", trainerName);
                    int count2 = (int)cmd2.ExecuteScalar();

                    if (count2 > 0)
                    {
                        if (SharedData.role == 1)
                        {
                            string query1 = "INSERT INTO WorkoutPlan(PlanName, schedule, TrainerName, Goal, Experience, restInterval, MemberID) VALUES(\'" + planName + "\', \'" + schedule + "\', \'" + trainerName + "\', \'" + goal + "\', " + experience + ", \'" + restInterval + "\', " + SharedData.id + ");";
                            SqlCommand cmd1 = new SqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                        }
                        else if (SharedData.role == 2)
                        {
                            string query1 = "INSERT INTO WorkoutPlan(PlanName, schedule, TrainerName, Goal, Experience, restInterval, MemberID, TrainerID) VALUES(\'" + planName + "\', \'" + schedule + "\', \'" + trainerName + "\', \'" + goal + "\', " + experience + ", \'" + restInterval + "\', NULL, " + SharedData.id + ");";
                            SqlCommand cmd1 = new SqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                        }

                        string query3 = "SELECT PlanID FROM WorkoutPlan WHERE WorkoutPlan.PlanName=@planName";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);
                        cmd3.Parameters.AddWithValue("@planName", planName);
                        int planID = (int)cmd3.ExecuteScalar();

                        if (checkBox1.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox1.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox2.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox2.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox3.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox3.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox4.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox4.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox5.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox5.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox6.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox6.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox7.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox7.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox8.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox8.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox9.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox9.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox10.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox10.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox11.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox11.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox12.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox12.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox13.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox13.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox14.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox14.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox15.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox15.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox16.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox16.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox17.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox17.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox18.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox18.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox19.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox19.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox20.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox20.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox21.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox21.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox22.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox22.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox23.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox23.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox24.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox24.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox25.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox25.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox26.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox26.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox27.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox27.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox28.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanExercise(PlanID, Excercise) VALUES(" + planID + ", \'" + checkBox28.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }


                        if (checkBox29.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox29.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox30.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox30.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox33.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox33.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox34.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox34.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox36.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox36.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox37.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox37.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox39.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox39.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox40.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox40.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox31.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox31.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox32.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox32.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox45.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox45.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox46.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox46.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }
                        if (checkBox49.Checked)
                        {
                            string query = "INSERT INTO WorkoutPlanMachine(PlanID, Machine) VALUES(" + planID + ", \'" + checkBox49.Text + "\');";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Workout has been added!");
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                        checkBox7.Checked = false;
                        checkBox8.Checked = false;
                        checkBox9.Checked = false;
                        checkBox10.Checked = false;
                        checkBox11.Checked = false;
                        checkBox12.Checked = false;
                        checkBox13.Checked = false;
                        checkBox14.Checked = false;
                        checkBox15.Checked = false;
                        checkBox16.Checked = false;
                        checkBox17.Checked = false;
                        checkBox18.Checked = false;
                        checkBox19.Checked = false;
                        checkBox20.Checked = false;
                        checkBox21.Checked = false;
                        checkBox22.Checked = false;
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox27.Checked = false;
                        checkBox28.Checked = false;

                        checkBox29.Checked = false;
                        checkBox30.Checked = false;
                        checkBox31.Checked = false;
                        checkBox32.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        checkBox36.Checked = false;
                        checkBox37.Checked = false;
                        checkBox39.Checked = false;
                        checkBox40.Checked = false;
                        checkBox45.Checked = false;
                        checkBox46.Checked = false;
                        checkBox49.Checked = false;

                        customtextbox1.Texts = "";
                        customtextbox2.Texts = "";
                        customtextbox4.Texts = "";
                        comboBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Trainer Name does not exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Plan Name already exists!");
                }
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
