using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class ChuNhat
    {
        // Thuộc tính
        protected double rong;
        protected double dai;

        // Hàm tạo (Constructor)
        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        // Phương thức tính chu vi
        public double getChuVi()
        {
            return 2 * (dai + rong);
        }

        // Phương thức tính diện tích
        public double getDienTich()
        {
            return dai * rong;
        }

        // Phương thức xuất thông tin
        public virtual void xuat()
        {
            Console.WriteLine("\n--- THÔNG TIN HÌNH CHỮ NHẬT ---");
            Console.WriteLine($"Chiều rộng: {rong}");
            Console.WriteLine($"Chiều dài: {dai}");
            Console.WriteLine($"Diện tích: {getDienTich()}");
            Console.WriteLine($"Chu vi: {getChuVi()}");
        }
    }
}
