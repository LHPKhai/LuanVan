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
    public partial class FDKDeTai : Form
    {
        //BUS_Nhom busNhom;
        //BUS_Nguoi busNguoi;
        //BUS_DeTai bUS_DeTai;
        public FDKDeTai()
        {
            InitializeComponent();
            //busNhom = new BUS_Nhom();
            //busNguoi = new BUS_Nguoi();
            //bUS_DeTai = new BUS_DeTai();
        }

        private void FDKDeTai_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Lấy số lượng thành viên từ cơ sở dữ liệu
            //int currentMemberCount = busNhom.DemSoLuongThanhVien(HoTro.nhom.MaDeTai);

            //if (currentMemberCount >= HoTro.deTai.SoLuongSinhVien)
            //{
            //    MessageBox.Show("Đã đủ thành viên, vui lòng nhấn đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //HoTro.nhom.MaThanhVien = cbThanhVien.Text;
            //bool success = busNhom.Them(HoTro.nhom);

            //if (success)
            //{
            //    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    FDKDeTai_Load_1(sender, e);
            //}
            //else
            //{
            //    MessageBox.Show("Thành viên này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void btnTaoLai_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
               // busNhom.Xoa(HoTro.nhom.MaDeTai);
                MessageBox.Show("Thành công!");
                FDKDeTai_Load_1(sender,e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //if (HoTro.deTai.TinhTrang == "Chưa đăng ký" || HoTro.deTai.TinhTrang == "" || HoTro.deTai.TinhTrang == null)
            //{
            //    HoTro.deTai.TinhTrang = "Đã đăng ký";
            //    bUS_DeTai.Sua(HoTro.deTai);
            //    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Đề tài này đã đăng ký, mời chọn đề tài khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FDKDeTai_Load_1(object sender, EventArgs e)
        {
            //lblMoTa.Text = HoTro.deTai.MoTa;
            //lblYeuCau.Text = HoTro.deTai.YeuCau;
            //lblChucNang.Text = HoTro.deTai.ChucNang;
            //lblCongNghe.Text = HoTro.deTai.CongNghe;
            //lblTheLoai.Text = HoTro.deTai.TheLoai;
            //lblTieude.Text = HoTro.deTai.TieuDe;
            //HoTro.nhom.MaDeTai = HoTro.deTai.MaDeTai;
            //lblGV.Text = busNguoi.LayThongTinCaNhan(HoTro.deTai.MaGV).HoTen;
            //dgvThanhVien.DataSource = busNhom.LayDanhSachNhomKemTenThanhVien(HoTro.nhom.MaDeTai);
            //cbThanhVien.DataSource = busNguoi.LayDanhSachSinhVien().AsEnumerable().Select(row => row.Field<string>("Ma")).ToList();
        }
    }
}
