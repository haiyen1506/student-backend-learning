// List trong C#

// Cú pháp: List<string> danhSach = new List<string>();
// List là lớp  danh sách
// <string>: Là kiểu dữ liệu của phần tử
// danhSach:  tên biến
// new: tạo đối tượng mới
// List<string>() Khởi tạo danh sách rỗng
//List<int> danhSachTuoi = new List<int>(); // Danh sách lưu số nguyên
//List<string> danhSachTen = new List<string>(); // Danh sách chuỗi

// Bước 1. Tạo danh sách rỗng
List<string> danhsachSinhVien = new List<string>(); // danh sách rỗng, count =0
// Bước 2. Thêm sinh viên
danhsachSinhVien.Add("An"); // Sau câu lệnh này, index 0 là An
danhsachSinhVien.Add("Bình");
danhsachSinhVien.Add("Yến");
danhsachSinhVien.Add("Dũng");
 // index 2
//Bước 3. Hiển thị số lượng
Console.WriteLine ($"Số sinh viên: {danhsachSinhVien.Count}");

// Bước 4. Hiển thị sinh viên đầu tiên
Console.WriteLine($"Sinh viên cuối cùng:{danhsachSinhVien[3]}");

// Tiểu mục 2. Vòng lặp foreach: Giúp duyệt lần lượt từng phần tử trong danh sách
// Cú pháp: foreach (string ten in danhsachSinhVien)
// foreach (string ten in danhsachSinhVien)
// {
//     Console.WriteLine(ten);
// }
// Duyệt toàn bố sinh viên
Console.WriteLine("\n--DANH SÁCH SINH VIÊN");

foreach (string ten in danhsachSinhVien)
{
    Console.WriteLine(ten);
}

// Contains kiểm tra danh sách có chứa 1 giá trị cụ thể hay không. Tìm thấy trả TRUE, kh thấy FALSE

// bool timthay = danhsachSinhVien.Contains("Yến"); // bool là kiểu dữ liệu dùng để lưu số nguyên và string, bool trả ra 2 giá trị Trư và False

// if(timthay)
// {
//     Console.WriteLine("Tìm thấy sinh viên");

// }
// else
// {
//     Console.WriteLine("Không tìm thấy sinh viên");
// }

// Cho người dùng nhập tên cần tìm
Console.WriteLine("Nhập tên sinh viên cần tìm:");
string? tencantim = Console.ReadLine();
// Kiểm tra tên có trong danh sách không
bool timthay = danhsachSinhVien.Contains(tencantim);
if (timthay)
{
    Console.WriteLine("Tìm thấy sinh viên");

}
else
{
    Console.WriteLine("Không tìm thấy sinh viên");
}

// Array, sự khác nhau giữa array và list
// Bước 1. Tạo mảng gồm 3 sinh viên
string[] sinhvien = {"An", "Bình", "Yến"};
sinhvien[1] = "Hà";

// Bước 2. In số lượng phần tử
Console.WriteLine($"Số sinh viên: {sinhvien.Length}");
// Bước 3. In ra sinh viên đầu tiên
Console.WriteLine($"Sinh viên đầu tiên:{sinhvien[0]}");
// Bước 4. Duyệt toàn bộ mảng
foreach (string ten in sinhvien)
{
    Console.WriteLine(ten);
}

// Remove. Xóa sinh viên
//removeAt() trong list: Xóa phần tử theo index

// bool daxoa = danhsachSinhVien.Remove("Bình");
// Console.WriteLine($"Xóa thành công: {daxoa}");
// danhsachSinhVien.RemoveAt(2);
// Console.WriteLine($"Số sinh viên còn lại: {danhsachSinhVien.Count}");
// foreach (string ten in danhsachSinhVien)
// {
//     Console.WriteLine(ten);
// }

//Find() trong list
// Sự khác nhau giữa contains và find, contain chỉ cho biết danh sách có chứa giá trị đó
// thông qua true hoặc false
// Find là phương thức tìm và trả về phần tử đầu tiên thỏa mãn 1 điều kiện
 // Bước 1. Tìm sinh viên tên Yến
//  string? ketqua = danhsachSinhVien.Find(ten => ten == "Minh");
//  Console.WriteLine($"Kết quả tìm kiếm:{ketqua}");

//  //Xử lý null khi dùng Find()
//  if (ketqua != null)
// {
//     Console.WriteLine($"Tìm thấy sinh viên: {ketqua}");
// }
// else
// {
//     Console.WriteLine($"Không tìm thấy sinh viên");
// }

string? ketqua = danhsachSinhVien.Find(ten => ten =="Bình");

if(ketqua != null)
{
    Console.WriteLine($"Tìm thấy sinh viên: {ketqua}");

}
else
{
    Console.WriteLine($"Không tìm thấy");
}

//Dictionary
// Tạo Dictionary quản lý sinh viên theo mã
Dictionary<string, string> sinhVienTheoMa =
    new Dictionary<string, string>();

// Thêm sinh viên
sinhVienTheoMa.Add("SV01", "An");
sinhVienTheoMa.Add("SV02", "Bình");

// Tìm sinh viên theo mã
Console.WriteLine(sinhVienTheoMa["SV02"]);