using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Bai5
    {
        public static void bai5()
        {
            Console.WriteLine("--- Bang Cuu Chuong (1 den 10) ---");

            // Vong lap ngoai: Dieu khien phep nhan (tu 1 den 10)
            for (int i = 1; i <= 10; i++)
            {
                // In tieu de cua bang cuu chuong hien tai
                Console.WriteLine($"\n--- Bang nhan {i} ---");

                // Vong lap trong: Dieu khien so bi nhan (tu 1 den 10)
                for (int j = 1; j <= 10; j++)
                {
                    int ketQua = i * j;
                    // In ket qua ra man hinh theo format: A x B = C
                    Console.WriteLine($"{i} x {j} = {ketQua}");
                }
            }
        }  
    }
}
