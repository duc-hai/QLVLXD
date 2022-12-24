using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVLXD
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        VLXDEntities2 data = new VLXDEntities2();
        bool action = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            int i = 0;
            List<KHACH> lstKhach = data.KHACHes.ToList();
            var columns = from t in lstKhach
                          orderby t.MAKHACH
                          select new
                          {
                              No = ++i,
                              MaKhach = t.MAKHACH,
                              TenKhach = t.TENKHACH,
                              DiaChi = t.DIACHI,
                              SoDienThoai = t.SODIENTHOAI,
                              NoDauKy = t.NODAUKY,
                              NoHienTai = t.NOHIENTAI,

                          };

            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
            gcListKhachHang.DataSource = columns.ToList();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            clickButton();
        }

        private void clickButton ()
        {
            try
            {
                if (action == false)
                {
                    //insert
                    if (data.KHACHes.Where(x => x.MAKHACH == txtMaKhach.Text.Trim()).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Trùng khóa chính, vui lòng thử lại", "Cảnh báo");
                        return;
                    }

                    var k = new KHACH
                    {
                        MAKHACH = txtMaKhach.Text.Trim(),
                        TENKHACH = txtTenKhach.Text.Trim(),
                        DIACHI = txtDiaChi.Text.Trim(),
                        SODIENTHOAI = txtSdt.Text.Trim(),
                        NODAUKY = int.Parse(txtNoDauKy.Text.Trim()),
                        NOHIENTAI = int.Parse(txtNoHienTai.Text.Trim()),
                    };
                    data.KHACHes.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    txtMaKhach.ReadOnly = false;
                    menuDelete.Enabled = false;
                    resetTextBox();
                }
                else
                {
                    //update
                    var k = data.KHACHes.Where(x => x.MAKHACH == txtMaKhach.Text.Trim()).FirstOrDefault();

                    k.TENKHACH = txtTenKhach.Text.Trim();
                    k.DIACHI = txtDiaChi.Text.Trim();
                    k.SODIENTHOAI = txtSdt.Text.Trim();
                    k.NODAUKY = int.Parse(txtNoDauKy.Text.Trim());
                    k.NOHIENTAI = int.Parse(txtNoHienTai.Text.Trim());

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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clickButton();
        }

        private void resetTextBox ()
        {
            txtMaKhach.Focus();
            txtMaKhach.ResetText();
            txtTenKhach.ResetText();
            txtDiaChi.ResetText();
            txtSdt.ResetText();
            txtNoDauKy.ResetText();
            txtNoHienTai.ResetText();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoHienTai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNoDauKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtMaKhach.Text = r.Cells[1].Value.ToString();
                txtTenKhach.Text = r.Cells[2].Value.ToString();
                txtDiaChi.Text = r.Cells[3].Value.ToString();
                txtSdt.Text = r.Cells[4].Value.ToString();
                txtNoDauKy.Text = r.Cells[5].Value.ToString();
                txtNoHienTai.Text = r.Cells[6].Value.ToString();

                menuDelete.Enabled = true;
                txtMaKhach.ReadOnly = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (data.HOADONs.Where(x => x.MAKHACH == txtMaKhach.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Dữ liệu khóa ngoại bảng Hóa Đơn không hợp lệ, không thể xóa !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (data.THANHTOANs.Where(x => x.MAKHACH == txtMaKhach.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Dữ liệu khóa ngoại bảng Thanh Toán không hợp lệ, không thể xóa !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var k = data.KHACHes.Where(x => x.MAKHACH == txtMaKhach.Text.Trim()).FirstOrDefault();
                data.KHACHes.Remove(k);
                data.SaveChanges();
                LoadData();
                resetTextBox();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            menuDelete.Enabled = false;
            txtMaKhach.ReadOnly = false;
            action = false;
            resetTextBox();
        }

        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gbInformation_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNoHienTai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
