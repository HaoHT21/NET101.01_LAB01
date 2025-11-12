using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Bai3
    {
        public static void bai3()
        {
            Console.WriteLine("--- Xu ly thong tin ngay, thang, nam ---");

            int ngay, thang, nam;

            // 1. Nhap du lieu
            Console.Write("Nhap ngay: ");
            ngay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------");

            // 2. Kiem tra tinh hop le cua ngay, thang nhap
            try
            {
                DateTime ngayNhap = new DateTime(nam, thang, ngay);
                Console.WriteLine($"Ngay vua nhap ({ngayNhap.ToShortDateString()}) la **hop le**.");
                Console.WriteLine("---------------------------------------");

                // 3. Cho biet thang nhap co bao nhieu ngay
                // DateTime.DaysInMonth(nam, thang) tra ve so ngay chinh xac cua thang do (co xet nam nhuan)
                int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);
                Console.WriteLine($"Thang {thang} nam {nam} co **{soNgayTrongThang} ngay**.");
                Console.WriteLine("---------------------------------------");

                // 4. Cho biet ngay hom sau
                // AddDays(1) se tu dong cong them 1 ngay va chuyen thang, nam neu can
                DateTime ngayHomSau = ngayNhap.AddDays(1);
                Console.WriteLine($"Ngay hom sau cua {ngayNhap.ToShortDateString()} la **{ngayHomSau.ToShortDateString()}**.");
                Console.WriteLine("---------------------------------------");

                // 5. Cho biet ngay hom truoc
                // AddDays(-1) se tu dong tru di 1 ngay va chuyen thang, nam neu can
                DateTime ngayHomTruoc = ngayNhap.AddDays(-1);
                Console.WriteLine($"Ngay hom truoc cua {ngayNhap.ToShortDateString()} la **{ngayHomTruoc.ToShortDateString()}**.");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Neu ngay, thang, nam khong hop le (vi du: ngay 30 thang 2, thang 13, ...)
                // Ham tao DateTime se nem ra ngoai le ArgumentOutOfRangeException
                Console.WriteLine($"Ngay/Thang/Nam nhap vao **KHONG hop le**.");
            }
            catch (FormatException)
            {
                // Xu ly khi nguoi dung nhap ky tu khong phai so
                Console.WriteLine("Du lieu nhap vao khong hop le. Vui long chi nhap so nguyen.");
            }
        }
    }
}
