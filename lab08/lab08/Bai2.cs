using System;
using System.Collections; // Cần dùng cho Hashtable

public class Bai2
{
    public static void Run()
    {
        Console.WriteLine("\n*** Bài 2: Sử dụng Hashtable ***");

        // 1. Tạo Hashtable lưu danh sách các ngày trong tuần với key từ 1-8
        Hashtable daysOfWeek = new Hashtable();
        daysOfWeek.Add(1, "Monday");
        daysOfWeek.Add(2, "Tuesday");
        daysOfWeek.Add(3, "Wednesday");
        daysOfWeek.Add(4, "Thursday");
        daysOfWeek.Add(5, "Friday");
        daysOfWeek.Add(6, "Saturday");
        daysOfWeek.Add(7, "Sunday");
        daysOfWeek.Add(8, "ExtraDay"); // Thêm key 8 theo yêu cầu

        // 2. Tìm ngày "TueDay" và in thông báo
        string searchDay = "Tuesday";
        bool found = false;

        // Hashtable chỉ tìm kiếm theo Key, nên ta phải lặp qua các Value để tìm kiếm
        foreach (DictionaryEntry entry in daysOfWeek)
        {
            if (entry.Value.ToString() == searchDay)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"Tìm thấy ngày **{searchDay}** trong Hashtable.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy ngày **{searchDay}** trong Hashtable.");
        }

        // 3. In ra các ngày trong tuần bao gồm cả key và value
        Console.WriteLine("\nDanh sách Key và Value trong Hashtable:");
        foreach (DictionaryEntry entry in daysOfWeek)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}