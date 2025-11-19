using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class SanPham
    {
        // 1. Khai báo các trường dữ liệu là private
        private string _tenSp;
        private double _donGia;
        private double _giamGia;

        // Hàm tạo (cần cập nhật để gán vào biến private)
        public SanPham(string tenSp, double donGia, double giamGia)
        {
            this._tenSp = tenSp;
            this._donGia = donGia;
            this._giamGia = giamGia;
        }

        public SanPham(string tenSp, double donGia)
        {
            this._tenSp = tenSp;
            this._donGia = donGia;
            this._giamGia = 0;
        }

        // --- Bổ sung Getter và Setter ---

        // 2. Getter và Setter cho tenSp
        public string getTenSp()
        {
            return _tenSp;
        }

        public void setTenSp(string tenSp)
        {
            this._tenSp = tenSp;
        }

        // 2. Getter và Setter cho donGia
        public double getDonGia()
        {
            return _donGia;
        }

        // Ví dụ về logic kiểm tra trong Setter (tùy chọn)
        public void setDonGia(double donGia)
        {
            if (donGia >= 0)
            {
                this._donGia = donGia;
            }
            else
            {
                Console.WriteLine("Đơn giá không được âm!");
                // Hoặc ném ngoại lệ
            }
        }

        // 2. Getter và Setter cho giamGia
        public double getGiamGia()
        {
            return _giamGia;
        }

        public void setGiamGia(double giamGia)
        {
            this._giamGia = giamGia;
        }


        // Cập nhật phương thức tính thuế và xuất
        private double getThueNhapKhau()
        {
            // Phải dùng biến private _donGia
            return 0.1 * _donGia;
        }

        public void xuat()
        {
            Console.WriteLine("-----------------------------------");
            // Phải dùng Getter để lấy giá trị
            Console.WriteLine($"Tên sản phẩm: {getTenSp()}");
            Console.WriteLine($"Đơn giá: {getDonGia():N0} VNĐ");
            Console.WriteLine($"Giảm giá: {getGiamGia():N0} VNĐ");
            Console.WriteLine($"Thuế nhập khẩu: {getThueNhapKhau():N0} VNĐ");
            Console.WriteLine("-----------------------------------");
        }
    }
}
