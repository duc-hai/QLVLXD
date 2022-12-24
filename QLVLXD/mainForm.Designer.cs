namespace QLVLXD
{
    partial class mainForm
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
            this.appointmentLabelEdit1 = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentLabelEdit1
            // 
            this.appointmentLabelEdit1.Location = new System.Drawing.Point(1018, 742);
            this.appointmentLabelEdit1.Name = "appointmentLabelEdit1";
            this.appointmentLabelEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appointmentLabelEdit1.Size = new System.Drawing.Size(100, 20);
            this.appointmentLabelEdit1.TabIndex = 3;
            // 
            // mainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(978, 756);
            this.Controls.Add(this.appointmentLabelEdit1);
            this.Name = "mainForm";
            this.Controls.SetChildIndex(this.appointmentLabelEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit appointmentLabelEdit1;
    }
}
