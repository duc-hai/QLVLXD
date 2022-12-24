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
    public partial class frmHoaDon : Form
    {
        VLXDEntities2 data = new VLXDEntities2();
        bool action = false;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            getKhachHang();
            LoadData();
        }

        private void getKhachHang()
        {
            //cboKhach.DisplayMember = "TENKHACH";
            cboKhach.DisplayMember = "MAKHACH";
            cboKhach.ValueMember = "MAKHACH";
            cboKhach.DataSource = data.KHACHes.ToList();
        }

        private void LoadData()
        {
            int i = 0;
            List<HOADON> lst = data.HOADONs.ToList();
            var columns = from t in lst
                          orderby t.SOHD
                          select new
                          {
                              No = ++i,
                              SoHoaDon = t.SOHD,
                              NgayHoaDon = t.NGAYHD,
                              MaKhach = t.MAKHACH,
                          };

            menuDelete.Enabled = false;
            dataGridView1.DataSource = columns.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clickSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickSave();
        }

        private void clickSave ()
        {
            try
            {
                if (action == false)
                {
                    if (data.HOADONs.Where(x => x.SOHD == txtSoHoaDon.Text.Trim()).FirstOrDefault() != null)
                    {
                        MessageBox.Show("Trùng khóa chính, vui lòng thử lại", "Cảnh báo");
                        return;
                    }

                    var k = new HOADON
                    {
                        SOHD = txtSoHoaDon.Text.Trim(),
                        MAKHACH = cboKhach.SelectedValue.ToString(),
                        NGAYHD = DateTime.Parse(dtpDate.Value.ToString("MM/dd/yyyy")),
                    };
                    data.HOADONs.Add(k);
                    data.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông báo");
                    LoadData();

                    txtSoHoaDon.ReadOnly = false;
                    menuDelete.Enabled = false;
                    txtSoHoaDon.ResetText();
                }

                else
                {
                    //update
                    var k = data.HOADONs.Where(x => x.SOHD == txtSoHoaDon.Text.Trim()).FirstOrDefault();

                    //k.SOHD = txtSoHoaDon.Text.Trim();
                    k.MAKHACH = cboKhach.SelectedValue.ToString();
                    k.NGAYHD = DateTime.Parse(dtpDate.Value.ToString("MM/dd/yyyy"));
                    
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    txtSoHoaDon.ResetText();
                    data.SaveChanges();
                    LoadData();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại", "Cảnh báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                txtSoHoaDon.Text = r.Cells[1].Value.ToString();
                dtpDate.Value = DateTime.Parse(r.Cells[2].Value.ToString());
                cboKhach.SelectedIndex = cboKhach.FindStringExact(r.Cells[3].Value.ToString());

                menuDelete.Enabled = true;
                txtSoHoaDon.ReadOnly = true;
                action = true;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (data.CHITIETHOADONs.Where(x => x.MAHOADON == txtSoHoaDon.Text.Trim()).FirstOrDefault() != null)
                {
                    MessageBox.Show("Dữ liệu khóa ngoại bảng Chi Tiết Hóa Đơn không hợp lệ, không thể xóa !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var k = data.HOADONs.Where(x => x.SOHD == txtSoHoaDon.Text.Trim()).FirstOrDefault();
                data.HOADONs.Remove(k);
                data.SaveChanges();
                LoadData();
                txtSoHoaDon.ResetText();
            }
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            action = false;
            menuDelete.Enabled = false;
            txtSoHoaDon.ReadOnly = false;
            txtSoHoaDon.ResetText();
            txtSoHoaDon.Focus();
        }

        private void ttChiTietHoaDon_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon frm = new frmChiTietHoaDon();
            frm.Show();
        }
    }
}
