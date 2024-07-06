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

namespace WindowsFormsApp3.Forms
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet.Appointment' table. You can move, or remove it, as needed.
            // this.appointmentTableAdapter1.Fill(this.dB_PROJECTDataSet.Appointment);
            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query3 = "select Appointment.AppointmentID, Appointment.MemberID, Appointment.MemberName, Appointment.AppointmentTime, Appointment.DurationInMinutes from Appointment JOIN ProfessionalTrainingSession ON Appointment.MemberID=ProfessionalTrainingSession.MemberID where ProfessionalTrainingSession.trainer_name=\'"+SharedData.username+"\';";
                SqlCommand command = new SqlCommand(query3, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
        }
    }
}
