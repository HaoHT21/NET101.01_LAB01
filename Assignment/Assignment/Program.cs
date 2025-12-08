using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization; // Cần cho việc xử lý dấu thập phân
public class Program
{
    // Khai báo danh sách học viên dùng chung cho toàn bộ chương trình
    static List<HocVien> danhSachHV = new List<HocVien>();

    // Hàm chính
    static void Main(string[] args)
    {
        int luaChon;
        do
        {
            HienThiMenu();
            Console.Write("Mời bạn chọn chức năng (0-10): ");

            if (int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("-------------------------------------------");
                switch (luaChon)
                {
                    case 1: NhapDanhSach(); break;
                    case 2: XuatDanhSach(); break;
                    case 3: TimKiemTheoKhoangDiem(); break;
                    case 4: TimKiemTheoHocLuc(); break;
                    case 5: CapNhatThongTin(); break;
                    case 6: SapXepTheoDiem(); break;
                    case 7: XuatTop5DiemCaoNhat(); break;
                    case 8: TinhDiemTrungBinh(); break;
                    case 9: XuatTrenTrungBinh(); break;
                    case 10: TongHopHocLuc(); break;
                    case 0: ThoatChuongTrinh(); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại."); break;
                }
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số.");
                luaChon = -1;
            }
            Console.WriteLine();
        } while (luaChon != 0);
    }

    // --------------------------------------------------------------------------------
    // --- KHAI BÁO CÁC HÀM PHỤ TRỢ (HELPER METHODS) ---
    // --------------------------------------------------------------------------------

    static bool KiemTraEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    static bool KiemTraTrungTen(string hoTen)
    {
        return danhSachHV.Any(hv => hv.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase));
    }

    static bool KiemTraDiem(string input, out float diem)
    {
        // Thay thế dấu phẩy bằng dấu chấm để đảm bảo TryParse hoạt động đúng với InvariantCulture
        if (float.TryParse(input.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out diem))
        {
            return diem >= 0 && diem <= 10;
        }
        diem = -1;
        return false;
    }

    static void InThongTinHocVien(HocVien hv, int index)
    {
        Console.WriteLine($"| {index,-3} | {hv.HoTen,-25} | {hv.Diem,-6:F2} | {hv.HocLuc,-15} | {hv.Email,-30} |");
    }

    static void HienThiMenu()
    {
        Console.WriteLine("\n========== MENU QUẢN LÝ HỌC VIÊN (C#) ==========");
        Console.WriteLine("1. Nhập danh sách học viên (Y01)");
        Console.WriteLine("2. Xuất danh sách học viên (Y02)");
        Console.WriteLine("3. Tìm kiếm học viên theo khoảng điểm (Y03)");
        Console.WriteLine("4. Tìm kiếm học viên theo học lực (Y04)");
        Console.WriteLine("5. Tìm kiếm theo mã số và cập nhật thông tin (Y05)");
        Console.WriteLine("6. Sắp xếp học viên theo điểm (Y06)");
        Console.WriteLine("7. Xuất 5 học viên có điểm cao nhất (Y07)");
        Console.WriteLine("8. Tính điểm trung bình của lớp (Y08)");
        Console.WriteLine("9. Xuất danh sách học viên có điểm trên trung bình (Y09)");
        Console.WriteLine("10. Tổng hợp số học viên theo học lực (Y10)");
        Console.WriteLine("0. Thoát chương trình");
        Console.WriteLine("------------------------------------------");
    }

    static void ThoatChuongTrinh()
    {
        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
    }


    // --------------------------------------------------------------------------------
    // --- ĐỊNH NGHĨA CÁC HÀM CHỨC NĂNG (Y01 - Y10) ---
    // --------------------------------------------------------------------------------

    // Y01: Nhập danh sách học viên
    static void NhapDanhSach()
    {
        Console.WriteLine("\n[1] Nhập danh sách học viên (Nhập 'q' để dừng)");
        string hoTen;
        float diem;
        string email;
        int count = 0;

        while (true)
        {
            Console.WriteLine($"--- Nhập Học Viên thứ {danhSachHV.Count + 1} ---");

            // Nhập Họ Tên
            Console.Write("Nhập Họ Tên (Nhập 'q' để dừng): ");
            hoTen = Console.ReadLine().Trim();
            if (hoTen.ToLower() == "q") break;

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                Console.WriteLine("Lỗi: Họ tên không được để trống.");
                continue;
            }
            if (KiemTraTrungTen(hoTen))
            {
                Console.WriteLine("Lỗi: Họ tên này đã tồn tại trong danh sách.");
                continue;
            }

            // Nhập Điểm
            string diemInput;
            do
            {
                Console.Write("Nhập Điểm (0-10): ");
                diemInput = Console.ReadLine();
                if (!KiemTraDiem(diemInput, out diem))
                {
                    Console.WriteLine("Lỗi: Điểm phải là số thực từ 0 đến 10.");
                }
            } while (!KiemTraDiem(diemInput, out diem));

            // Nhập Email
            do
            {
                Console.Write("Nhập Email: ");
                email = Console.ReadLine().Trim();
                if (!KiemTraEmail(email))
                {
                    Console.WriteLine("Lỗi: Email phải đúng định dạng (có @ và .).");
                }
            } while (!KiemTraEmail(email));

            // Thêm học viên mới
            danhSachHV.Add(new HocVien { HoTen = hoTen, Diem = diem, Email = email });
            count++;
            Console.WriteLine("Đã thêm học viên thành công!");
        }
        Console.WriteLine($"Đã kết thúc nhập liệu. Tổng số học viên mới được thêm: {count}.");
    }

    // Y02: Xuất danh sách học viên
    static void XuatDanhSach()
    {
        Console.WriteLine("\n[2] Danh sách Học viên");
        if (!danhSachHV.Any())
        {
            Console.WriteLine("Danh sách rỗng. Vui lòng nhập dữ liệu trước (Chức năng 1).");
            return;
        }

        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine("| ID  | Họ Tên                    | Điểm   | Học Lực         | Email                          |");
        Console.WriteLine("----------------------------------------------------------------------------------------");

        for (int i = 0; i < danhSachHV.Count; i++)
        {
            InThongTinHocVien(danhSachHV[i], i + 1);
        }
        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine($"Tổng số học viên: {danhSachHV.Count}");
    }

    // Y03: Tìm kiếm học viên theo khoảng điểm
    static void TimKiemTheoKhoangDiem()
    {
        Console.WriteLine("\n[3] Tìm kiếm học viên theo khoảng điểm");
        if (!danhSachHV.Any()) return;

        float minDiem, maxDiem;

        do { Console.Write("Nhập điểm tối thiểu (0-10): "); }
        while (!KiemTraDiem(Console.ReadLine(), out minDiem));

        do { Console.Write("Nhập điểm tối đa (0-10): "); }
        while (!KiemTraDiem(Console.ReadLine(), out maxDiem));

        if (minDiem > maxDiem)
        {
            Console.WriteLine("Lỗi: Điểm tối thiểu không thể lớn hơn điểm tối đa.");
            return;
        }

        var ketQua = danhSachHV
                        .Where(hv => hv.Diem >= minDiem && hv.Diem <= maxDiem)
                        .ToList();

        if (ketQua.Any())
        {
            Console.WriteLine($"\nKết quả tìm kiếm ({minDiem:F2} - {maxDiem:F2}):");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("| ID  | Họ Tên                    | Điểm   | Học Lực         | Email                          |");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach (var hv in ketQua)
            {
                int index = danhSachHV.IndexOf(hv);
                InThongTinHocVien(hv, index + 1);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy học viên nào có điểm từ {minDiem:F2} đến {maxDiem:F2}.");
        }
    }

    // Y04: Tìm kiếm học viên theo học lực
    static void TimKiemTheoHocLuc()
    {
        Console.WriteLine("\n[4] Tìm kiếm học viên theo học lực");
        if (!danhSachHV.Any()) return;

        Console.Write("Nhập Học Lực cần tìm (Yếu/Trung bình/Khá/Giỏi/Xuất sắc): ");
        string hocLucTimKiem = Console.ReadLine().Trim();

        var ketQua = danhSachHV
                        .Where(hv => hv.HocLuc.Equals(hocLucTimKiem, StringComparison.OrdinalIgnoreCase))
                        .ToList();

        if (ketQua.Any())
        {
            Console.WriteLine($"\nKết quả tìm kiếm theo Học Lực '{hocLucTimKiem}':");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("| ID  | Họ Tên                    | Điểm   | Học Lực         | Email                          |");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach (var hv in ketQua)
            {
                int index = danhSachHV.IndexOf(hv);
                InThongTinHocVien(hv, index + 1);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy học viên nào có học lực '{hocLucTimKiem}'.");
        }
    }

    // Y05: Tìm kiếm học viên theo mã số và cập nhật thông tin
    static void CapNhatThongTin()
    {
        Console.WriteLine("\n[5] Cập nhật thông tin học viên");
        if (!danhSachHV.Any()) return;

        Console.Write("Nhập mã số (ID) học viên cần cập nhật: ");
        if (!int.TryParse(Console.ReadLine(), out int id) || id < 1 || id > danhSachHV.Count)
        {
            Console.WriteLine("Mã số không hợp lệ.");
            return;
        }

        int index = id - 1;
        HocVien hvCanCapNhat = danhSachHV[index];
        Console.WriteLine($"--- Thông tin cũ của HV ID {id}:");
        InThongTinHocVien(hvCanCapNhat, id);

        Console.WriteLine("\n--- Nhập thông tin mới (Để trống nếu không muốn thay đổi) ---");

        // Cập nhật Họ Tên
        string newHoTen;
        while (true)
        {
            Console.Write($"Nhập Họ Tên mới ({hvCanCapNhat.HoTen}): ");
            newHoTen = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(newHoTen))
            {
                newHoTen = hvCanCapNhat.HoTen; break;
            }
            if (newHoTen.Equals(hvCanCapNhat.HoTen, StringComparison.OrdinalIgnoreCase)) break;
            if (KiemTraTrungTen(newHoTen))
            {
                Console.WriteLine("Lỗi: Họ tên này đã tồn tại trong danh sách. Vui lòng nhập tên khác.");
                continue;
            }
            break;
        }
        hvCanCapNhat.HoTen = newHoTen;

        // Cập nhật Điểm
        float newDiem;
        while (true)
        {
            Console.Write($"Nhập Điểm mới ({hvCanCapNhat.Diem:F2}): ");
            string diemInput = Console.ReadLine();
            if (string.IsNullOrEmpty(diemInput))
            {
                newDiem = hvCanCapNhat.Diem; break;
            }
            if (KiemTraDiem(diemInput, out newDiem)) break;

            Console.WriteLine("Lỗi: Điểm phải là số thực từ 0 đến 10.");
        }
        hvCanCapNhat.Diem = newDiem;

        // Cập nhật Email
        string newEmail;
        while (true)
        {
            Console.Write($"Nhập Email mới ({hvCanCapNhat.Email}): ");
            newEmail = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(newEmail))
            {
                newEmail = hvCanCapNhat.Email; break;
            }
            if (KiemTraEmail(newEmail)) break;

            Console.WriteLine("Lỗi: Email phải đúng định dạng (có @ và .).");
        }
        hvCanCapNhat.Email = newEmail;

        Console.WriteLine("\n*** Cập nhật thành công! ***");
        Console.WriteLine($"--- Thông tin mới của HV ID {id}:");
        InThongTinHocVien(hvCanCapNhat, id);
    }

    // Y06: Sắp xếp học viên theo điểm
    static void SapXepTheoDiem()
    {
        Console.WriteLine("\n[6] Sắp xếp học viên theo điểm (Giảm dần)");
        if (!danhSachHV.Any()) return;

        danhSachHV = danhSachHV.OrderByDescending(hv => hv.Diem).ToList();

        Console.WriteLine("Danh sách đã được sắp xếp:");
        XuatDanhSach();
    }

    // Y07: Xuất 5 học viên có điểm cao nhất
    static void XuatTop5DiemCaoNhat()
    {
        Console.WriteLine("\n[7] Xuất 5 học viên có điểm cao nhất");
        if (!danhSachHV.Any()) return;

        var top5 = danhSachHV
                    .OrderByDescending(hv => hv.Diem)
                    .Take(5)
                    .ToList();

        Console.WriteLine("--- TOP 5 HỌC VIÊN ĐIỂM CAO NHẤT ---");
        Console.WriteLine("| STT | Họ Tên                    | Điểm   | Học Lực         | Email                          |");
        Console.WriteLine("----------------------------------------------------------------------------------------");

        for (int i = 0; i < top5.Count; i++)
        {
            // Tìm index của học viên trong danh sách gốc để hiển thị ID/Vị trí
            InThongTinHocVien(top5[i], i + 1);
        }
        Console.WriteLine("----------------------------------------------------------------------------------------");
    }

    // Y08: Tính điểm trung bình của lớp
    static void TinhDiemTrungBinh()
    {
        if (!danhSachHV.Any())
        {
            Console.WriteLine("\n[8] Điểm trung bình của lớp là: **0.00**");
            return;
        }

        float diemTB = danhSachHV.Average(hv => hv.Diem);
        Console.WriteLine($"\n[8] Điểm trung bình của lớp là: **{diemTB:F2}**");
    }

    // Y09: Xuất danh sách học viên có điểm trên trung bình
    static void XuatTrenTrungBinh()
    {
        Console.WriteLine("\n[9] Học viên có điểm trên trung bình");
        if (!danhSachHV.Any())
        {
            Console.WriteLine("Danh sách rỗng.");
            return;
        }

        float diemTB = danhSachHV.Average(hv => hv.Diem);
        Console.WriteLine($"Điểm trung bình của lớp: {diemTB:F2}");

        var ketQua = danhSachHV
                        .Where(hv => hv.Diem > diemTB)
                        .ToList();

        if (ketQua.Any())
        {
            Console.WriteLine($"\n**Danh sách {ketQua.Count} học viên có điểm trên trung bình:**");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("| ID  | Họ Tên                    | Điểm   | Học Lực         | Email                          |");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach (var hv in ketQua)
            {
                int index = danhSachHV.IndexOf(hv);
                InThongTinHocVien(hv, index + 1);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("Không có học viên nào có điểm cao hơn điểm trung bình lớp.");
        }
    }

    // Y10: Tổng hợp số học viên theo học lực
    static void TongHopHocLuc()
    {
        Console.WriteLine("\n[10] Tổng hợp số học viên theo học lực");
        if (!danhSachHV.Any()) return;

        var thongKe = danhSachHV
                        .GroupBy(hv => hv.HocLuc)
                        .Select(g => new { HocLuc = g.Key, SoLuong = g.Count() })
                        .ToList();

        Console.WriteLine("--- THỐNG KÊ HỌC LỰC ---");
        Console.WriteLine("| Học Lực         | Số Lượng |");
        Console.WriteLine("---------------------------");

        string[] order = { "Yếu", "Trung bình", "Khá", "Giỏi", "Xuất sắc" };

        foreach (var level in order)
        {
            var item = thongKe.FirstOrDefault(t => t.HocLuc == level);
            int count = (item != null) ? item.SoLuong : 0;
            Console.WriteLine($"| {level,-15} | {count,-8} |");
        }
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Tổng số: {danhSachHV.Count}");
    }
}