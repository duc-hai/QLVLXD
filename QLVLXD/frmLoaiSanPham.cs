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
    public partial class frmLoaiSanPham : Form
    {
        VLXDEntities2 data = new VLXDEntities2();
        bool action = false;
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            int i = 0;
            List<LOAISANPHAM> lst = data.LOAISANPHAMs.ToList();
            var columns = from t in lst
                          orderby t.MALOAISANPHAM
                          select new
                          {
                              No = ++i,
                              MaLoaiSanPham = t.MALOAISANPHAM,
                              TenLoaiSanPham = t.TENLOAISANPHAM,
                          };
            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
        }

        private void txtM_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickButton();
        }

        public void clickButton ()
        {
            try
            {
                if (action == false)
                {
                    var k = new LOAISANPHAM
                    {
                        MALOAISANPHAM = txtMaLoaiSP.Text.Trim(),
                        TENLOAISANPHAM = txtTenLoaiSP.Text.Trim(),
                    };
                    data.LOAISANPHAMs.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    txtMaLoaiSP.ReadOnly = false;
                    menuDelete.Enabled = false;
                    resetTextBox();
                }
                else
                {
                    //update
                    var k = data.LOAISANPHAMs.Where(x => x.MALOAISANPHAM == txtMaLoaiSP.Text.Trim()).FirstOrDefault();


                    k.TENLOAISANPHAM = txtTenLoaiSP.Text.Trim();
                   
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
            txtMaLoaiSP.Focus();
            txtMaLoaiSP.ResetText();
            txtTenLoaiSP.ResetText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            clickButton();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtMaLoaiSP.Text = r.Cells[1].Value.ToString();
                txtTenLoaiSP.Text = r.Cells[2].Value.ToString();

                menuDelete.Enabled = true;
                txtMaLoaiSP.ReadOnly = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (data.SANPHAMs.Where(x => x.MALOAISANPHAM == txtMaLoaiSP.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Dữ liệu khóa ngoại bảng Sản Phẩm không hợp lệ, không thể xóa !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var k = data.LOAISANPHAMs.Where(x => x.MALOAISANPHAM == txtMaLoaiSP.Text.Trim()).FirstOrDefault();
                data.LOAISANPHAMs.Remove(k);
                data.SaveChanges();
                LoadData();
                resetTextBox();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            menuDelete.Enabled = false;
            txtMaLoaiSP.ReadOnly = false;
            resetTextBox();
            action = false;
        }
    }
}
