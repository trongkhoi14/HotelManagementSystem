﻿using System;
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
    public partial class fCheckIn : Form
    {
        public fCheckIn()
        {
            InitializeComponent();
        }

        private void btnDangKyThongTinLuuTru_Click(object sender, EventArgs e)
        {
            fDKThongTinLuuTru f = new fDKThongTinLuuTru();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDieuChinhDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
