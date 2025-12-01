using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class Program
    {
        static void OnCalculationStart()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- Bắt đầu thực hiện phép toán ---");
            Console.ResetColor();
        }
        static void BeforePrintHandler()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- Đã gọi Event BeforePrint ---");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintHelper helper = new PrintHelper();

            // 3. Đăng ký phương thức vào event
            helper.beforePrintEvent += BeforePrintHandler;

            // Gọi các phương thức in
            helper.PrintNumber(1234567);
            helper.PrintDecimal(98765);
            helper.PrintMoney(50000000);
            helper.PrintTemperature(35);
            helper.PrintHexadecimal(255);

            Console.ReadKey();
            Calculator calc = new Calculator();

            // Đăng ký phương thức xử lý vào Event
            calc.calculationStartEvent += OnCalculationStart;

            double x = 100;
            double y = 20;
            double z = 0;

            // Khởi tạo Delegate với các phương thức tương ứng
            MathOperation addOp = calc.Add;
            MathOperation subOp = calc.Subtract;
            MathOperation mulOp = calc.Multiply;
            MathOperation divOp = calc.Divide;

            // Thực hiện các phép toán sử dụng Delegate
            calc.ExecuteAndPrint(x, y, addOp, "Cộng");
            calc.ExecuteAndPrint(x, y, subOp, "Trừ");
            calc.ExecuteAndPrint(x, y, mulOp, "Nhân");
            calc.ExecuteAndPrint(x, y, divOp, "Chia");

            // Thử nghiệm trường hợp ngoại lệ (chia cho 0)
            calc.ExecuteAndPrint(x, z, divOp, "Chia");

            Console.ReadKey();
            Console.WriteLine("==========BAI 2=========");
            NumberManager manager = new NumberManager();

            // Đăng ký các phương thức xử lý vào Event
            manager.OnNumberAdded += NumberAddedSuccess;
            manager.OnInvalidNumber += InvalidNumber;

            string choice;

            do
            {
                ShowMenu();
                choice = Console.ReadLine()?.ToLower();

                switch (choice)
                {
                    case "add":
                        Console.Write("Enter number: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            manager.AddNumber(num); // Gọi phương thức sẽ kích hoạt Event
                        }
                        else
                        {
                            // Xử lý trường hợp người dùng nhập chữ/ký tự không phải số
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lỗi: Đầu vào không phải là số nguyên.");
                            Console.ResetColor();
                        }
                        break;

                    case "display":
                        manager.DisplayNumbers();
                        break;

                    case "exit":
                        Console.WriteLine("Đang thoát chương trình. Tạm biệt!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }


            } while (choice != "exit");

            // bai3
            Console.WriteLine("====================BAI 3=============");
            Student student1 = new Student();

            // Bắt đầu quá trình nhập liệu có kiểm tra lỗi
            student1.InputDetails();

            // Hiển thị thông tin sau khi nhập thành công
            student1.DisplayDetails();

            Console.ReadKey();
        }
        static void NumberAddedSuccess(int number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SUCCESS] Đã thêm số {number} vào danh sách.");
            Console.ResetColor();
        }

        // Phương thức xử lý sự kiện khi nhập số không hợp lệ
        static void InvalidNumber(int number)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid number ({number} <= 0). Please try again!");
            Console.ResetColor();
        }

        static void ShowMenu()
        {
            Console.WriteLine("\nAdd -> Add number");
            Console.WriteLine("Display -> Display number");
            Console.WriteLine("Exit -> Exit program");
            Console.Write("Please choice: ");
        }
    }
}
