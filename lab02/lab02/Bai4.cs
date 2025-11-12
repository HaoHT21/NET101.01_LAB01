using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Bai4
    {
        public static void bai4()
        {
            Console.WriteLine("--- Kiem tra so nguyen to ---");

            // Nhap so nguyen N
            Console.Write("Nhap mot so nguyen N: ");
            int N;

            // Kiem tra dau vao co phai la so nguyen hop le khong
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Loi: Du lieu nhap vao khong phai la so nguyen hop le.");
                return;
            }

            // So nguyen to phai lon hon 1
            if (N <= 1)
            {
                Console.WriteLine($"So {N} KHONG phai la so nguyen to.");
                return;
            }

            // Dat co hieu kiem tra
            // true: mac dinh la so nguyen to (chua tim thay uoc so nao)
            bool isPrime = true;

            // Thuc hien vong lap kiem tra cac uoc so tu 2 den N-1
            // Chu y: Chi can kiem tra den Math.Sqrt(N) de toi uu,
            // nhung chuong trinh nay thuc hien theo dung huong dan (i < N)
            for (int i = 2; i < N; i++)
            {
                // Neu N chia het cho i (N co uoc so khac 1 va chinh no)
                if (N % i == 0)
                {
                    isPrime = false; // Ket luan KHONG phai so nguyen to
                    break;           // Thoat vong lap ngay lap tuc
                }
            }

            // Kiem tra co hieu (boolean ok/isPrime) de ket luan
            if (isPrime)
            {
                Console.WriteLine($"So {N} LA so nguyen to.");
            }
            else
            {
                Console.WriteLine($"So {N} KHONG phai la so nguyen to.");
            }
        }
    }
}
