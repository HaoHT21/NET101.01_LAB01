using System;
using System.Collections; // Để sử dụng ArrayList

// 1. Khai báo Delegate cho việc nhập số hợp lệ
public delegate void ValidNumberInputHandler(int number);

// 2. Khai báo Delegate cho việc nhập số không hợp lệ
public delegate void InvalidInputHandler(int number);

public class NumberManager
{
    private ArrayList numberList = new ArrayList();

    // 3. Khai báo Event
    public event ValidNumberInputHandler OnNumberAdded;
    public event InvalidInputHandler OnInvalidNumber;

    // Phương thức thêm số
    public void AddNumber(int number)
    {
        // Logic kiểm tra số nguyên dương
        if (number > 0)
        {
            numberList.Add(number);

            // Kích hoạt Event khi số hợp lệ
            OnNumberAdded?.Invoke(number);
        }
        else
        {
            // Kích hoạt Event khi số không hợp lệ
            OnInvalidNumber?.Invoke(number);
        }
    }

    // Phương thức hiển thị các số
    public void DisplayNumbers()
    {
        if (numberList.Count == 0)
        {
            Console.WriteLine("Danh sách rỗng.");
            return;
        }

        Console.WriteLine("\n--- Các số đã nhập ---");
        foreach (object num in numberList)
        {
            // Ép kiểu lại từ object sang int để hiển thị
            Console.WriteLine(num);
        }
        Console.WriteLine("------------------------");
    }
}