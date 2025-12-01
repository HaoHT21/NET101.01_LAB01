using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal class Program
    {
        static List<Book> CreateSampleBooks()
        {
            return new List<Book>
        {
            new Book("Cấu trúc dữ liệu và giải thuật", "Nguyễn Văn A", 120000m, "NXB Giáo dục", 2023, "978-604-59-1234-5", new List<string> {"Chương 1", "Chương 2", "Chương 3"}),
            new Book("Lập trình Hướng đối tượng", "Trần Thị B", 95000m, "NXB Bách Khoa", 2022, "978-604-59-5432-1", new List<string> {"Chương 10", "Chương 11", "Chương 12"}),
            new Book("Thuật toán nâng cao", "Nguyễn Văn A", 150000m, "NXB Khoa học", 2023, "978-604-59-9876-5", new List<string> {"Chương I", "Chương II"}),
            new Book("Cấu trúc dữ liệu và giải thuật", "Nguyễn Văn A", 110000m, "NXB Giáo dục", 2021, "978-604-59-1234-5", new List<string> {"Chương 1", "Chương 2", "Chương 3"}),
            new Book("Lập trình C# cơ bản", "Đỗ Văn C", 80000m, "NXB Trẻ", 2024, "978-604-59-6789-0", new List<string> {"Chương A", "Chương B", "Chương C"}),
        };
        }
        static void Main(string[] args)
        {
            // o Cho nhập vào một mảng chứa những cuốn sách
            List<Book> initialBooks = CreateSampleBooks();
            BookList bookList = new BookList();

            foreach (var book in initialBooks)
            {
                bookList.AddBook(book);
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- ỨNG DỤNG QUẢN LÝ SÁCH CƠ BẢN ---");

            // o Xuất danh sách thông tin những cuốn sách
            bookList.DisplayAllBooks();

            Console.WriteLine("\n" + new string('-', 50));

            // o Lần lượt xuất danh sách ra theo thứ tự được sắp xếp theo: tên tác giả, tên sách, năm xuất bản

            // Lấy danh sách để sắp xếp
            List<Book> booksToSort = bookList.GetBooks();

            // Sắp xếp sử dụng IComparer kết hợp
            booksToSort.Sort(new AuthorTitleYearComparer());

            Console.WriteLine("\n*** DANH SÁCH SÁCH ĐÃ SẮP XẾP (Theo Tác giả, Tên sách, Năm XB) ***");
            foreach (var book in booksToSort)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\n" + new string('-', 50));

            // Ví dụ sử dụng sắp xếp mặc định (theo Title - nhờ IComparable<Book>)
            Console.WriteLine("\n*** DANH SÁCH SÁCH ĐÃ SẮP XẾP MẶC ĐỊNH (Theo Tên sách) ***");
            booksToSort.Sort();
            foreach (var book in booksToSort)
            {
                Console.WriteLine(book.ToString());
            }
            // BAI2

            Console.WriteLine("==========BAI 2===========");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- DEMO ĐA HÌNH VỚI INTERFACE DBAction ---");

            // Tạo 2 đối tượng từ 2 lớp Product và Order
            // Gán đối tượng cho biến tham chiếu kiểu DbAction (Đa hình)
            DbAction db1 = new Product();
            DbAction db2 = new Order();

            Console.WriteLine("\n*** GỌI PHƯƠNG THỨC INSERT() ***");

            // Gọi phương thức insert() của mỗi đối tượng
            // Mặc dù gọi cùng một phương thức từ cùng một kiểu tham chiếu (DbAction),
            // nhưng hành vi thực tế là khác nhau (Product.insert() và Order.insert())
            db1.insert(); // Kết quả: "Insert product"
            db2.insert(); // Kết quả: "Insert order"

            Console.WriteLine("\n*** GỌI TẤT CẢ CÁC PHƯƠNG THỨC TRÊN DbAction ***");

            // Thử gọi các phương thức khác để minh họa đầy đủ
            Console.WriteLine("-- Product Actions --");
            db1.update();
            db1.delete();
            db1.select();

            Console.WriteLine("-- Order Actions --");
            db2.update();
            db2.delete();
            db2.select();
        }
    }
}
