//using BUS_QuanLy;
//using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyLuanAn
{
    public partial class FDanhSachDeTai : Form
    {
        //BUS_DeTai bus_DeTai;
        //BUS_Nguoi bUS_Nguoi;
        public FDanhSachDeTai()
        {
            InitializeComponent();
            //bus_DeTai = new BUS_DeTai();
            //bUS_Nguoi = new BUS_Nguoi();
        }

        //private void LoadUCDeTai(List<DeTai> danhSachDeTai)
        //{
        //    flpDanhSachDeTai.Controls.Clear();
        //    foreach (DeTai deTai in danhSachDeTai)
        //    {
        //        UCDeTai uc = new UCDeTai(deTai);
        //        flpDanhSachDeTai.Controls.Add(uc);
        //    }
        //}

        private void FDanhSachDeTai_Load(object sender, EventArgs e)
        {
            //List<DeTai> dt;
            //if (HoTro.nguoiDung.ChucVu == "GV")
            //{
            //    dt = DeTai.ChuyenDataTableThanhList(bus_DeTai.LocDeTai(HoTro.nguoiDung.Ma, null, null, null));
            //}
            //else
            //{
            //    dt = DeTai.ChuyenDataTableThanhList(bus_DeTai.LayDanhSach());
            //}
            //LoadUCDeTai(dt); // Gọi hàm để load UC lên FlowLayoutPanel
            ////Sửa chỗ tìm kiếm mã gv thành tên gv, chưa sửa ở btn_TimKiem_Click
            //BUS_Nguoi bUS_Nguoi = new BUS_Nguoi();
            //var giangVienList = dt.Select(deTai => bUS_Nguoi.LayThongTinCaNhan(deTai.MaGV).HoTen).Distinct().ToList();
            //giangVienList.Insert(0, "Giảng viên");
            //cbGiangVien.DataSource = giangVienList;

            //var theLoaiList = dt.Select(deTai => deTai.TheLoai).Distinct().ToList();
            //theLoaiList.Insert(0, "Thể loại");
            //cbTheLoai.DataSource = theLoaiList;

            //var congNgheList = dt.Select(deTai => deTai.CongNghe).Distinct().ToList();
            //congNgheList.Insert(0, "Công nghệ");
            //cbCongNghe.DataSource = congNgheList;
            //if (HoTro.nguoiDung.ChucVu == "SV")
            //{
            //    //btnXoa.Visible = false;
            //    btnThem.Visible = false;
            //}
            //else
            //{
            //    cbGiangVien.Visible = false;
            //}
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            //HoTro.chucNang = "Thêm";
            //HoTro.deTai.TinhTrang = "Chưa đăng ký";
            //FThaoTacDeTai form = new FThaoTacDeTai();
            //form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //HoTro.chucNang = "Xóa";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //string maGV = cbGiangVien.SelectedItem?.ToString();
            //if (maGV == "Giảng viên") maGV = null;

            //string theLoai = cbTheLoai.SelectedItem?.ToString();
            //if (theLoai == "Thể loại") theLoai = null;

            //string congNghe = cbCongNghe.SelectedItem?.ToString();
            //if (congNghe == "Công nghệ") congNghe = null;

            //string soLuongSinhVienStr = cbSLsv.SelectedItem?.ToString();
            //if (soLuongSinhVienStr == "Số lượng sinh viên") soLuongSinhVienStr = null;

            //DataTable dt = bus_DeTai.LocDeTai(maGV, theLoai, congNghe, soLuongSinhVienStr);
            //LoadUCDeTai(DeTai.ChuyenDataTableThanhList(dt));
        }

        
    }
}
