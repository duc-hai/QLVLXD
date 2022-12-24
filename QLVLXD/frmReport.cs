using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLVLXD
{
    public partial class frmReport : Form
    {
        VLXDEntities2 data = new VLXDEntities2();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.rpKhach.RefreshReport();
            this.rpKhach.Visible = false;
        }

        private void btnListClick_Click(object sender, EventArgs e)
        {
            this.rpKhach.Visible = true;
            this.rpKhach.RefreshReport();
            List<KHACH> lst = new List<KHACH>();
            lst = data.KHACHes.ToList();
            rpKhach.LocalReport.ReportPath = "rpKhachHang.rdlc";
            ReportDataSource source = new ReportDataSource("DataSet1", lst);
            rpKhach.LocalReport.DataSources.Clear();
            rpKhach.LocalReport.DataSources.Add(source);
            this.rpKhach.RefreshReport();

        }
    }
}
