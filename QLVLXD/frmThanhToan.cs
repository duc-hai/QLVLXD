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
    public partial class frmThanhToan : Form
    {
        VLXDEntities1 data = new VLXDEntities1();
        bool action = false;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            txtNgayPhieu.Format = DateTimePickerFormat.Custom;
            txtNgayPhieu.CustomFormat = "dd/MM/yyyy";
            getKhachHang();
            LoadData();
        }

        private void getKhachHang ()
        {
            //cboKhachHang.DisplayMember = "TENKHACH";
            cboKhachHang.DisplayMember = "MAKHACH";
            cboKhachHang.ValueMember = "MAKHACH";
            cboKhachHang.DataSource = data.KHACH.ToList();
        }

        private void LoadData () {
            int i = 0;
            List<THANHTOAN> lst = data.THANHTOAN.ToList();
            var columns = from t in lst
                          orderby t.SOPHIEU
                          select new
                          {
                              No = ++i,
                              SoPhieu = t.SOPHIEU,
                              NgayPhieu = t.NGAYPHIEU,
                              SoTien = t.SOTIEN,
                              MaKhach = t.MAKHACH,
                          };

            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clickSaveButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickSaveButton();
        }

        private void clickSaveButton ()
        {
            try
            {
                if (action == false)
                {
                    var k = new THANHTOAN
                    {
                        SOPHIEU = txtSoPhieu.Text.Trim(),
                        NGAYPHIEU = DateTime.Parse(txtNgayPhieu.Value.ToString("MM/dd/yyyy")),
                        SOTIEN = int.Parse(txtSoTien.Text.Trim()),
                        MAKHACH = cboKhachHang.SelectedValue.ToString(),
                    };
                    data.THANHTOAN.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    txtSoPhieu.ReadOnly = false;
                    menuDelete.Enabled = false;
                    resetTextBox();
                }
                else
                {
                    //update
                    var k = data.THANHTOAN.Where(x => x.SOPHIEU == txtSoPhieu.Text.Trim()).FirstOrDefault();

                    k.NGAYPHIEU = DateTime.Parse(txtNgayPhieu.Value.ToString("MM/dd/yyyy"));
                    k.SOTIEN = int.Parse(txtSoTien.Text.Trim());
                    k.MAKHACH = cboKhachHang.SelectedValue.ToString();
                    
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
            txtSoPhieu.Focus();
            txtSoPhieu.ResetText();
            txtSoTien.ResetText();
         
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtSoPhieu.Text = r.Cells[1].Value.ToString();
                txtNgayPhieu.Value = DateTime.Parse(r.Cells[2].Value.ToString());
                txtSoTien.Text = r.Cells[3].Value.ToString();
                cboKhachHang.SelectedIndex = cboKhachHang.FindStringExact(r.Cells[4].Value.ToString());

                menuDelete.Enabled = true;
                txtSoPhieu.ReadOnly = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var k = data.THANHTOAN.Where(x => x.SOPHIEU == txtSoPhieu.Text.Trim()).FirstOrDefault();
                data.THANHTOAN.Remove(k);
                data.SaveChanges();
                LoadData();
                resetTextBox();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            menuDelete.Enabled = false;
            txtSoPhieu.ReadOnly = false;
            action = false;
            resetTextBox();
        }
    }
}
