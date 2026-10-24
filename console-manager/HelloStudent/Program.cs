Console.OutputEncoding = System.Text.Encoding.UTF8;

// MENU QUẢN LÝ SINH VIÊN
while (true)
{
    Console.WriteLine("\n========== QUẢN LÝ SINH VIÊN ==========");
    Console.WriteLine("1. Nhập thông tin và tính điểm sinh viên");
    Console.WriteLine("0. Thoát chương trình");

    Console.Write("\nMời bạn chọn: ");
    string? luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            NhapVaTinhDiem();
            break;

        case "0":
            Console.WriteLine("Đã thoát chương trình!");
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }
}

void NhapVaTinhDiem()
{
// Nhập thông tin sinh viên
Console.Write("Nhập họ tên sinh viên: ");
string? hoTen = Console.ReadLine();

// Kiểm tra tên rỗng
if (string.IsNullOrWhiteSpace(hoTen))
{
    Console.WriteLine("Tên sinh viên không được để trống!");
    return;
}

// Nhập tuổi
Console.Write("Nhập tuổi sinh viên: ");
string? inputTuoi = Console.ReadLine();

// Chuyển chuỗi thành số nguyên
bool hopLe = int.TryParse(inputTuoi, out int tuoi);

// Kiểm tra tuổi
if (!hopLe || tuoi <= 0 || tuoi > 120)
{
    Console.WriteLine("Tuổi không hợp lệ!");
    return;
}

// Hiển thị thông tin
Console.WriteLine("\n--- THÔNG TIN SINH VIÊN ---");
Console.WriteLine($"Họ tên: {hoTen}");
Console.WriteLine($"Tuổi: {tuoi}");
// Nhập điểm Toán
Console.Write("\nNhập điểm Toán (0-10): ");
string? inputDiemToan = Console.ReadLine();

// Chuyển đổi và kiểm tra điểm
if (!double.TryParse(inputDiemToan, out double diemToan)
    || diemToan < 0 || diemToan > 10)
{
    Console.WriteLine("Điểm Toán không hợp lệ!");
    return;
}

Console.WriteLine($"Điểm Toán: {diemToan}");
// Nhập điểm Văn
Console.Write("\nNhập điểm Văn (0-10): ");
string? inputDiemVan = Console.ReadLine();

if (!double.TryParse(inputDiemVan, out double diemVan)
    || !double.IsFinite(diemVan)
    || diemVan < 0 || diemVan > 10)
{
    Console.WriteLine("Điểm Văn không hợp lệ!");
    return;
}

// Nhập điểm Tiếng Anh
Console.Write("\nNhập điểm Anh (0-10): ");
string? inputDiemAnh = Console.ReadLine();

if (!double.TryParse(inputDiemAnh, out double diemAnh)
    || !double.IsFinite(diemAnh)
    || diemAnh < 0 || diemAnh > 10)
{
    Console.WriteLine("Điểm Anh không hợp lệ!");
    return;
}

// Hiển thị điểm
Console.WriteLine("\n--- BẢNG ĐIỂM ---");
Console.WriteLine($"Toán: {diemToan}");
Console.WriteLine($"Văn: {diemVan}");
Console.WriteLine($"Anh: {diemAnh}");
// Tính điểm trung bình 3 môn
double diemTrungBinh = (diemToan + diemVan + diemAnh) / 3;

// Hiển thị điểm trung bình
Console.WriteLine("\n--- KẾT QUẢ HỌC TẬP ---");
Console.WriteLine($"Điểm trung bình: {diemTrungBinh:F2}");
// Xếp loại học lực sinh viên
string xepLoai;

if (diemTrungBinh >= 8)
{
    xepLoai = "Giỏi";
}
else if (diemTrungBinh >= 6.5)
{
    xepLoai = "Khá";
}
else if (diemTrungBinh >= 5)
{
    xepLoai = "Trung bình";
}
else
{
    xepLoai = "Yếu";
}

// Hiển thị xếp loại
Console.WriteLine($"Xếp loại: {xepLoai}");
// Xét sinh viên đạt hay không đạt
bool dat = diemTrungBinh >= 5;

// Hiển thị kết quả
if (dat)
{
    Console.WriteLine("Kết quả: Đạt");
}
else
{
    Console.WriteLine("Kết quả: Không đạt");
}
} // Đóng hàm NhapVaTinhDiem