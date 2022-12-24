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
    public partial class frmSanPham : Form
    {
        VLXDEntities2 data = new VLXDEntities2();
        bool action = false;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            getLoaiSanPham();
            LoadData();
        }

        private void getLoaiSanPham ()
        {
            //cboLoaiSP.DisplayMember = "TENLOAISANPHAM";
            cboLoaiSP.DisplayMember = "MALOAISANPHAM";
            cboLoaiSP.ValueMember = "MALOAISANPHAM";
            cboLoaiSP.DataSource = data.LOAISANPHAM.ToList();
        }

        void LoadData()
        {
            int i = 0;
            List<SANPHAM> lst = data.SANPHAM.ToList();
            var columns = from t in lst
                          orderby t.MASANPHAM
                          select new
                          {
                              No = ++i,
                              MaSanPham = t.MASANPHAM,
                              TenSanPham = t.TENSANPHAM,
                              NhaSanXuat = t.NHASANXUAT,
                              MaLoaiSanPham = t.MALOAISANPHAM,
                          };

            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clickSaveButton();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clickSaveButton();
        }

        private void clickSaveButton ()
        {
            try
            {
                if (action == false)
                {
                    var k = new SANPHAM
                    {
                        MASANPHAM = txtMaSP.Text.Trim(),
                        TENSANPHAM = txtTenSP.Text.Trim(),
                        NHASANXUAT = txtNSX.Text.Trim(),
                        MALOAISANPHAM = cboLoaiSP.SelectedValue.ToString(),
                    };
                    data.SANPHAM.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    txtMaSP.ReadOnly = false;
                    menuDelete.Enabled = false;
                    resetTextBox();
                }
                else
                {
                    //update
                    var k = data.SANPHAM.Where(x => x.MASANPHAM == txtMaSP.Text.Trim()).FirstOrDefault();

                    k.TENSANPHAM = txtTenSP.Text.Trim();
                    k.NHASANXUAT = txtNSX.Text.Trim();
                    k.MALOAISANPHAM = cboLoaiSP.SelectedValue.ToString();
                   
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    resetTextBox();
                    data.SaveChanges();
                    LoadData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại", "Cảnh báo");
            }
        }

       private void resetTextBox ()
        {
            txtMaSP.Focus();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtNSX.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtMaSP.Text = r.Cells[1].Value.ToString();
                txtTenSP.Text = r.Cells[2].Value.ToString();
                txtNSX.Text = r.Cells[3].Value.ToString();
                cboLoaiSP.SelectedIndex = cboLoaiSP.FindStringExact(r.Cells[4].Value.ToString());

                menuDelete.Enabled = true;
                txtMaSP.ReadOnly = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (data.CHITIETHOADON.Where(x => x.MASANPHAM == txtMaSP.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Dữ liệu khóa ngoại bảng Chi Tiết Hóa Đơn không hợp lệ, không thể xóa !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var k = data.SANPHAM.Where(x => x.MASANPHAM == txtMaSP.Text.Trim()).FirstOrDefault();
                data.SANPHAM.Remove(k);
                data.SaveChanges();
                LoadData();
                resetTextBox();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            action = false;
            menuDelete.Enabled = false;
            txtMaSP.ReadOnly = false;
            resetTextBox();
        }
    }
}
