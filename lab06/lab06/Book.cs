
using System.Collections.Generic;
using System;

public class Book : IBook, IComparable<Book>
{
    // Implementation of IBook properties
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string Publisher { get; set; }
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }
    public List<string> Chapters { get; set; }

    // Constructor
    public Book(string title, string author, decimal price, string publisher, int year, string isbn, List<string> chapters)
    {
        Title = title;
        Author = author;
        Price = price;
        Publisher = publisher;
        PublicationYear = year;
        ISBN = isbn;
        Chapters = chapters ?? new List<string>();
    }

    // Implementation of IBook method
    public void DisplayBasicInfo()
    {
        Console.WriteLine($"\n--- THÔNG TIN SÁCH ---");
        Console.WriteLine($"Tên sách: {Title}");
        Console.WriteLine($"Tác giả: {Author}");
        Console.WriteLine($"Năm xuất bản: {PublicationYear}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Giá: {Price:C}");
        Console.WriteLine($"Nhà xuất bản: {Publisher}");
        Console.WriteLine($"Số chương: {Chapters.Count}");
    }

    // 4. Định nghĩa quan hệ thứ tự trong CompareTo (Yêu cầu: sắp xếp mặc định theo Tên sách)
    public int CompareTo(Book other)
    {
        if (other == null) return 1;

        // Sắp xếp theo Tên sách (Title)
        return this.Title.CompareTo(other.Title);
    }

    // Phương thức chi tiết riêng của Book (ví dụ: hiển thị danh mục chương)
    public void DisplayChapterList()
    {
        Console.WriteLine($"\n--- DANH MỤC CHƯƠNG CỦA SÁCH: {Title} ---");
        for (int i = 0; i < Chapters.Count; i++)
        {
            Console.WriteLine($"Chương {i + 1}: {Chapters[i]}");
        }
    }

    // Override ToString() để dễ dàng hiển thị thông tin trong danh sách
    public override string ToString()
    {
        return $"[Book] Tác giả: {Author}, Tên sách: {Title}, Năm XB: {PublicationYear}, Giá: {Price:C}, ISBN: {ISBN}";
    }
}