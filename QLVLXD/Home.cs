﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVLXD
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        private void Home_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        public Home()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pnCKhachHang(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void panelControl4_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.Show();
        }

        private void panelControl2_Click(object sender, EventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.Show();
        }

        private void panelControl3_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
        }

        private void panelControl5_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
        }
    }
}
