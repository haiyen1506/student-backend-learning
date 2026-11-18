Console.OutputEncoding = System.Text.Encoding.UTF8;

// Sinh viên thứ nhất: Constructor có 3 tham số
Student sv1 = new Student("SV01", "An", 20);
bool ketQua = sv1.CapNhatTuoi(25);

Console.WriteLine($"Cập nhật thành công: {ketQua}");
Console.WriteLine($"Tuổi sau cập nhật: {sv1.Tuoi}");

Console.WriteLine("--- Sinh viên thứ nhất ---");
Console.WriteLine($"Mã: {sv1.MaSinhVien}");
Console.WriteLine($"Tên: {sv1.HoTen}");
Console.WriteLine($"Tuổi: {sv1.Tuoi}");
Console.WriteLine(sv1.Tuoi);

//sv1.Tuoi = 25;

// Sinh viên thứ hai: Constructor có 2 tham số
Student sv2 = new Student("SV02", "Bình");

Console.WriteLine("\n--- Sinh viên thứ hai ---");
Console.WriteLine($"Mã: {sv2.MaSinhVien}");
Console.WriteLine($"Tên: {sv2.HoTen}");
Console.WriteLine($"Tuổi: {sv2.Tuoi}");

// Tiểu mục 4: Method và Encapsulation
