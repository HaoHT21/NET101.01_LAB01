
using System.Collections.Generic;
using System;

public class BookList
{
    private List<Book> books;

    public BookList()
    {
        books = new List<Book>();
    }

    // Thao tác 1: Thêm sách
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Thao tác 2: Xuất danh sách sách
    public void DisplayAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Danh sách sách trống.");
            return;
        }
        Console.WriteLine("\n*** DANH SÁCH TẤT CẢ CÁC CUỐN SÁCH ***");
        foreach (var book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }

    // Thao tác 3: Trả về danh sách để thao tác bên ngoài (như sắp xếp)
    public List<Book> GetBooks()
    {
        return books;
    }
}