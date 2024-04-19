//using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BUS_QuanLy;

namespace QuanLyLuanAn
{
    public partial class UCDeTai : UserControl
    {
    //    BUS_Nguoi bUS_Nguoi;
    //    BUS_DeTai bUS_DeTai;
    //    DeTai deTaiUC;
        //public UCDeTai()
        //{
        //    InitializeComponent();
        //    bUS_Nguoi = new BUS_Nguoi();
        //    bUS_DeTai = new BUS_DeTai();
        //    if (HoTro.nguoiDung.ChucVu == "SV")
        //    {
        //        btnNhiemVu.Visible = false;
        //    }
        //}

        //public UCDeTai(DeTai deTai)
        //{
        //    HoTro.deTai = deTai;
        //    InitializeComponent();
        //    bUS_Nguoi = new BUS_Nguoi();
        //    bUS_DeTai = new BUS_DeTai();
        //    deTaiUC = deTai;
        //    lblMoTa.Text = deTai.MoTa;
        //    lblTenDeTai.Text = deTai.TieuDe;
        //    lblSoTV.Text = deTai.SoLuongSinhVien.ToString();
        //    lblTenCongNghe.Text = deTai.CongNghe;
        //    Nguoi giangVien = new Nguoi(); 
        //    giangVien = bUS_Nguoi.LayThongTinCaNhan(deTai.MaGV);
        //    lblTenGV.Text = giangVien.HoTen;
        //    if (HoTro.nguoiDung.ChucVu == "SV")
        //    {
        //        btnNhiemVu.Visible = false;
        //        btnChiTiet.Text = "Đăng ký";
        //    }
            
        //}

        //private void btnChiTiet_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void btnThemNhiemVu_Click(object sender, EventArgs e)
        //{
            
        //}
        // Thêm hàm Xóa
        //private void guna2ImageButton1_Click(object sender, EventArgs e)
        //{
        //    HoTro.chucNang = "Xóa";
        //    bUS_DeTai.Xoa(HoTro.deTai.MaDeTai);
        //    this.Hide();

        //}

        //private void btnChiTiet_Click_1(object sender, EventArgs e)
        //{
        //    HoTro.deTai = deTaiUC;
        //    if (HoTro.nguoiDung.ChucVu == "SV")
        //    {
        //        HoTro.chucNang = "Đăng ký";
        //        FDKDeTai form = new FDKDeTai();
        //        form.ShowDialog();
        //    }
        //    else
        //    {
        //        HoTro.chucNang = "Sửa";
        //        FThaoTacDeTai form = new FThaoTacDeTai(HoTro.deTai);
        //        form.ShowDialog();
        //    }
        //}

        //private void btnNhiemVu_Click(object sender, EventArgs e)
        //{
        //    HoTro.deTai = deTaiUC;
        //    if (HoTro.deTai != null)
        //    {
        //        FNhiemVu f = new FNhiemVu();
        //        f.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không thể tìm thấy đề tài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
    }
}
