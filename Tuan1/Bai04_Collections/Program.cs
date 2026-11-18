// // List trong C#

// // Cú pháp: List<string> danhSach = new List<string>();
// // List là lớp  danh sách
// // <string>: Là kiểu dữ liệu của phần tử
// // danhSach:  tên biến
// // new: tạo đối tượng mới
// // List<string>() Khởi tạo danh sách rỗng
// //List<int> danhSachTuoi = new List<int>(); // Danh sách lưu số nguyên
// //List<string> danhSachTen = new List<string>(); // Danh sách chuỗi

// // Bước 1. Tạo danh sách rỗng
// List<string> danhsachSinhVien = new List<string>(); // danh sách rỗng, count =0
// // Bước 2. Thêm sinh viên
// danhsachSinhVien.Add("An"); // Sau câu lệnh này, index 0 là An
// danhsachSinhVien.Add("Bình");
// danhsachSinhVien.Add("Yến");
// danhsachSinhVien.Add("Dũng");
//  // index 2
// //Bước 3. Hiển thị số lượng
// Console.WriteLine ($"Số sinh viên: {danhsachSinhVien.Count}");

// // Bước 4. Hiển thị sinh viên đầu tiên
// Console.WriteLine($"Sinh viên cuối cùng:{danhsachSinhVien[3]}");

// // Tiểu mục 2. Vòng lặp foreach: Giúp duyệt lần lượt từng phần tử trong danh sách
// // Cú pháp: foreach (string ten in danhsachSinhVien)
// // foreach (string ten in danhsachSinhVien)
// // {
// //     Console.WriteLine(ten);
// // }
// // Duyệt toàn bố sinh viên
// Console.WriteLine("\n--DANH SÁCH SINH VIÊN");

// foreach (string ten in danhsachSinhVien)
// {
//     Console.WriteLine(ten);
// }

// // Contains kiểm tra danh sách có chứa 1 giá trị cụ thể hay không. Tìm thấy trả TRUE, kh thấy FALSE

// // bool timthay = danhsachSinhVien.Contains("Yến"); // bool là kiểu dữ liệu dùng để lưu số nguyên và string, bool trả ra 2 giá trị Trư và False

// // if(timthay)
// // {
// //     Console.WriteLine("Tìm thấy sinh viên");

// // }
// // else
// // {
// //     Console.WriteLine("Không tìm thấy sinh viên");
// // }

// // Cho người dùng nhập tên cần tìm
// Console.WriteLine("Nhập tên sinh viên cần tìm:");
// string? tencantim = Console.ReadLine();
// // Kiểm tra tên có trong danh sách không
// bool timthay = danhsachSinhVien.Contains(tencantim);
// if (timthay)
// {
//     Console.WriteLine("Tìm thấy sinh viên");

// }
// else
// {
//     Console.WriteLine("Không tìm thấy sinh viên");
// }

// // Array, sự khác nhau giữa array và list
// // Bước 1. Tạo mảng gồm 3 sinh viên
// string[] sinhvien = {"An", "Bình", "Yến"};
// sinhvien[1] = "Hà";

// // Bước 2. In số lượng phần tử
// Console.WriteLine($"Số sinh viên: {sinhvien.Length}");
// // Bước 3. In ra sinh viên đầu tiên
// Console.WriteLine($"Sinh viên đầu tiên:{sinhvien[0]}");
// // Bước 4. Duyệt toàn bộ mảng
// foreach (string ten in sinhvien)
// {
//     Console.WriteLine(ten);
// }

// // Remove. Xóa sinh viên
// //removeAt() trong list: Xóa phần tử theo index

// // bool daxoa = danhsachSinhVien.Remove("Bình");
// // Console.WriteLine($"Xóa thành công: {daxoa}");
// // danhsachSinhVien.RemoveAt(2);
// // Console.WriteLine($"Số sinh viên còn lại: {danhsachSinhVien.Count}");
// // foreach (string ten in danhsachSinhVien)
// // {
// //     Console.WriteLine(ten);
// // }

// //Find() trong list
// // Sự khác nhau giữa contains và find, contain chỉ cho biết danh sách có chứa giá trị đó
// // thông qua true hoặc false
// // Find là phương thức tìm và trả về phần tử đầu tiên thỏa mãn 1 điều kiện
//  // Bước 1. Tìm sinh viên tên Yến
// //  string? ketqua = danhsachSinhVien.Find(ten => ten == "Minh");
// //  Console.WriteLine($"Kết quả tìm kiếm:{ketqua}");

// //  //Xử lý null khi dùng Find()
// //  if (ketqua != null)
// // {
// //     Console.WriteLine($"Tìm thấy sinh viên: {ketqua}");
// // }
// // else
// // {
// //     Console.WriteLine($"Không tìm thấy sinh viên");
// // }

// string? ketqua = danhsachSinhVien.Find(ten => ten =="Bình");

// if(ketqua != null)
// {
//     Console.WriteLine($"Tìm thấy sinh viên: {ketqua}");

// }
// else
// {
//     Console.WriteLine($"Không tìm thấy");
// }

// //Dictionary
// // Tạo Dictionary quản lý sinh viên theo mã
// Dictionary<string, string> sinhVienTheoMa =
//     new Dictionary<string, string>();

// // Thêm sinh viên
// sinhVienTheoMa.Add("SV01", "An");
// sinhVienTheoMa.Add("SV02", "Bình");

// // Tìm sinh viên theo mã
// Console.WriteLine(sinhVienTheoMa["SV02"]);


Console.OutputEncoding = System.Text.Encoding.UTF8;

// ================= DANH SÁCH SINH VIÊN =================
// Lưu nhiều Object Student trong bộ nhớ
List<Student> danhSachSinhVien = new List<Student>();

// ================= MENU CHÍNH =================
while (true)
{
    Console.WriteLine("\n========== QUẢN LÝ SINH VIÊN ==========");
    Console.WriteLine("1. Thêm sinh viên");
    Console.WriteLine("2. Xem danh sách sinh viên");
    Console.WriteLine("3. Tìm kiếm sinh viên theo mã");
    Console.WriteLine("4. Sửa thông tin sinh viên");
    Console.WriteLine("5. Xóa sinh viên");
    Console.WriteLine("0. Thoát chương trình");

    Console.Write("Mời bạn chọn: ");
    string luaChon = Console.ReadLine() ?? "";

    switch (luaChon)
    {
        case "1":
            ThemSinhVien();
            break;

        case "2":
            XemDanhSach();
            break;

        case "3":
            TimSinhVien();
            break;

        case "4":
            SuaSinhVien();
            break;

        case "5":
            XoaSinhVien();
            break;

        case "0":
            Console.WriteLine("Đã thoát chương trình!");
            return;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }
}

// ================= NHẬP THÔNG TIN =================
// Hàm này sử dụng cho cả chức năng thêm và sửa
Student? NhapThongTin(string ma)
{
    Console.Write("Nhập họ tên sinh viên: ");
    string ten = (Console.ReadLine() ?? "").Trim();

    if (string.IsNullOrWhiteSpace(ten))
    {
        Console.WriteLine("Tên sinh viên không được để trống!");
        return null;
    }

    // Nhập tuổi
    Console.Write("Nhập tuổi: ");

    if (!int.TryParse(Console.ReadLine(), out int tuoi)
        || tuoi <= 0 || tuoi > 120)
    {
        Console.WriteLine("Tuổi không hợp lệ!");
        return null;
    }

    // Nhập điểm Toán
    Console.Write("Nhập điểm Toán (0-10): ");

    if (!double.TryParse(Console.ReadLine(), out double toan)
        || !double.IsFinite(toan)
        || toan < 0 || toan > 10)
    {
        Console.WriteLine("Điểm Toán không hợp lệ!");
        return null;
    }

    // Nhập điểm Văn
    Console.Write("Nhập điểm Văn (0-10): ");

    if (!double.TryParse(Console.ReadLine(), out double van)
        || !double.IsFinite(van)
        || van < 0 || van > 10)
    {
        Console.WriteLine("Điểm Văn không hợp lệ!");
        return null;
    }

    // Nhập điểm Anh
    Console.Write("Nhập điểm Anh (0-10): ");

    if (!double.TryParse(Console.ReadLine(), out double anh)
        || !double.IsFinite(anh)
        || anh < 0 || anh > 10)
    {
        Console.WriteLine("Điểm Anh không hợp lệ!");
        return null;
    }

    // Tạo Object Student
    Student sv = new Student();

    sv.MaSinhVien = ma;
    sv.HoTen = ten;
    sv.Tuoi = tuoi;
    sv.DiemToan = toan;
    sv.DiemVan = van;
    sv.DiemAnh = anh;

    return sv;
}

// ================= TÌM THEO MÃ =================
// Trả về Student nếu tìm thấy, null nếu không tìm thấy
Student? TimTheoMa(string ma)
{
    string maChuanHoa = ma.Trim().ToUpperInvariant();

    return danhSachSinhVien.Find(
        sv => sv.MaSinhVien == maChuanHoa
    );
}

// ================= CREATE - THÊM SINH VIÊN =================
void ThemSinhVien()
{
    Console.Write("Nhập mã sinh viên: ");

    string ma = (Console.ReadLine() ?? "")
        .Trim()
        .ToUpperInvariant();

    // Kiểm tra mã rỗng
    if (string.IsNullOrWhiteSpace(ma))
    {
        Console.WriteLine("Mã sinh viên không được để trống!");
        return;
    }

    // Kiểm tra mã đã tồn tại hay chưa
    if (TimTheoMa(ma) != null)
    {
        Console.WriteLine("Mã sinh viên đã tồn tại!");
        return;
    }

    // Nhập thông tin sinh viên
    Student? svMoi = NhapThongTin(ma);

    if (svMoi == null)
    {
        Console.WriteLine("Thêm sinh viên thất bại!");
        return;
    }

    // Thêm Object vào List
    danhSachSinhVien.Add(svMoi);

    Console.WriteLine("Thêm sinh viên thành công!");
}

// ================= READ - XEM DANH SÁCH =================
void XemDanhSach()
{
    // Kiểm tra danh sách rỗng
    if (danhSachSinhVien.Count == 0)
    {
        Console.WriteLine("Danh sách sinh viên đang trống!");
        return;
    }

    Console.WriteLine("\n========== DANH SÁCH SINH VIÊN ==========");

    // Duyệt từng sinh viên
    foreach (Student sv in danhSachSinhVien)
    {
        InThongTin(sv);
    }

    Console.WriteLine(
        $"\nTổng số sinh viên: {danhSachSinhVien.Count}"
    );
}

// ================= READ - TÌM KIẾM SINH VIÊN =================
void TimSinhVien()
{
    Console.Write("Nhập mã sinh viên cần tìm: ");
    string ma = Console.ReadLine() ?? "";

    Student? sv = TimTheoMa(ma);

    if (sv == null)
    {
        Console.WriteLine("Không tìm thấy sinh viên!");
        return;
    }

    Console.WriteLine("Đã tìm thấy sinh viên!");

    InThongTin(sv);
}

// ================= UPDATE - SỬA SINH VIÊN =================
void SuaSinhVien()
{
    Console.Write("Nhập mã sinh viên cần sửa: ");
    string ma = Console.ReadLine() ?? "";

    // Tìm sinh viên cần sửa
    Student? svCu = TimTheoMa(ma);

    if (svCu == null)
    {
        Console.WriteLine("Không tìm thấy sinh viên!");
        return;
    }

    Console.WriteLine("\nNhập thông tin mới:");

    // Nhập thông tin mới, giữ nguyên mã sinh viên
    Student? svMoi = NhapThongTin(svCu.MaSinhVien);

    if (svMoi == null)
    {
        Console.WriteLine("Cập nhật thất bại!");
        return;
    }

    // Cập nhật Object cũ
    svCu.HoTen = svMoi.HoTen;
    svCu.Tuoi = svMoi.Tuoi;
    svCu.DiemToan = svMoi.DiemToan;
    svCu.DiemVan = svMoi.DiemVan;
    svCu.DiemAnh = svMoi.DiemAnh;

    Console.WriteLine("Cập nhật sinh viên thành công!");
}

// ================= DELETE - XÓA SINH VIÊN =================
void XoaSinhVien()
{
    Console.Write("Nhập mã sinh viên cần xóa: ");
    string ma = Console.ReadLine() ?? "";

    // Tìm sinh viên
    Student? sv = TimTheoMa(ma);

    if (sv == null)
    {
        Console.WriteLine("Không tìm thấy sinh viên!");
        return;
    }

    // Xóa Object khỏi List
    bool daXoa = danhSachSinhVien.Remove(sv);

    if (daXoa)
    {
        Console.WriteLine("Xóa sinh viên thành công!");
    }
    else
    {
        Console.WriteLine("Xóa sinh viên thất bại!");
    }
}

// ================= IN THÔNG TIN SINH VIÊN =================
void InThongTin(Student sv)
{
    // Tính điểm trung bình
    double diemTB = (
        sv.DiemToan + sv.DiemVan + sv.DiemAnh
    ) / 3;

    // Xếp loại
    string xepLoai;

    if (diemTB >= 8)
    {
        xepLoai = "Giỏi";
    }
    else if (diemTB >= 6.5)
    {
        xepLoai = "Khá";
    }
    else if (diemTB >= 5)
    {
        xepLoai = "Trung bình";
    }
    else
    {
        xepLoai = "Yếu";
    }

    // Hiển thị thông tin
    Console.WriteLine("\n---------------------------");
    Console.WriteLine($"Mã sinh viên: {sv.MaSinhVien}");
    Console.WriteLine($"Họ tên: {sv.HoTen}");
    Console.WriteLine($"Tuổi: {sv.Tuoi}");

    Console.WriteLine($"Điểm Toán: {sv.DiemToan}");
    Console.WriteLine($"Điểm Văn: {sv.DiemVan}");
    Console.WriteLine($"Điểm Anh: {sv.DiemAnh}");

    Console.WriteLine($"Điểm trung bình: {diemTB:F2}");
    Console.WriteLine($"Xếp loại: {xepLoai}");

    if (diemTB >= 5)
    {
        Console.WriteLine("Kết quả: Đạt");
    }
    else
    {
        Console.WriteLine("Kết quả: Không đạt");
    }
}
