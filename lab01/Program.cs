using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;// hiện tiếng việt
            // BÀi1
            Console.WriteLine("Fpoly chao mung ban đen voi mon C#");
            // BÀi2
            Console.WriteLine("--- Bài 2: Tính toán Hình Chữ Nhật ---");

            
            Console.Write("Nhập chiều dài (dai): ");
            double dai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng (rong): ");
            double rong = Convert.ToDouble(Console.ReadLine());

            double chuVi = (dai + rong) * 2;
            double dienTich = dai * rong;
            double canhNhoNhat = Math.Min(dai, rong);
            Console.WriteLine("\n--- KẾT QUẢ ---");
            Console.WriteLine($"Chiều dài: {dai}");
            Console.WriteLine($"Chiều rộng: {rong}");
            Console.WriteLine($"Chu vi hình chữ nhật: {chuVi}");
            Console.WriteLine($"Diện tích hình chữ nhật: {dienTich}");
            Console.WriteLine($"Cạnh nhỏ nhất: {canhNhoNhat}");

            //BAI3
            Console.WriteLine("--- Bài 3: Tính Thể Tích Khối Lập Phương ---");
            Console.Write("Nhập độ dài cạnh của khối lập phương (canh): ");
            double canh = Convert.ToDouble(Console.ReadLine());
            double theTich = Math.Pow(canh, 3);
            Console.WriteLine($"độ dài cạnh: {canh}");
            Console.WriteLine($"thể tích khối lập phương là: {theTich}");

            //BAI4
            Console.WriteLine("--- Bài 4: Tính Delta và Căn Delta của Phương Trình Bậc Hai ---");

            // KHAI BÁO VÀ NHẬP LIỆU
            Console.Write("Nhập hệ số a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // XỬ LÝ TÍNH TOÁN
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double canDelta = 0;

            if (delta >= 0)
            {
                canDelta = Math.Sqrt(delta);
            }

            // XUẤT KẾT QUẢ
            Console.WriteLine("\n--- KẾT QUẢ ---");
            Console.WriteLine($"Giá trị Delta: {delta}");

            if (delta >= 0)
            {
                Console.WriteLine($"Giá trị Căn Delta: {canDelta}");
            }
            else
            {
                Console.WriteLine("Delta âm, không có căn Delta thực.");
            }
        }
    }

}

