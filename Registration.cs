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
using WindowsFormsApp3.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "               Username";
            textBox2.Text = "                  Email";
            textBox3.Text = "               Password";
            textBox4.Text = "                 Gym ID";
            textBox3.PasswordChar = '\0';
            textBox1.ForeColor = Color.SandyBrown;
            textBox2.ForeColor = Color.SandyBrown;
            textBox3.ForeColor = Color.SandyBrown;
            textBox4.ForeColor = Color.SandyBrown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "               Username" && textBox2.Text != "                  Email" && textBox3.Text != "               Password")
            {
                if (SharedData.role == 1)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string email = textBox2.Text;
                    string password = textBox3.Text;
                    int gymID;
                    int.TryParse(textBox4.Text,out gymID);

                    string query = "SELECT COUNT(*) FROM Member WHERE Email=@email AND [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query3 = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);

                        cmd3.Parameters.AddWithValue("@gymID", gymID);
                        int count3 = (int)cmd3.ExecuteScalar();

                        if (count3 > 0)
                        {
                            string query4 = "SELECT COUNT(*) FROM Member WHERE Username=@username";
                            SqlCommand cmd4 = new SqlCommand(query4, conn);

                            cmd4.Parameters.AddWithValue("@username", username);
                            int count4 = (int)cmd4.ExecuteScalar();

                            if (count4 == 0)
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@email", email);
                                    cmd.Parameters.AddWithValue("@password", password);
                                    cmd.Parameters.AddWithValue("@username", username);

                                    int count = (int)cmd.ExecuteScalar();

                                    if (count == 0)
                                    {
                                        string query2 = "INSERT INTO Member(Username, Email, [Passwrod], GymID) VALUES (\'" + username + "\', \'" + email + "\', \'" + password + "\', " + gymID + ");";
                                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                                        cmd2.ExecuteScalar();
                                        MessageBox.Show("Registration Successful");

                                        SharedData.username = username;
                                        string query5 = "SELECT MemberID FROM Member WHERE Username=@username";
                                        SqlCommand cmd5 = new SqlCommand(query5, conn);
                                        cmd5.Parameters.AddWithValue("@username", username);
                                        SharedData.id = (int)cmd5.ExecuteScalar();

                                        Form1 form2 = new Form1();
                                        form2.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account already exists");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Gym ID");
                        }
                    }

                }
                else if (SharedData.role == 2)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string email = textBox2.Text;
                    string password = textBox3.Text;
                    int gymID;
                    int.TryParse(textBox4.Text, out gymID);

                    string query = "SELECT COUNT(*) FROM Trainer WHERE Email=@email AND [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query3 = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);

                        cmd3.Parameters.AddWithValue("@gymID", gymID);
                        int count3 = (int)cmd3.ExecuteScalar();

                        if (count3 > 0)
                        {
                            string query4 = "SELECT COUNT(*) FROM Trainer WHERE Username=@username";
                            SqlCommand cmd4 = new SqlCommand(query4, conn);

                            cmd4.Parameters.AddWithValue("@username", username);
                            int count4 = (int)cmd4.ExecuteScalar();

                            if (count4 == 0)
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@email", email);
                                    cmd.Parameters.AddWithValue("@password", password);
                                    cmd.Parameters.AddWithValue("@username", username);

                                    int count = (int)cmd.ExecuteScalar();

                                    if (count == 0)
                                    {
                                        string query2 = "INSERT INTO Trainer(Username, Email, [Passwrod], GymID) VALUES (\'" + username + "\', \'" + email + "\', \'" + password + "\', " + gymID + ");";
                                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                                        cmd2.ExecuteScalar();
                                        MessageBox.Show("Registration Successful");

                                        SharedData.username = username;
                                        string query5 = "SELECT TrainerID FROM Trainer WHERE Username=@username";
                                        SqlCommand cmd5 = new SqlCommand(query5, conn);
                                        cmd5.Parameters.AddWithValue("@username", username);
                                        SharedData.id = (int)cmd5.ExecuteScalar();

                                        Dashboard2 form2 = new Dashboard2();
                                        form2.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account already exists");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Gym ID");
                        }
                    }
                }
                else if (SharedData.role == 3)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string email = textBox2.Text;
                    string password = textBox3.Text;
                    int gymID;
                    int.TryParse(textBox4.Text, out gymID);

                    string query = "SELECT COUNT(*) FROM GymOwner WHERE Email=@email AND [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query3 = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);

                        cmd3.Parameters.AddWithValue("@gymID", gymID);
                        int count3 = (int)cmd3.ExecuteScalar();

                        if (count3 > 0)
                        {
                            string query4 = "SELECT COUNT(*) FROM GymOwner WHERE Username=@username";
                            SqlCommand cmd4 = new SqlCommand(query4, conn);

                            cmd4.Parameters.AddWithValue("@username", username);
                            int count4 = (int)cmd4.ExecuteScalar();

                            if (count4 == 0)
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@email", email);
                                    cmd.Parameters.AddWithValue("@password", password);
                                    cmd.Parameters.AddWithValue("@username", username);

                                    int count = (int)cmd.ExecuteScalar();

                                    if (count == 0)
                                    {
                                        string query2 = "INSERT INTO GymOwner(Username, Email, [Passwrod], GymID) VALUES (\'" + username + "\', \'" + email + "\', \'" + password + "\', " + gymID + ");";
                                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                                        cmd2.ExecuteScalar();
                                        MessageBox.Show("Registration Successful");

                                        SharedData.username = username;
                                        string query5 = "SELECT OwnerID FROM GymOwner WHERE Username=@username";
                                        SqlCommand cmd5 = new SqlCommand(query5, conn);
                                        cmd5.Parameters.AddWithValue("@username", username);
                                        SharedData.id = (int)cmd5.ExecuteScalar();

                                        Dashboard3 form2 = new Dashboard3();
                                        form2.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account already exists");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Gym ID");
                        }
                    }
                }
                else if (SharedData.role == 4)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string email = textBox2.Text;
                    string password = textBox3.Text;
                    int gymID;
                    int.TryParse(textBox4.Text, out gymID);

                    string query = "SELECT COUNT(*) FROM Admin WHERE Email=@email AND [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query3 = "SELECT COUNT(*) FROM GYM WHERE GymID=@gymID";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);

                        cmd3.Parameters.AddWithValue("@gymID", gymID);
                        int count3 = (int)cmd3.ExecuteScalar();

                        if (count3 > 0)
                        {
                            string query4 = "SELECT COUNT(*) FROM Admin WHERE Username=@username";
                            SqlCommand cmd4 = new SqlCommand(query4, conn);

                            cmd4.Parameters.AddWithValue("@username", username);
                            int count4 = (int)cmd4.ExecuteScalar();

                            if (count4 == 0)
                            {
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@email", email);
                                    cmd.Parameters.AddWithValue("@password", password);
                                    cmd.Parameters.AddWithValue("@username", username);

                                    int count = (int)cmd.ExecuteScalar();

                                    if (count == 0)
                                    {
                                        string query2 = "INSERT INTO Admin(Username, Email, [Passwrod], GymID) VALUES (\'" + username + "\', \'" + email + "\', \'" + password + "\', " + gymID + ");";
                                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                                        cmd2.ExecuteScalar();
                                        MessageBox.Show("Registration Successful");

                                        SharedData.username = username;
                                        string query5 = "SELECT AdminID FROM Admin WHERE Username=@username";
                                        SqlCommand cmd5 = new SqlCommand(query5, conn);
                                        cmd5.Parameters.AddWithValue("@username", username);
                                        SharedData.id = (int)cmd5.ExecuteScalar();

                                        Dashboard4 form2 = new Dashboard4();
                                        form2.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account already exists");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Gym ID");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't leave a field empty");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "               Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "               Username";
                textBox1.ForeColor = Color.Chocolate;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "                  Email")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "                  Email";
                textBox2.ForeColor = Color.Chocolate;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "               Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "               Password";
                textBox3.ForeColor = Color.Chocolate;
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "               Password")
            {
                if (textBox3.PasswordChar == '\0')
                {
                    textBox3.PasswordChar = '*';
                }
                else if (textBox3.PasswordChar == '*')
                {
                    textBox3.PasswordChar = '\0';
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "                 Gym ID")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "                 Gym ID";
                textBox4.ForeColor = Color.Chocolate;
            }
        }
    }
}
