
using System;

// 1. Khai báo Delegate cho phép toán (trả về double, nhận 2 tham số double)
public delegate double MathOperation(double a, double b);

// 2. Khai báo Delegate cho Event (không trả về, không tham số)
public delegate void CalculationStart();

public class Calculator
{
    // 3. Khai báo Event
    public event CalculationStart calculationStartEvent;

    // Các phương thức thực hiện phép toán
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        // 4. Áp dụng ngoại lệ: Kiểm tra chia cho 0
        if (b == 0)
        {
            throw new DivideByZeroException("Lỗi: Không thể chia cho 0.");
        }
        return a / b;
    }

    // Phương thức sử dụng Delegate để thực hiện và in kết quả
    public void ExecuteAndPrint(double num1, double num2, MathOperation operation, string opName)
    {
        try
        {
            // Kích hoạt Event trước khi thực hiện phép toán
            calculationStartEvent?.Invoke();

            double result = operation(num1, num2);
            Console.WriteLine($"Kết quả {opName} của {num1} và {num2} là: {result}");
        }
        catch (DivideByZeroException ex)
        {
            // Bắt ngoại lệ chia cho 0
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Lỗi khi thực hiện phép {opName}: {ex.Message}");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            // Bắt các ngoại lệ chung khác
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Đã xảy ra lỗi chung: {ex.Message}");
            Console.ResetColor();
        }
    }
}