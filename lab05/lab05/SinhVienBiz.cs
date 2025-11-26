using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class SinhVienBiz : SinhVienPoly
    {
        private double diemMarketing;
        private double diemSales;

        public SinhVienBiz(string hoTen, double diemMarketing, double diemSales)
            // Gọi hàm tạo lớp cha
            : base(hoTen, "Kinh tế/Marketing")
        {
            this.diemMarketing = diemMarketing;
            this.diemSales = diemSales;
        }

        // Ghi đè phương thức getDiem() theo công thức Biz
        // Công thức: (2*marketing + sales) / 3
        public override double getDiem()
        {
            return (2 * diemMarketing + diemSales) / 3;
        }
    }
}
