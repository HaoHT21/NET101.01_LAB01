using System;

public class Bai3
{
    // Phương thức Generic để hoán vị 2 phần tử
    // Tên kiểu T (Type) là một placeholder cho bất kỳ kiểu dữ liệu nào
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void Run()
    {
        Console.WriteLine("\n*** Bài 3: Sử dụng Generic để hoán vị (Swap) ***");

        // Hoán vị với kiểu int
        int x = 10;
        int y = 20;
        Console.WriteLine($"Trước khi Swap (int): x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"Sau khi Swap (int):  x = {x}, y = {y}");

        Console.WriteLine("---");

        // Hoán vị với kiểu string
        string s1 = "Hello";
        string s2 = "World";
        Console.WriteLine($"Trước khi Swap (string): s1 = {s1}, s2 = {s2}");
        Swap(ref s1, ref s2);
        Console.WriteLine($"Sau khi Swap (string):  s1 = {s1}, s2 = {s2}");

        Console.WriteLine("---");

        // Hoán vị với kiểu double
        double d1 = 3.14;
        double d2 = 9.81;
        Console.WriteLine($"Trước khi Swap (double): d1 = {d1}, d2 = {d2}");
        Swap(ref d1, ref d2);
        Console.WriteLine($"Sau khi Swap (double):  d1 = {d1}, d2 = {d2}");
    }
}

// **Lưu ý:** Để chạy các bài này, bạn cần đặt các lớp Bai1, Bai2, Bai3, và Product vào cùng một Project C\# và gọi phương thức Run() tương ứng trong hàm Main() của lớp Program.