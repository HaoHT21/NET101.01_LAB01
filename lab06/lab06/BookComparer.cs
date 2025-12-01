
using System.Collections.Generic;

public class BookComparer : IComparer<Book>
{
    private readonly string _sortBy;

    public BookComparer(string sortBy)
    {
        _sortBy = sortBy.ToLower();
    }

    public int Compare(Book x, Book y)
    {
        if (x == null || y == null)
            return x == null ? (y == null ? 0 : -1) : 1;

        switch (_sortBy)
        {
            case "author":
                return x.Author.CompareTo(y.Author);
            case "price":
                return x.Price.CompareTo(y.Price);
            case "year":
                return x.PublicationYear.CompareTo(y.PublicationYear);
            case "title":
            default:
                return x.Title.CompareTo(y.Title);
        }
    }
}

// IComparer kết hợp nhiều tiêu chí (Yêu cầu: Tên tác giả, Tên sách, Năm xuất bản)
public class AuthorTitleYearComparer : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        if (x == null || y == null)
            return x == null ? (y == null ? 0 : -1) : 1;

        // 1. Sắp xếp theo Tên tác giả (Author)
        int authorCompare = x.Author.CompareTo(y.Author);
        if (authorCompare != 0)
            return authorCompare;

        // 2. Nếu Tác giả giống nhau, sắp xếp theo Tên sách (Title)
        int titleCompare = x.Title.CompareTo(y.Title);
        if (titleCompare != 0)
            return titleCompare;

        // 3. Nếu Tên sách giống nhau, sắp xếp theo Năm xuất bản (PublicationYear)
        return x.PublicationYear.CompareTo(y.PublicationYear);
    }
}