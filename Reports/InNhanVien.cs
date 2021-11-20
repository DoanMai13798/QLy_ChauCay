using QuanLyChauCayCanh.Business;
using QuanLyChauCayCanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChauCayCanh.Reports
{
    public partial class InNhanVien : Form
    {
        public InNhanVien()
        {
            InitializeComponent();
        }

        private void InNhanVien_Load(object sender, EventArgs e)
        {

            List<BCTK_ChauCay> srcChauCay = BaoCaoThongKe.GetBCTKChauCay(DateTime.Now, DateTime.Now);
            RptNhanVien rptNhanVien = new RptNhanVien();
            rptNhanVien.SetDataSource(srcChauCay);
        }

        private void RptNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
