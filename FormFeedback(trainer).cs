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
using Guna.UI2.WinForms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace WindowsFormsApp3.Forms
{
    public partial class FormFeedback_trainer_ : Form
    {
        public FormFeedback_trainer_()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFeedback_trainer__Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet1.TrainingFeedback' table. You can move, or remove it, as needed.
            this.trainingFeedbackTableAdapter1.Fill(this.dB_PROJECTDataSet1.TrainingFeedback);

            string connectionString = "Data Source=DESKTOP-9JO4QTR\\SQLEXPRESS;Initial Catalog=DB_PROJECT;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FeedbackID, Rating, Catagory, Feedback, trainer_username FROM TrainingFeedback WHERE trainer_username=@username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", SharedData.username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2DataGridView2.DataSource = dataTable;
            }
        }
    }
}
