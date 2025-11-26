using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public abstract class SinhVienPoly
    {
        // 1. Thuộc tính (Properties)
        protected string hoTen;
        protected string nganh;

        // 2. Hàm tạo (Constructor)
        public SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        // 3. Phương thức trừu tượng (Abstract Method)
        // Phải được định nghĩa (override) trong các lớp con
        public abstract double getDiem();

        // 4. Phương thức bình thường (Concrete Method)
        // Dùng để xếp loại học lực dựa trên điểm lấy từ getDiem()
        public string getHocLuc()
        {
            double diem = getDiem(); // Gọi phương thức trừu tượng để lấy điểm

            if (diem < 5)
            {
                return "Yếu";
            }
            else if (diem < 6.5)
            {
                return "Trung bình";
            }
            else if (diem < 7.5)
            {
                return "Khá";
            }
            else if (diem < 9)
            {
                return "Giỏi";
            }
            else // diem >= 9
            {
                return "Xuất sắc";
            }
        }

        // 5. Phương thức xuất thông tin cơ bản
        public virtual void xuat()
        {
            Console.WriteLine("\n--- THÔNG TIN SINH VIÊN ---");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Ngành: {nganh}");
            Console.WriteLine($"Điểm: {getDiem():F2}"); // :F2 để làm tròn 2 chữ số thập phân
            Console.WriteLine($"Học lực: {getHocLuc()}");
        }
    }
}
