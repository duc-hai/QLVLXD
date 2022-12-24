namespace QLVLXD
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.menuDelete = new System.Windows.Forms.ToolStripButton();
            this.menuClear = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.txtNoHienTai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoDauKy = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMaKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaKhach.Location = new System.Drawing.Point(178, 58);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(150, 26);
            this.txtMaKhach.TabIndex = 3;
            this.txtMaKhach.TextChanged += new System.EventHandler(this.txtMaKhach_TextChanged);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenKhach.Location = new System.Drawing.Point(177, 102);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(150, 26);
            this.txtTenKhach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.menuDelete,
            this.menuClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(54, 24);
            this.tsbSave.Text = "Lưu ";
            this.tsbSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuDelete.Image")));
            this.menuDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(54, 24);
            this.menuDelete.Text = "Xóa ";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuClear
            // 
            this.menuClear.Image = ((System.Drawing.Image)(resources.GetObject("menuClear.Image")));
            this.menuClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(58, 24);
            this.menuClear.Text = "Clear";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(308, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.gbInformation.Controls.Add(this.txtNoHienTai);
            this.gbInformation.Controls.Add(this.label7);
            this.gbInformation.Controls.Add(this.label6);
            this.gbInformation.Controls.Add(this.txtSdt);
            this.gbInformation.Controls.Add(this.label5);
            this.gbInformation.Controls.Add(this.txtDiaChi);
            this.gbInformation.Controls.Add(this.label4);
            this.gbInformation.Controls.Add(this.txtMaKhach);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.txtTenKhach);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Controls.Add(this.txtNoDauKy);
            this.gbInformation.Controls.Add(this.btnSaveData);
            this.gbInformation.Location = new System.Drawing.Point(1, 32);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(799, 208);
            this.gbInformation.TabIndex = 9;
            this.gbInformation.TabStop = false;
            this.gbInformation.Enter += new System.EventHandler(this.gbInformation_Enter);
            // 
            // txtNoHienTai
            // 
            this.txtNoHienTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoHienTai.Location = new System.Drawing.Point(573, 148);
            this.txtNoHienTai.Name = "txtNoHienTai";
            this.txtNoHienTai.Size = new System.Drawing.Size(128, 26);
            this.txtNoHienTai.TabIndex = 14;
            this.txtNoHienTai.TextChanged += new System.EventHandler(this.txtNoHienTai_TextChanged);
            this.txtNoHienTai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoHienTai_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(446, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nợ hiện tại";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(446, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nợ đầu kỳ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSdt.Location = new System.Drawing.Point(573, 61);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(128, 26);
            this.txtSdt.TabIndex = 10;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(446, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(178, 150);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(150, 26);
            this.txtDiaChi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(68, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNoDauKy
            // 
            this.txtNoDauKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoDauKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoDauKy.Location = new System.Drawing.Point(573, 103);
            this.txtNoDauKy.Name = "txtNoDauKy";
            this.txtNoDauKy.Size = new System.Drawing.Size(128, 26);
            this.txtNoDauKy.TabIndex = 13;
            this.txtNoDauKy.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtNoDauKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDauKy_KeyPress);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(618, 102);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(8, 23);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 181);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(1, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(799, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.Name = "jsonDataSource1";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhachHang";
            this.Text = "Ngân Trâm - Đức Hải";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.TextBox txtNoHienTai;
        private System.Windows.Forms.TextBox txtNoDauKy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton menuDelete;
        private System.Windows.Forms.ToolStripButton menuClear;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
    }
}