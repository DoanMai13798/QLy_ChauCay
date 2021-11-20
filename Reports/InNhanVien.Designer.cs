namespace QuanLyChauCayCanh.Reports
{
    partial class InNhanVien
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
            this.rptNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptNhanVien
            // 
            this.rptNhanVien.ActiveViewIndex = -1;
            this.rptNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNhanVien.Location = new System.Drawing.Point(0, 0);
            this.rptNhanVien.Name = "rptNhanVien";
            this.rptNhanVien.Size = new System.Drawing.Size(634, 356);
            this.rptNhanVien.TabIndex = 0;
            // 
            // InNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 356);
            this.Controls.Add(this.rptNhanVien);
            this.Name = "InNhanVien";
            this.Text = "InNhanVien";
            this.Load += new System.EventHandler(this.InNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptNhanVien;

    }
}