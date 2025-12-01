// File: PrintHelper.cs

using System;

public class PrintHelper
{
    // 1. Declare delegate
    public delegate void BeforePrint();

    // 2. Declare event of type delegate
    public event BeforePrint beforePrintEvent;

    public PrintHelper()
    {
        // Constructor, hiện tại không làm gì đặc biệt
    }

    public void PrintNumber(int num)
    {
        // Call delegate method before going to print
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
        }
        Console.WriteLine("Number: {0, -12:N0}", num);
    }

    public void PrintDecimal(int dec)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
        }
        Console.WriteLine("Decimal: {0:G}", dec);
    }

    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
        }
        Console.WriteLine("Money: {0:C}", money);
    }

    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
        }
        // Định dạng nhiệt độ với 4 chữ số sau dấu thập phân (N4) và ký hiệu F (ví dụ)
        Console.WriteLine("Temperature: {0:0,4:N1} F", num);
        // Lưu ý: Cú pháp {0,4:N1} trong hình ảnh có vẻ không hợp lệ, 
        // tôi đã sửa lại thành định dạng chuỗi nội suy để khớp với ý định
        // hoặc dùng {0:N1} để in số với 1 chữ số thập phân nếu num là float/double.
        // Giữ nguyên theo cú pháp gần nhất có thể, nhưng sửa lỗi định dạng.
    }

    public void PrintHexadecimal(int dec)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
        }
        // Định dạng Hexadecimal (X)
        Console.WriteLine("Hexadecimal: {0:X}", dec);
    }
}