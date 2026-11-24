using System.Linq;
public class StudentService: IStudentService
{
    // Danh sách sinh viên
    private List<Student> students = new List<Student>();

    // Đếm số sinh viên
    public int DemSinhVien()
    {
        return students.Count;
    }

    // Thêm sinh viên
    public bool ThemSinhVien(Student student)
    {
        // Bước 1: Kiểm tra null
        if (student == null)
        {
            return false;
        }

        // // Bước 2: Tìm sinh viên trùng mã
        // var sinhVienTrung = students.Find(
        //     s => s.MaSinhVien == student.MaSinhVien
        // );

        // // Bước 3: Nếu trùng mã
        // if (sinhVienTrung != null)
        // {
        //     return false;
        // }
        bool sinhVienTrung = students.Any(
            s => s.MaSinhVien == student.MaSinhVien

        );
        if(sinhVienTrung)
        {
            return false;
        }

        // Bước 4: Thêm sinh viên
        students.Add(student);

        // Bước 5: Báo thành công
        return true;
    }
    // method 3: Lấy danh sách sinh viên
    public List<Student> LayDanhSachSinhVien()
    {
        return new List<Student>(students);

    }
    // //method 4: Tìm sinh viên theo mã
    // public Student TimSinhVienTheoMa( string maSinhVien)
    // {
    //     Student ketQua = students.Find(
    //         s => s.MaSinhVien ==  maSinhVien
    //     );

    //     return ketQua;
    // }
    public Student? TimSinhVienTheoMa(string maSinhVien)
    {
        return students
            .FirstOrDefault(sv => sv.MaSinhVien == maSinhVien);
    }



public bool CapNhatHoTen(string maSinhVien, string hoTenMoi)
{
    // Bước 1: Tìm sinh viên theo mã
    Student? sv = students.Find(
        s => s.MaSinhVien == maSinhVien
    );

    // Bước 2: Nếu không tìm thấy
    if (sv == null)
    {
        return false;
    }

    // Bước 3: Cập nhật tên sinh viên
    sv.HoTen = hoTenMoi;

    // Bước 4: Trả về true nếu thành công
    return true;
}


public bool XoaSinhVien(string maSinhVien)
{
    Student? sv = students.Find(
        s => s.MaSinhVien == maSinhVien
    );

    if (sv == null)
    {
        return false;
    }

    students.Remove(sv);

    return true;
}
public List<Student> LocSinhVienTheoTuoi(int tuoiToiThieu)
{
    List<Student> ketQua = students
        .Where(sv => sv.Tuoi >= tuoiToiThieu)
        .ToList();

    return ketQua;
}
public List<string> LayDanhSachHoTen()
{
    return students
    .Select(sv => sv.HoTen)
    .ToList();

}
public List<Student> SapXepTheoTuoi()
{
    return students
        .OrderBy(sv => sv.Tuoi)
        .ToList();
}
public int DemSinhVienTheoTuoi(int tuoiToiThieu)
{
    return students.Count(sv => sv.Tuoi >= tuoiToiThieu);

}
// Tính tổng tuổi
public int TinhTongTuoi()
{
    return students.Sum(sv => sv.Tuoi);
}

// Tính tuổi trung bình
public double TinhTuoiTrungBinh()
{
    if (!students.Any())
    {
        return 0;
    }

    return students.Average(sv => sv.Tuoi);
}

// Tìm tuổi nhỏ nhất
public int TimTuoiNhoNhat()
{
    if (!students.Any())
    {
        return 0;
    }

    return students.Min(sv => sv.Tuoi);
}

// Tìm tuổi lớn nhất
public int TimTuoiLonNhat()
{
    if (!students.Any())
    {
        return 0;
    }

    return students.Max(sv => sv.Tuoi);
}

public List<Student> LaySinhVienPhanTrang(int page, int pageSize)
{
    return students
        .OrderBy(sv => sv.MaSinhVien)
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();
}
public List<string> LayHoTenSinhVienTheoTuoi(int tuoiToiThieu)
{
    return students
        .Where(sv => sv.Tuoi >= tuoiToiThieu)
        .OrderByDescending(sv => sv.Tuoi)
        .Select(sv => sv.HoTen)
        .ToList();
}
public async Task<List<Student>> LayDanhSachSinhVienAsync()
{
    Console.WriteLine("Dang lay du lieu...");

    await Task.Delay(3000);

    return new List<Student>(students);
}

}
