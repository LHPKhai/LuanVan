//using BUS_QuanLy;
//using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanAn
{
    public partial class FDangNhap : Form
    {
        //BUS_Nguoi nguoi = new BUS_Nguoi();

        public FDangNhap()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtTenDangNhap.Text;
            //string password = txtMatKhau.Text;

            //try
            //{
            //    HoTro.nguoiDung = nguoi.LayThongTin(username, password);

            //    if (HoTro.nguoiDung != null)
            //    {
            //        Form f;
            //        if (HoTro.nguoiDung.ChucVu == "SV")
            //        {
            //            f = new FSinhVien();
            //        }
            //        else
            //        {
            //            f = new FGiangVien();
            //        }
            //        f.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Mật khẩu hoặc Tên đăng nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }    
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
