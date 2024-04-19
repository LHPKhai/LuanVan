//using BUS_QuanLy;
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

namespace QuanLyLuanAn
{
    public partial class UCThaoTacDeTai : UserControl
    {
       // BUS_DeTai deTai = new BUS_DeTai();
        public UCThaoTacDeTai()
        {
            InitializeComponent();
        }

        //public UCThaoTacDeTai(//DeTai dt)
        //{
        //    InitializeComponent();
        //    txtmota.text = dt.mota;
        //    txtyeucau.text = dt.yeucau;
        //    txtchucnang.text = dt.chucnang;
        //    cbsoluongsv.text = dt.soluongsinhvien.tostring();
        //    txtcongnghe.text = dt.congnghe;
        //    txttheloai.text = dt.theloai;
        //    txttieude.text = dt.tieude;
        //}

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            //HoTro.deTai.MoTa = txtMota.Text;
            //HoTro.deTai.YeuCau = txtYeucau.Text;
            //HoTro.deTai.ChucNang = txtChucnang.Text;
            //HoTro.deTai.SoLuongSinhVien = int.Parse(cbSoluongSV.Text);
            //HoTro.deTai.CongNghe = txtCongnghe.Text;
            //HoTro.deTai.TheLoai = txtTheLoai.Text;
            //HoTro.deTai.TieuDe = txtTieude.Text;
            //HoTro.deTai.MaGV = HoTro.nguoiDung.Ma;
            //if (HoTro.chucNang == "Thêm")
            //{
            //    if (deTai.Them(HoTro.deTai) == false)
            //        MessageBox.Show("Không thể thêm");
            //}
            //else
            //{
            //    if (deTai.Sua(HoTro.deTai) == false)
            //        MessageBox.Show("Không thể cập nhật");
            //}
            //this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMota.Text = string.Empty;
            txtYeucau.Text = string.Empty;
            txtChucnang.Text = string.Empty;
            cbSoluongSV.Text = string.Empty;
            txtCongnghe.Text = string.Empty;
            txtTheLoai.Text = string.Empty;
            txtTieude.Text = string.Empty;
        }
    }
}
