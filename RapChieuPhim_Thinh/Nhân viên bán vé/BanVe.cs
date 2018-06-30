using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim_Thinh.Nhân_viên_bán_vé
{
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKhachHang t = new ThemKhachHang();
            this.Hide();
            t.ShowDialog();
            t.Show();
        }

        private void BanVe_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }
    }
}
