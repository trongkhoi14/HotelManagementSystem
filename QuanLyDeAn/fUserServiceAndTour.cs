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
    public partial class fUserServiceAndTour : Form
    {
        public fUserServiceAndTour()
        {
            InitializeComponent();
        }

        private void service_SearchingBtn_Click(object sender, EventArgs e)
        {
            fSearchingService f = new fSearchingService();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void service_confirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công! Vui lòng liên hệ lễ tân để nhận phiếu dịch vụ.");
            this.Close();
        }

        private void tourSearchingBtn_Click(object sender, EventArgs e)
        {
            fSearchingTravelTour f = new fSearchingTravelTour();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void tour_confirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công! Vui lòng liên hệ lễ tân để nhận phiếu đăng ký tour.");
            this.Close();
        }
    }
}
