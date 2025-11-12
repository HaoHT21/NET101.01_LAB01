using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Bai2
    {
        public static void bai2()
        {
            Console.WriteLine("--- Giai phuong trinh bac hai: ax^2 + bx + c = 0 ---");

            // Nhap a, b, c
            Console.Write("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiem tra a
            if (a == 0)
            {
                // Giai phuong trinh bac nhat (bx + c = 0)
                Console.WriteLine("a = 0. Day la phuong trinh bac nhat: bx + c = 0");
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else // b != 0
                {
                    double x = -c / b;
                    Console.WriteLine($"Phuong trinh co mot nghiem duy nhat: x = {x}");
                }
            }
            else // a != 0
            {
                // Tinh Delta
                double delta = b * b - 4 * a * c;

                // Bien luan theo Delta
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (delta == 0)
                {
                    double x_kep = -b / (2 * a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x_kep}");
                }
                else // delta > 0
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                    Console.WriteLine($"X1 = {x1}");
                    Console.WriteLine($"X2 = {x2}");
                }
            }
        }
    }
}
