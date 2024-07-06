using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormTrainerReport : Form
    {
        public FormTrainerReport()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTrainerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_PROJECTDataSet.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter1.Fill(this.dB_PROJECTDataSet.Trainer);
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
