using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeAn
{
    public partial class fHomePage : Form
    {
        public fHomePage()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminServiceAndTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdminServiceAndTour f = new fAdminServiceAndTour();
            f.ShowDialog();
            this.Show();
        }

        private void userServiceAndTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUserServiceAndTour f = new fUserServiceAndTour();
            f.ShowDialog();
            this.Show();
        }
    }
}
