using System;
using System.Collections.Generic;

// 1. Xây dựng interface có tên là IBook
public interface IBook
{
    // Properties cần thiết
    string Title { get; set; }
    string Author { get; set; }
    decimal Price { get; set; }
    string Publisher { get; set; }
    int PublicationYear { get; set; }
    string ISBN { get; set; }
    List<string> Chapters { get; set; } // Danh mục các chương sách (chỉ chứa tên chương)

    // Method cần thiết (ví dụ: một phương thức hiển thị thông tin cơ bản)
    void DisplayBasicInfo();
}