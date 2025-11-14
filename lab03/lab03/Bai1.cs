using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Bai1
    {
        public static void bai1()
        {
            Console.WriteLine("--- BÀI 1: XỬ LÝ MẢNG VÀ ARRAYLIST ---");
            Console.Write("Nhập số lượng phần tử N: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ.");
                return;
            }

            // 1. Khai báo Mảng (Array) và ArrayList
            int[] mangThuong = new int[n];
            ArrayList arrayList = new ArrayList(n);

            Console.WriteLine("\n* NHẬP DỮ LIỆU *");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    mangThuong[i] = value;
                    arrayList.Add(value);
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ, gán 0.");
                    mangThuong[i] = 0;
                    arrayList.Add(0);
                }
            }

            // --- 1. Sắp xếp và xuất mảng ---
            Console.WriteLine("\n* 1. SẮP XẾP VÀ XUẤT MẢNG *");

            // Sắp xếp Mảng 1 chiều
            Array.Sort(mangThuong);
            Console.WriteLine($"  - Mảng đã sắp xếp: {string.Join(", ", mangThuong)}");

            // Sắp xếp ArrayList (Dùng phương thức Sort() của ArrayList)
            arrayList.Sort();
            Console.WriteLine($"  - ArrayList đã sắp xếp: {string.Join(", ", arrayList.Cast<int>())}");

            // --- 2. Xuất phần tử có giá trị nhỏ nhất ---
            Console.WriteLine("\n* 2. GIÁ TRỊ NHỎ NHẤT *");

            // Phần tử nhỏ nhất là phần tử đầu tiên sau khi sắp xếp
            int minArray = mangThuong[0];
            int minList = (int)arrayList[0];

            Console.WriteLine($"  - Giá trị nhỏ nhất (Mảng): {minArray}");
            Console.WriteLine($"  - Giá trị nhỏ nhất (ArrayList): {minList}");


            // --- 3. Tính và xuất trung bình các phần tử chia hết cho 3 ---
            Console.WriteLine("\n* 3. TRUNG BÌNH CÁC PHẦN TỬ CHIA HẾT CHO 3 *");

            int count = 0;
            long sum = 0;
            string elements = "";

            foreach (object item in arrayList) // Lặp qua ArrayList
            {
                int val = (int)item; // Ép kiểu từ object sang int
                if (val % 3 == 0)
                {
                    sum += val;
                    count++;
                    elements += val + ", ";
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                // Xóa dấu phẩy và khoảng trắng cuối cùng
                elements = elements.TrimEnd(' ', ',');
                Console.WriteLine($"  - Các phần tử chia hết cho 3: {elements}");
                Console.WriteLine($"  - Trung bình cộng: {average:F2}");
            }
            else
            {
                Console.WriteLine("  - Không có phần tử nào chia hết cho 3.");
            }
        }
    }
}
