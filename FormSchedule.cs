using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.Forms
{
    public partial class FormSchedule : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || dateTimePicker1.Checked == false)
            {
                MessageBox.Show("Can't leave a feild empty!");
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

                int memberID;
                int.TryParse(textBox1.Text, out memberID);
                string name = textBox3.Text;
                DateTime apptime;
                string format = "yyyy-MM-dd";
                apptime = dateTimePicker1.Value;
                int duration;
                int.TryParse(textBox3.Text, out duration);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query2 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID;";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@memberID", memberID);
                    int count = (int)cmd2.ExecuteScalar();

                    if (count > 0)
                    {
                        string query3 = "SELECT COUNT(*) FROM Member WHERE MemberID=@memberID AND Username=@name;";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);
                        cmd3.Parameters.AddWithValue("@memberID", memberID);
                        cmd3.Parameters.AddWithValue("@name", name);
                        int count2 = (int)cmd3.ExecuteScalar();

                        if (count2 > 0)
                        {
                            string query1 = "INSERT INTO Appointment(MemberID, MemberName, AppointmentTime, DurationInMinutes) VALUES(" + memberID + ", \'" + name + "\', \'" + apptime.ToString(format) + "\', " + duration + ");";
                            SqlCommand cmd1 = new SqlCommand(query1, conn);

                            cmd1.ExecuteScalar();

                            MessageBox.Show("Appointment Scheduled!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Credentials!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Member does not exist!");
                    }
                    
                }
            }
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
