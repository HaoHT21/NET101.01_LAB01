public class HocVien
{
    // --- Thuộc tính (Properties) ---
    public string HoTen { get; set; }
    public float Diem { get; set; }
    public string Email { get; set; }

    // --- Thuộc tính chỉ đọc (Read-only Property) để tính Học Lực (Y02) ---
    public string HocLuc
    {
        get
        {
            if (Diem < 3) return "Yếu";
            if (Diem < 5) return "Yếu"; // Điểm từ 3 đến < 5 (đã bao gồm)
            if (Diem < 6.5) return "Trung bình"; // Điểm từ 5 đến < 6.5
            if (Diem < 7.5) return "Khá"; // Điểm từ 6.5 đến < 7.5
            if (Diem < 9) return "Giỏi"; // Điểm từ 7.5 đến < 9
            return "Xuất sắc"; // Điểm từ 9 trở lên
        }
    }
}