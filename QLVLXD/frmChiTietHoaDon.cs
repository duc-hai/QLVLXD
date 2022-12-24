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
    public partial class frmChiTietHoaDon : Form
    {
        VLXDEntities1 data = new VLXDEntities1();
        bool action = false;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            getHoaDon();
            getSanPham();
            LoadData();
        }

        private void getHoaDon ()
        {
            cboMaHoaDon.DisplayMember = "SOHD";
            cboMaHoaDon.ValueMember = "SOHD";
            cboMaHoaDon.DataSource = data.HOADON.ToList();
        }

        private void getSanPham()
        {
            //cboMaSanPham.DisplayMember = "TENSANPHAM";
            cboMaSanPham.DisplayMember = "MASANPHAM";
            cboMaSanPham.ValueMember = "MASANPHAM";
            cboMaSanPham.DataSource = data.SANPHAM.ToList();
        }

        private void LoadData()
        {
            int i = 0;
            List<CHITIETHOADON> lst = data.CHITIETHOADON.ToList();
            var columns = from t in lst
                          orderby t.MAHOADON, t.MASANPHAM
                          select new
                          {
                              No = ++i,
                              MaHoaDon = t.MAHOADON,
                              MaSanPham = t.MASANPHAM,
                              SoLuong = t.SOLUONG,
                              DonGia = t.DONGIA,
                          };

            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clickSaveButton();
        }

        private void clickSaveButton ()
        {
            try
            {
                if (action == false)
                {
                    var k = new CHITIETHOADON
                    {
                        MAHOADON = cboMaHoaDon.SelectedValue.ToString(),
                        MASANPHAM = cboMaSanPham.SelectedValue.ToString(),
                        SOLUONG = int.Parse(txtSoLuong.Text.Trim()),
                        DONGIA = int.Parse(txtDonGia.Text.Trim()),
                    };
                    data.CHITIETHOADON.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    menuDelete.Enabled = false;
                    resetTextBox();
                }
                else
                {
                    //update
                    var k = data.CHITIETHOADON.Where(x => x.MAHOADON == cboMaHoaDon.SelectedValue.ToString() && x.MASANPHAM == cboMaSanPham.SelectedValue.ToString()).FirstOrDefault();

                    k.SOLUONG = int.Parse(txtSoLuong.Text.Trim());
                    k.DONGIA = int.Parse(txtDonGia.Text.Trim());
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    resetTextBox();
                    data.SaveChanges();
                    LoadData();
                }
                cboMaHoaDon.Enabled = true;
                cboMaSanPham.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại", "Cảnh báo");
            }
        }

        private void resetTextBox ()
        {
            cboMaHoaDon.ResetText();
            cboMaSanPham.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                cboMaHoaDon.SelectedIndex = cboMaHoaDon.FindStringExact(r.Cells[1].Value.ToString());
                cboMaSanPham.SelectedIndex = cboMaSanPham.FindStringExact(r.Cells[2].Value.ToString());
                txtSoLuong.Text = r.Cells[3].Value.ToString();
                txtDonGia.Text = r.Cells[4].Value.ToString();

                //
                cboMaHoaDon.Enabled = false;
                cboMaSanPham.Enabled = false;
                menuDelete.Enabled = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var k = data.CHITIETHOADON.Where(x => x.MAHOADON == cboMaHoaDon.SelectedValue.ToString() && x.MASANPHAM == cboMaSanPham.SelectedValue.ToString()).FirstOrDefault();
                data.CHITIETHOADON.Remove(k);
                data.SaveChanges();
                LoadData();
                resetTextBox();

                cboMaHoaDon.Enabled = true;
                cboMaSanPham.Enabled = true;
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            action = false;
            menuDelete.Enabled = false;
            cboMaHoaDon.Enabled = true;
            cboMaSanPham.Enabled = true;
            resetTextBox();
        }
    }
}
