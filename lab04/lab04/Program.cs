using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SanPham sp1 = new SanPham("Laptop", 25000000, 5000000);
            SanPham sp2 = new SanPham("Tainghe", 500000);

            Console.WriteLine("\n=== XUẤT THÔNG TIN SẢN PHẨM SAU KHI SỬ DỤNG HÀM TẠO ===");

            Console.WriteLine("\n--- Thông tin Sản phẩm 1 (Có giảm giá) ---");
            sp1.xuat();

            Console.WriteLine("\n--- Thông tin Sản phẩm 2 (Không giảm giá) ---");
            sp2.xuat();
        }
    }
}
