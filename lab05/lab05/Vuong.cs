using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    // Lớp Vuong kế thừa từ ChuNhat
    public class Vuong : ChuNhat
    {
        // Hàm tạo: truyền cạnh vào hàm tạo của lớp cha (base)
        public Vuong(double canh) : base(canh, canh)
        {
            // Hình vuông có chiều dài = chiều rộng = cạnh
        }

        // Ghi đè phương thức xuat()
        public override void xuat()
        {
            Console.WriteLine("\n--- THÔNG TIN HÌNH VUÔNG ---");
            // Thuộc tính dai (chiều dài) lúc này chính là cạnh của hình vuông
            Console.WriteLine($"Cạnh: {dai}");
            Console.WriteLine($"Diện tích: {getDienTich()}");
            Console.WriteLine($"Chu vi: {getChuVi()}");
        }
    }
}
