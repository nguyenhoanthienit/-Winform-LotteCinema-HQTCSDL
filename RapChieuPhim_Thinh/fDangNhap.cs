using RapChieuPhim_Thinh.Nhân_viên_bán_vé;
using RapChieuPhim_Thinh.Nhân_viên_quản_lý;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim_Thinh
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if (tb_DangNhap.Text == "banve" && tb_MatKhau.Text == "1" && cb_BanVe.Checked == true)
            {
                BanVe b = new Nhân_viên_bán_vé.BanVe();
                this.Close();
                b.Show();

            }
            else if (tb_DangNhap.Text == "quanly" && tb_MatKhau.Text == "1" && cb_QuanLy.Checked == true)
            {
                fQuanLy f = new Nhân_viên_quản_lý.fQuanLy();
                this.Close();
                f.Show();
            }
            else
                MessageBox.Show("Bạn vui lòng nhập đúng dữ liệu!!!");

                
        }
    }
}
