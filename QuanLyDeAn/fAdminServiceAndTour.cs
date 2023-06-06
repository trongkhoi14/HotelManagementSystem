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
    public partial class fAdminServiceAndTour : Form
    {
        public fAdminServiceAndTour()
        {
            InitializeComponent();
        }

        private void service_searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void service_acceptBtn_Click(object sender, EventArgs e)
        {

        }

        private void service_detailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDetailUserService f = new fDetailUserService();
            f.ShowDialog();
            this.Show();
        }

        private void tour_searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void tour_acceptBtn_Click(object sender, EventArgs e)
        {

        }

        private void tour_detailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDetailUserTour f = new fDetailUserTour();
            f.ShowDialog();
            this.Show();
        }

        private void service_registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUserServiceAndTour f = new fUserServiceAndTour();
            f.ShowDialog();
            this.Show();
        }

        private void tour_registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUserServiceAndTour f = new fUserServiceAndTour();
            f.ShowDialog();
            this.Show();
        }

        private void serviceSearchingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSearchingService f = new fSearchingService();
            f.ShowDialog();
            this.Show();
        }

        private void tourSearchingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSearchingTravelTour f = new fSearchingTravelTour();
            f.ShowDialog();
            this.Show();
        }
    }
}
