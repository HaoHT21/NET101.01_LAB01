using System;

public class Student
{
    // 1. Các thuộc tính private (phạm vi truy cập private)
    private string studentID;
    private string studentName;
    private int age;
    private string gender;
    private string city;

    // Các Property public cho phép đọc (get) giá trị
    public string StudentID { get { return studentID; } }
    public string StudentName { get { return studentName; } }
    public int Age { get { return age; } }
    public string Gender { get { return gender; } }
    public string City { get { return city; } }

    // Phương thức nhập chi tiết thông tin cho Student (có kiểm tra ràng buộc)
    public void InputDetails()
    {
        Console.WriteLine("\n--- Bắt đầu nhập thông tin Student ---");

        // Nhập studentID
        Console.Write("Nhập Student ID: ");
        this.studentID = Console.ReadLine();

        // 2. Kiểm tra studentName (Độ dài từ 6-40 ký tự)
        bool nameValid = false;
        while (!nameValid)
        {
            Console.Write("Nhập Student Name (6-40 ký tự): ");
            string inputName = Console.ReadLine();
            if (inputName.Length >= 6 && inputName.Length <= 40)
            {
                this.studentName = inputName;
                nameValid = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lỗi: Student Name phải có độ dài từ 6 đến 40 ký tự.");
                Console.ResetColor();
            }
        }

        // 3. Kiểm tra age (>= 18, chỉ cho phép nhập số)
        bool ageValid = false;
        while (!ageValid)
        {
            Console.Write("Nhập Age (>= 18): ");
            if (int.TryParse(Console.ReadLine(), out int inputAge))
            {
                if (inputAge >= 18)
                {
                    this.age = inputAge;
                    ageValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lỗi: Age phải lớn hơn hoặc bằng 18.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lỗi: Đầu vào không hợp lệ. Vui lòng chỉ nhập số.");
                Console.ResetColor();
            }
        }

        // 4. Kiểm tra gender (chỉ nhận "Nam" hoặc "Nữ")
        bool genderValid = false;
        while (!genderValid)
        {
            Console.Write("Nhập Gender (Nam/Nữ): ");
            string inputGender = Console.ReadLine();
            // So sánh không phân biệt chữ hoa/chữ thường
            if (inputGender.Equals("Nam", StringComparison.OrdinalIgnoreCase) ||
                inputGender.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
            {
                this.gender = inputGender;
                genderValid = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lỗi: Gender phải là 'Nam' hoặc 'Nữ'. Vui lòng nhập lại.");
                Console.ResetColor();
            }
        }

        // 5. Kiểm tra city (Độ dài từ 4-40 ký tự)
        bool cityValid = false;
        while (!cityValid)
        {
            Console.Write("Nhập City (4-40 ký tự): ");
            string inputCity = Console.ReadLine();
            if (inputCity.Length >= 4 && inputCity.Length <= 40)
            {
                this.city = inputCity;
                cityValid = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lỗi: City phải có độ dài từ 4 đến 40 ký tự.");
                Console.ResetColor();
            }
        }
    }

    // Phương thức hiển thị thông tin (để kiểm tra)
    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Thông tin Student Đã Nhập ---");
        Console.WriteLine($"ID: {this.studentID}");
        Console.WriteLine($"Name: {this.studentName}");
        Console.WriteLine($"Age: {this.age}");
        Console.WriteLine($"Gender: {this.gender}");
        Console.WriteLine($"City: {this.city}");
        Console.WriteLine("-----------------------------------");
    }
}