using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }
        public string HocLuc { get; private set; }

        public SinhVien(string hoTen, double diem)
        {
            HoTen = hoTen;
            Diem = diem;
            TinhHocLuc();
        }

        private void TinhHocLuc()
        {
            // Sử dụng if-else if theo hướng dẫn trong đề bài
            if (Diem >= 9)
            {
                HocLuc = "Xuất sắc";
            }
            else if (Diem >= 7.5)
            {
                HocLuc = "Giỏi";
            }
            else if (Diem >= 6.5)
            {
                HocLuc = "Khá";
            }
            else if (Diem >= 5)
            {
                HocLuc = "Trung bình";
            }
            else
            {
                HocLuc = "Yếu";
            }
        }

        public override string ToString()
        {
            // Cú pháp: string.Format(chuỗi_định_dạng, đối_số_0, đối_số_1, ...)
            return string.Format(
                "Họ tên: {0,-15} | Điểm: {1,-5:F2} | Học lực: {2}",
                HoTen, // {0}
                Diem,  // {1} - Áp dụng định dạng ,-5:F2
                HocLuc // {2}
            );
        }
    }
}
