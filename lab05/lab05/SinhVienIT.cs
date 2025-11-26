using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    // Lớp con kế thừa từ SinhVienPoly
    // SinhVienIT.cs
    public class SinhVienIT : SinhVienPoly
    {
        private double diemJava;
        private double diemHtml;
        private double diemCss;

        public SinhVienIT(string hoTen, double diemJava, double diemHtml, double diemCss)
            // Gọi hàm tạo lớp cha
            : base(hoTen, "Công nghệ thông tin")
        {
            this.diemJava = diemJava;
            this.diemHtml = diemHtml;
            this.diemCss = diemCss;
        }

        // Ghi đè phương thức getDiem() theo công thức IT
        // Công thức: (2*java + html + css) / 4
        public override double getDiem()
        {
            return (2 * diemJava + diemHtml + diemCss) / 4;
        }
    }
}
