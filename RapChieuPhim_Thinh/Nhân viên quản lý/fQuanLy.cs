using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim_Thinh.Nhân_viên_quản_lý
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }

        private void fQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }
    }
}
