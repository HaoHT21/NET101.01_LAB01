using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab05
{
    internal class Program
    {
        private static List<SinhVienPoly> danhSach = new List<SinhVienPoly>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // =======================================================
            // I. BÀI 1: HÌNH CHỮ NHẬT & HÌNH VUÔNG (Yêu cầu nhập liệu)
            // =======================================================
            Console.WriteLine("=========== BÀI 1: HÌNH HỌC ============");

            try
            {
                Console.Write("Nhập chiều dài hình chữ nhật: ");
                double dai = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập chiều rộng hình chữ nhật: ");
                double rong = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập cạnh hình vuông: ");
                double canh = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n==================================");

                // Đối tượng Hình chữ nhật
                ChuNhat cn = new ChuNhat(dai, rong);
                cn.xuat();

                // Đối tượng Hình vuông (Đa hình)
                ChuNhat vu = new Vuong(canh);
                vu.xuat();

                Console.WriteLine("==================================");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Đầu vào không phải là số hợp lệ. Bỏ qua Bài 1.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để chuyển sang Bài 3 & Bài 4...");
            Console.ReadKey();
            Console.Clear();

            // =======================================================
            // II. BÀI 3: KIỂM TRA ĐA HÌNH VÀ TÍNH TOÁN ĐIỂM
            // =======================================================
            Console.WriteLine("============== BÀI 3: KIỂM TRA ĐA HÌNH ===================");

            // Tạo và kiểm tra SinhVienIT
            SinhVienPoly svIT = new SinhVienIT("Nguyễn Văn A", 9.5, 8.0, 8.5); // 3 điểm IT
            svIT.xuat();

            // Tạo và kiểm tra SinhVienBiz
            SinhVienPoly svBiz = new SinhVienBiz("Trần Thị B", 5.0, 7.0); // 2 điểm Biz
            svBiz.xuat();

            Console.WriteLine("\n==========================================================");
            Console.WriteLine("Nhấn phím bất kỳ để chuyển sang Menu Bài 4...");
            Console.ReadKey();

            // =======================================================
            // III. BÀI 4: CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN (Menu)
            // =======================================================
            Menu();
        }

        // --- Các phương thức của Bài 4 (Menu, Nhap, Xuat, SVGioi, SapXep) ---

        public static void Menu()
        {
            int chon;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|       CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN (BÀI 4)  |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("| 1. Nhập danh sách sinh viên                   |");
                Console.WriteLine("| 2. Xuất thông tin danh sách sinh viên         |");
                Console.WriteLine("| 3. Xuất danh sách sinh viên có học lực Giỏi   |");
                Console.WriteLine("| 4. Sắp xếp danh sách sinh viên theo điểm      |");
                Console.WriteLine("| 5. Kết thúc                                   |");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Mời bạn chọn chức năng (1-5): ");

                if (int.TryParse(Console.ReadLine(), out chon))
                {
                    switch (chon)
                    {
                        case 1: Nhap(danhSach); break;
                        case 2: Xuat(danhSach); break;
                        case 3: SVGioi(danhSach); break;
                        case 4: SapXep(danhSach); break;
                        case 5: Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!"); break;
                        default: Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập số.");
                    chon = 0;
                }

                if (chon != 5)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (chon != 5);
        }

        // Phương thức Nhap() (Đã được kiểm tra và chỉnh sửa lỗi Try-Catch)
        public static void Nhap(List<SinhVienPoly> ds)
        {
            Console.WriteLine("\n--- NHẬP DANH SÁCH SINH VIÊN ---");
            // ... (Code Nhap(), Xuat(), SVGioi(), SapXep() giống như bạn đã cung cấp)
            while (true)
            {
                Console.Write("Chọn loại sinh viên (1: IT, 2: Biz, 0: Dừng nhập): ");
                string loai = Console.ReadLine();
                if (loai == "0") break;

                Console.Write("Nhập họ tên: ");
                string hoTen = Console.ReadLine();

                if (loai == "1") // SinhVienIT
                {
                    try
                    {
                        Console.Write("Điểm Java: "); double diemJava = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm Html: "); double diemHtml = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm Css: "); double diemCss = Convert.ToDouble(Console.ReadLine());
                        ds.Add(new SinhVienIT(hoTen, diemJava, diemHtml, diemCss));
                        Console.WriteLine("-> Thêm sinh viên IT thành công.");
                    }
                    catch (FormatException) { Console.WriteLine("Lỗi: Điểm phải là số."); }
                }
                else if (loai == "2") // SinhVienBiz
                {
                    try
                    {
                        Console.Write("Điểm Marketing: "); double diemMarketing = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm Sales: "); double diemSales = Convert.ToDouble(Console.ReadLine());
                        ds.Add(new SinhVienBiz(hoTen, diemMarketing, diemSales));
                        Console.WriteLine("-> Thêm sinh viên Biz thành công.");
                    }
                    catch (FormatException) { Console.WriteLine("Lỗi: Điểm phải là số."); }
                }
                else
                {
                    Console.WriteLine("Lựa chọn loại sinh viên không hợp lệ.");
                }
            }
        }

        // Phương thức Xuat()
        public static void Xuat(List<SinhVienPoly> ds)
        {
            Console.WriteLine("\n--- XUẤT DANH SÁCH SINH VIÊN ---");
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng. Vui lòng nhập sinh viên trước.");
                return;
            }
            foreach (SinhVienPoly sv in ds)
            {
                sv.xuat();
                Console.WriteLine("---------------------------------");
            }
        }

        // Phương thức SVGioi()
        public static void SVGioi(List<SinhVienPoly> ds)
        {
            Console.WriteLine("\n--- DANH SÁCH SINH VIÊN HỌC LỰC GIỎI ---");
            if (ds.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            var svGioi = ds.Where(sv => sv.getHocLuc() == "Giỏi" || sv.getHocLuc() == "Xuất sắc").ToList();

            if (svGioi.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào đạt học lực Giỏi hoặc Xuất sắc.");
                return;
            }

            foreach (SinhVienPoly sv in svGioi)
            {
                sv.xuat();
                Console.WriteLine("---------------------------------");
            }
        }

        // Phương thức SapXep()
        public static void SapXep(List<SinhVienPoly> ds)
        {
            Console.WriteLine("\n--- SẮP XẾP DANH SÁCH SINH VIÊN THEO ĐIỂM (GIẢM DẦN) ---");
            if (ds.Count <= 1)
            {
                Console.WriteLine("Danh sách không đủ để sắp xếp.");
                return;
            }

            var dsSapXep = ds.OrderByDescending(sv => sv.getDiem()).ToList();

            ds.Clear();
            ds.AddRange(dsSapXep);

            Console.WriteLine("Danh sách đã được sắp xếp:");
            Xuat(ds);
        }
    }
}