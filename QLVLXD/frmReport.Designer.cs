namespace QLVLXD
{
    partial class frmReport
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
            this.rpKhach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnListClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpKhach
            // 
            this.rpKhach.Location = new System.Drawing.Point(3, 126);
            this.rpKhach.Name = "rpKhach";
            this.rpKhach.ServerReport.BearerToken = null;
            this.rpKhach.Size = new System.Drawing.Size(796, 326);
            this.rpKhach.TabIndex = 0;
            // 
            // btnListClick
            // 
            this.btnListClick.Location = new System.Drawing.Point(293, 36);
            this.btnListClick.Name = "btnListClick";
            this.btnListClick.Size = new System.Drawing.Size(244, 23);
            this.btnListClick.TabIndex = 1;
            this.btnListClick.Text = "Xem danh sách khách hàng";
            this.btnListClick.UseVisualStyleBackColor = true;
            this.btnListClick.Click += new System.EventHandler(this.btnListClick_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListClick);
            this.Controls.Add(this.rpKhach);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpKhach;
        private System.Windows.Forms.Button btnListClick;
    }
}