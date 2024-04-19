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
    public partial class FSinhVien : Form
    {
        public FSinhVien()
        {
            InitializeComponent();
          //  lblTen.Text = HoTro.nguoiDung.HoTen;
        }

        private void container(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }

        private void btnDeTai_Click(object sender, EventArgs e)
        {
            container(new FDanhSachDeTai());
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            //FDangNhap fDangNhap = new FDangNhap();
            //fDangNhap.Show();
            this.Close();
        }

        private void btnLuanVan_Click(object sender, EventArgs e)
        {
            container(new FNhiemVu());
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            container(new FTinNhan());
        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            container(new FTinNhan());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            container(new FDanhSachDeTai());
        }
    }
}
