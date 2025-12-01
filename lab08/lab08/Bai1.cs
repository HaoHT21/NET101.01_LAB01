using System;
using System.Collections; // Cần dùng cho ArrayList

public class Product
{
    // Các trường dữ liệu
    public string name { get; set; }
    public double cost { get; set; }
    public int onhand { get; set; }

    // Constructor
    public Product(string name, double cost, int onhand)
    {
        this.name = name;
        this.cost = cost;
        this.onhand = onhand;
    }

    // Ghi đè phương thức ToString()
    public override string ToString()
    {
        return $"Tên: {name}, Giá: {cost:C}, Số lượng tồn: {onhand}";
    }
}

public class Bai1
{
    public static void Run()
    {
        Console.WriteLine("\n*** Bài 1: Sử dụng ArrayList ***");

        // 1. Khởi tạo ArrayList
        ArrayList productList = new ArrayList();

        // 2. Thêm 5 sản phẩm vào ArrayList
        productList.Add(new Product("Laptop X", 1500.50, 10));
        productList.Add(new Product("Smartphone Y", 899.99, 25));
        productList.Add(new Product("Mouse Z", 25.00, 100));
        productList.Add(new Product("Keyboard A", 75.25, 50));
        productList.Add(new Product("Monitor B", 350.00, 15));

        Console.WriteLine("Danh sách sản phẩm:");

        // 3. Hiển thị thông tin ra màn hình
        foreach (Product p in productList)
        {
            // Tự động gọi phương thức ToString() đã ghi đè
            Console.WriteLine(p);
        }
    }
}