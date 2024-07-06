using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormManageAccounts : Form
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
        public FormManageAccounts()
        {
            InitializeComponent();
        }

        private void FormManageAccounts_Load(object sender, EventArgs e)
        {
            View.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, View.Width, View.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
        
        }

        private void View_Click(object sender, EventArgs e)
        {
            FormAddMember form2 = new FormAddMember();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDeleteMember form2 = new FormDeleteMember();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddTrainerMini form2 = new FormAddTrainerMini();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteTrainer form2 = new FormDeleteTrainer();
            form2.Show();
        }
    }
}
