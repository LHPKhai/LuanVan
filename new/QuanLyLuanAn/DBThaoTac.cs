using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLuanAn
{
    public class DBThaoTac
    {
        private DBLuanVanEntities _context;

        public DBThaoTac(DBLuanVanEntities context)
        {
            _context = context;
        }

        // Phương thức lấy danh sách đối tượng
        public List<T> LayDanhSach<T>() where T : class
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi: hiển thị thông báo lỗi bằng MessageBox
                MessageBox.Show($"Lỗi khi lấy danh sách đối tượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Phương thức thêm đối tượng
        public void Them<T>(T entity) where T : class
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Đối tượng không được null.");
                }

                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi: hiển thị thông báo lỗi bằng MessageBox
                MessageBox.Show($"Lỗi khi thêm đối tượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức đọc đối tượng theo ID
        public T Doc<T>(int id) where T : class
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi: hiển thị thông báo lỗi bằng MessageBox
                MessageBox.Show($"Lỗi khi đọc đối tượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Phương thức cập nhật đối tượng
        public void CapNhat<T>(T entity) where T : class
        {
            try
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi: hiển thị thông báo lỗi bằng MessageBox
                MessageBox.Show($"Lỗi khi cập nhật đối tượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xóa đối tượng theo ID
        public void Xoa<T>(int id) where T : class
        {
            try
            {
                var entity = _context.Set<T>().Find(id);
                if (entity != null)
                {
                    _context.Set<T>().Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi: hiển thị thông báo lỗi bằng MessageBox
                MessageBox.Show($"Lỗi khi xóa đối tượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
