using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Bai2
    {
        // YÊU CẦU: Sắp xếp Tùy biến (không dùng Array.Sort())
        public static void SapXepTheoDiemTangDan(List<SinhVien> list)
        {
            int n = list.Count;
            // Thực hiện Bubble Sort
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // So sánh điểm: nếu điểm j lớn hơn điểm j+1, hoán đổi
                    if (list[j].Diem > list[j + 1].Diem)
                    {
                        // Hoán đổi (Swap)
                        SinhVien temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public static void bai2()
        {
            Console.WriteLine("\n--- BÀI 2: QUẢN LÝ SINH VIÊN (CUSTOM SORT) ---");
            // Dùng List<SinhVien> để quản lý đối tượng dễ dàng hơn mảng tên và mảng điểm riêng
            List<SinhVien> danhSachSV = new List<SinhVien>();
            int soLuong;

            Console.Write("Nhập số lượng sinh viên: ");
            if (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ.");
                return;
            }

            // NHẬP DỮ LIỆU
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\n** Nhập thông tin sinh viên thứ {i + 1}: **");
                Console.Write("  - Họ tên: ");
                string hoTen = Console.ReadLine();

                double diem;
                Console.Write("  - Điểm: ");
                while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
                {
                    Console.Write("Điểm không hợp lệ (0-10), nhập lại: ");
                }

                // Tạo đối tượng SinhVien, Học lực được tính tự động
                danhSachSV.Add(new SinhVien(hoTen, diem));
            }

            // --- 1. Xuất mảng đã nhập kèm Học lực ---
            Console.WriteLine("\n* 1. DANH SÁCH SINH VIÊN (CHƯA SẮP XẾP) *");
            foreach (var sv in danhSachSV)
            {
                Console.WriteLine(sv);
            }

            // --- 2. Sắp xếp danh sách sinh viên theo điểm tăng dần (Custom Sort) ---
            SapXepTheoDiemTangDan(danhSachSV);

            // Xuất danh sách đã sắp xếp
            Console.WriteLine("\n* 2. DANH SÁCH SINH VIÊN ĐÃ SẮP XẾP THEO ĐIỂM TĂNG DẦN *");
            foreach (var sv in danhSachSV)
            {
                Console.WriteLine(sv);
            }
        }
    }
}
