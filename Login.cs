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

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "               Username" && textBox3.Text != "               Password")
            {
                if (SharedData.role == 1)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string password = textBox3.Text;

                    string query = "SELECT COUNT(*) FROM Member WHERE [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@username", username);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
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
                                MessageBox.Show("Account does not exists");
                            }
                        }

                    }
                }
                else if (SharedData.role == 2)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string password = textBox3.Text;

                    string query = "SELECT COUNT(*) FROM Trainer WHERE [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@username", username);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
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
                                MessageBox.Show("Account does not exists");
                            }
                        }

                    }
                }
                else if (SharedData.role == 3)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string password = textBox3.Text;

                    string query = "SELECT COUNT(*) FROM GymOwner WHERE [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@username", username);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
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
                                MessageBox.Show("Account does not exists");
                            }
                        }

                    }
                }
                else if (SharedData.role == 4)
                {
                    string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                    string username = textBox1.Text;
                    string password = textBox3.Text;

                    string query = "SELECT COUNT(*) FROM Admin WHERE [Passwrod]=@password AND Username=@username";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@username", username);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
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
                                MessageBox.Show("Account does not exists");
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Can't leave a field empty");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "                 Username";
            textBox3.Text = "                 Password";
            textBox3.PasswordChar = '\0';
            textBox1.ForeColor = Color.Chocolate;
            textBox3.ForeColor = Color.Chocolate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration form2 = new Registration();
            form2.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "                 Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "                 Username";
                textBox1.ForeColor = Color.Chocolate;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "                 Password")
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
                textBox3.Text = "                 Password";
                textBox3.ForeColor = Color.Chocolate;
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "                 Password")
            {
                if (textBox3.PasswordChar == '*')
                {
                    textBox3.PasswordChar = '\0';
                }
                else if (textBox3.PasswordChar == '\0')
                {
                    textBox3.PasswordChar = '*';
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
