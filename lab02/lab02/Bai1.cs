using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Bai1
    {
        public static void bai1()
        {
            Console.WriteLine("--- Giai phuong trinh bac nhat: ax + b = 0 ---");

            // Nhap he so a
            Console.Write("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Nhap he so b
            Console.Write("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Giai va bien luan phuong trinh
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else // b != 0
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else // a != 0
            {
                double x = -b / a;
                Console.WriteLine($"Phuong trinh co mot nghiem duy nhat: x = {x}");
            }
        }
    }
}
