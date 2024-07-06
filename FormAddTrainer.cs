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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAddTrainer : Form
    {
        public FormAddTrainer()
        {
            InitializeComponent();
        }

        private void FormAddTrainer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";
                string username = textBox2.Text;
                string email = textBox1.Text;
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

                                    MessageBox.Show("Trainer has been added!");
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Account already exists");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gym does not exist!");
                    }
                }
            }
        }
    }
}
