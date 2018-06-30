using RapChieuPhim_Thinh.Nhân_viên_bán_vé;
using RapChieuPhim_Thinh.Nhân_viên_quản_lý;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim_Thinh
{
    public partial class fDangNhap : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        public fDangNhap()
        {
            InitializeComponent();
            groupBox1.Hide();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            _connection = Connection.ConnectionData();

            string sql =
                @"SELECT * FROM NhanVien";
            _command = new SqlCommand(sql, _connection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = _command;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            _connection.Close();

            string role = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (tb_DangNhap.Text == "" || tb_MatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản !");
                    return;
                }
                else if (tb_DangNhap.Text == dt.Rows[i][0].ToString() && tb_MatKhau.Text == dt.Rows[i][1].ToString())
                {
                    role = dt.Rows[i][2].ToString();
                    if (role == "Quản lý")
                    {
                        fQuanLy f = new fQuanLy();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        BanVe f = new BanVe();
                        f.Show();
                        this.Hide();
                    }
                }
            } 
        }

        private void fDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
