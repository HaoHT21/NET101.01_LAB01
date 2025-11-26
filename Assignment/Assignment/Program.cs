using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static List<HocVien> danhSachHV = new List<HocVien>();
        static void Main(string[] args)
            
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luaChon;
            do
            {
                HienThiMenu();
                Console.Write("Mời bạn chọn chức năng (0-10): ");
                // Xử lý đầu vào: nếu người dùng nhập không phải số, dùng TryParse hoặc bắt ngoại lệ
                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("-------------------------------------------");
                    switch (luaChon)
                    {
                        case 1: NhapDanhSach(); break;      // Y01
                        case 2: XuatDanhSach(); break;      // Y02
                        case 3: TimKiemTheoKhoangDiem(); break; // Y03
                        case 4: TimKiemTheoHocLuc(); break;     // Y04
                        case 5: CapNhatThongTin(); break;       // Y05
                        case 6: SapXepTheoDiem(); break;        // Y06
                        case 7: XuatTop5DiemCaoNhat(); break;   // Y07
                        case 8: TinhDiemTrungBinh(); break;     // Y08
                        case 9: XuatTrenTrungBinh(); break;     // Y09
                        case 10: TongHopHocLuc(); break;        // Y10
                        case 0: ThoatChuongTrinh(); break;
                        default: Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số.");
                    luaChon = -1; // Đảm bảo vòng lặp tiếp tục
                }
                Console.WriteLine();
            } while (luaChon != 0);

        }
        static void HienThiMenu()
        {
            Console.WriteLine("\n========== MENU QUẢN LÝ HỌC VIÊN (C#) ==========");
            Console.WriteLine("1. Nhập danh sách học viên ");
            Console.WriteLine("2. Xuất danh sách học viên ");
            Console.WriteLine("3. Tìm kiếm học viên theo khoảng điểm ");
            Console.WriteLine("4. Tìm kiếm học viên theo học lực (Y04)");
            Console.WriteLine("5. Tìm kiếm theo mã số và cập nhật thông tin");
            Console.WriteLine("6. Sắp xếp học viên theo điểm");
            Console.WriteLine("7. Xuất 5 học viên có điểm cao nhất");
            Console.WriteLine("8. Tính điểm trung bình của lớp");
            Console.WriteLine("9. Xuất danh sách học viên có điểm trên trung bình");
            Console.WriteLine("10. Tổng hợp số học viên theo học lực");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("------------------------------------------");
        }

        static void NhapDanhSach()
        {
            Console.WriteLine("Đã chọn: [1] Nhập danh sách học viên. (Tiếp tục code Y01 ở GĐ2)");
        }

        static void XuatDanhSach()
        {
            Console.WriteLine("Đã chọn: [2] Xuất danh sách học viên. (Tiếp tục code Y02 ở GĐ2)");
        }

        static void TimKiemTheoKhoangDiem()
        {
            Console.WriteLine("Đã chọn: [3] Tìm kiếm học viên theo khoảng điểm. (Tiếp tục code Y03 ở GĐ2)");
        }

        static void TimKiemTheoHocLuc()
        {
            Console.WriteLine("Đã chọn: [4] Tìm kiếm học viên theo học lực. (Tiếp tục code Y04 ở GĐ2)");
        }

        static void CapNhatThongTin()
        {
            Console.WriteLine("Đã chọn: [5] Tìm kiếm theo mã số và cập nhật thông tin. (Tiếp tục code Y05 ở GĐ2)");
        }

        static void SapXepTheoDiem()
        {
            Console.WriteLine("Đã chọn: [6] Sắp xếp học viên theo điểm. (Tiếp tục code Y06 ở GĐ2)");
        }

        static void XuatTop5DiemCaoNhat()
        {
            Console.WriteLine("Đã chọn: [7] Xuất 5 học viên có điểm cao nhất. (Tiếp tục code Y07 ở GĐ2)");
        }

        static void TinhDiemTrungBinh()
        {
            Console.WriteLine("Đã chọn: [8] Tính điểm trung bình của lớp. (Tiếp tục code Y08 ở GĐ2)");
        }

        static void XuatTrenTrungBinh()
        {
            Console.WriteLine("Đã chọn: [9] Xuất danh sách học viên có điểm trên trung bình. (Tiếp tục code Y09 ở GĐ2)");
        }

        static void TongHopHocLuc()
        {
            Console.WriteLine("Đã chọn: [10] Tổng hợp số học viên theo học lực. (Tiếp tục code Y10 ở GĐ2)");
        }

        static void ThoatChuongTrinh()
        {
            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
        }
    }
}
