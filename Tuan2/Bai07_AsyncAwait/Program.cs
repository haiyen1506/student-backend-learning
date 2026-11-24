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
// Tiểu mục 7. Field và Property


IStudentService service = new StudentService();

// Tạo sinh viên để kiểm thử
Student svTest1 = new Student("SV01", "Nguyen Van An", 20);

bool ketQua1 = service.ThemSinhVien(svTest1);
Console.WriteLine($"Them lan 1: {ketQua1}");

// Thử thêm sinh viên trùng mã
Student svTest2 = new Student("SV01", "Tran Thi Binh", 21);

bool ketQua2 = service.ThemSinhVien(svTest2);
Console.WriteLine($"Them lan 2: {ketQua2}");

Console.WriteLine ("\n--DANH SACH SINH VIEN--");
// Gọi students service để lấy danh sách
List<Student> danhSach = service.LayDanhSachSinhVien();
//Duyệt và hiển thị từng sinh viên
foreach (Student sv in danhSach)
{
    Console.WriteLine($"Ma:{sv.MaSinhVien}");
    Console.WriteLine($"Ten: {sv.HoTen}");
    Console.WriteLine($"Tuoi: {sv.Tuoi}");
    Console.WriteLine("----------------");

}


Console.WriteLine("--- TIM SINH VIEN ---");

// Tìm sinh viên có mã SV01
var ketQuaTim = service.TimSinhVienTheoMa("SV99");

// Kiểm tra kết quả
if (ketQuaTim != null)
{
    Console.WriteLine($"Tim thay: {ketQuaTim.HoTen}");
}
else
{
    Console.WriteLine("Khong tim thay sinh vien");

}


bool ketQuaCapNhat = service.CapNhatHoTen(
    "SV01", "Nguyen Van Minh"
);

Console.WriteLine(ketQuaCapNhat);


Console.WriteLine("--- KIEM TRA XOA SINH VIEN ---");

Console.WriteLine(
    $"Truoc khi xoa: {service.DemSinhVien()}"
);

bool xoaThanhCong = service.XoaSinhVien("SV01");

Console.WriteLine($"Ket qua xoa: {xoaThanhCong}");

Console.WriteLine(
    $"Sau khi xoa: {service.DemSinhVien()}"
);



Console.WriteLine("\n--- CHECKPOINT OOP ---");

// 1. Thêm sinh viên
bool themCheckpoint = service.ThemSinhVien(
    new Student("SV_TEST", "Nguyen Van An", 20)
);
Console.WriteLine($"Them: {themCheckpoint}");

// 2. Tìm sinh viên
Student? svCheckpoint = service.TimSinhVienTheoMa("SV_TEST");
Console.WriteLine($"Tim: {svCheckpoint?.HoTen}");

// 3. Cập nhật họ tên
bool suaCheckpoint = service.CapNhatHoTen(
    "SV_TEST", "Nguyen Van Minh"
);
Console.WriteLine($"Sua: {suaCheckpoint}");
service.ThemSinhVien(new Student("SV_L01", "An", 18));
service.ThemSinhVien(new Student("SV_L02", "Binh", 22));
service.ThemSinhVien(new Student("SV_L03", "Cuong", 19));
service.ThemSinhVien(new Student("SV_L04", "Dung", 25));
List<Student> ketQuaLocLinq = service.LocSinhVienTheoTuoi(20);
Console.WriteLine("\n---KET QUA LOC LINQ");
foreach (Student svLoc in ketQuaLocLinq)
{
    Console.WriteLine($"Ma: {svLoc.MaSinhVien}");
    Console.WriteLine($"Ten: {svLoc.HoTen}");
    Console.WriteLine($"Tuoi: {svLoc.Tuoi}");
    Console.WriteLine("----------------");
}
//foreach	Vòng lặp duyệt từng phần tử trong danh sách.

Console.WriteLine("\n--- DANH SACH HO TEN ---");

List<string> danhSachHoTenLinq = service.LayDanhSachHoTen();

foreach (string hoTenLinq in danhSachHoTenLinq)
{
    Console.WriteLine(hoTenLinq);
}

Console.WriteLine("\n--- SAP XEP THEO TUOI ---");

List<Student> danhSachSapXep = service.SapXepTheoTuoi();

foreach (Student svSapXep in danhSachSapXep)
{
    Console.WriteLine($"{svSapXep.HoTen} - {svSapXep.Tuoi}");
}

Console.WriteLine("\n--- KIEM TRA FIRST OR DEFAULT ---");

Student? svTimLinq = service.TimSinhVienTheoMa("SV_L02");

if (svTimLinq != null)
{
    Console.WriteLine($"Ten: {svTimLinq.HoTen}");
    Console.WriteLine($"Tuoi: {svTimLinq.Tuoi}");
}
else
{
    Console.WriteLine("Khong tim thay sinh vien");
}

Console.WriteLine("\n--- DEM SINH VIEN LINQ ---");

int soLuongLinq = service.DemSinhVienTheoTuoi(20);

Console.WriteLine($"So luong sinh vien: {soLuongLinq}");

Console.WriteLine("\n--- THONG KE SINH VIEN ---");

Console.WriteLine($"Tong tuoi: {service.TinhTongTuoi()}");

Console.WriteLine($"Tuoi trung binh: {service.TinhTuoiTrungBinh()}");

Console.WriteLine($"Tuoi nho nhat: {service.TimTuoiNhoNhat()}");

Console.WriteLine("\n---NHOM SINH VIEN THEO TUOI----");
var nhomTheoTuoi = service.LayDanhSachSinhVien().GroupBy(sv => sv.Tuoi);
foreach (var nhomTuoi in  nhomTheoTuoi)
{
    Console.WriteLine($"Tuoi: {nhomTuoi.Key}");
    Console.WriteLine($"So sinh vien: {nhomTuoi.Count()}");

}

Console.WriteLine($"Tuoi lon nhat: {service.TimTuoiLonNhat()}");

Console.WriteLine("\n--- PHAN TRANG ---");

List<Student> danhSachPhanTrang =
    service.LaySinhVienPhanTrang(2, 2);

foreach (Student svTrang in danhSachPhanTrang)
{
    Console.WriteLine($"{svTrang.HoTen} - {svTrang.Tuoi}");
}
Console.WriteLine("\n--- KET HOP LINQ ---");

List<string> ketQuaTongHopLinq =
    service.LayHoTenSinhVienTheoTuoi(20);

foreach (string tenTongHop in ketQuaTongHopLinq)
{
    Console.WriteLine(tenTongHop);
}
// 4. Kiểm tra tên sau cập nhật
svCheckpoint = service.TimSinhVienTheoMa("SV_TEST");
Console.WriteLine($"Ten moi: {svCheckpoint?.HoTen}");

// 5. Xóa sinh viên
bool xoaCheckpoint = service.XoaSinhVien("SV_TEST");
Console.WriteLine($"Xoa: {xoaCheckpoint}");

// 6. Kiểm tra sau khi xóa
svCheckpoint = service.TimSinhVienTheoMa("SV_TEST");
Console.WriteLine($"Da xoa thanh cong: {svCheckpoint == null}");
Console.WriteLine("\n--- ASYNC AWAIT ---");

List<Student> danhSachAsync =
    await service.LayDanhSachSinhVienAsync();

foreach (Student svAsync in danhSachAsync)
{
    Console.WriteLine($"{svAsync.HoTen} - {svAsync.Tuoi}");
}

Console.WriteLine("Lay du lieu hoan tat");

Console.WriteLine("\n--- CANCELLATION TOKEN ---");

using var ctsAsync = new CancellationTokenSource();

ctsAsync.CancelAfter(2000);

try
{
    Console.WriteLine("Dang lay du lieu...");

    await Task.Delay(5000, ctsAsync.Token);

    Console.WriteLine("Lay du lieu thanh cong");
}
catch (OperationCanceledException)
{
    Console.WriteLine("Cong viec da bi huy");
}
