// using StudentManagementAPI.Models;

// namespace StudentManagementAPI.Services;

// public class StudentService : IStudentService
// {
//     private readonly List<Student> students = new List<Student>
//     {
//         new Student
//         {
//             MaSinhVien = "SV01",
//             HoTen = "Nguyen Van An",
//             Tuoi = 20
//         },
//         new Student
//         {
//             MaSinhVien = "SV02",
//             HoTen = "Tran Thi Mai",
//             Tuoi = 21
//         },
//         new Student
//         {
//             MaSinhVien = "SV03",
//             HoTen = "Le Van Nam",
//             Tuoi = 22
//         }
//     };

//     public List<Student> LayDanhSachSinhVien(int? tuoiToiThieu)
//     {
//         if (tuoiToiThieu.HasValue)
//         {
//             return students
//                 .Where(s => s.Tuoi >= tuoiToiThieu.Value)
//                 .ToList();
//         }

//         return students.ToList();
//     }

//     public Student? TimSinhVienTheoMa(string maSinhVien)
//     {
//         return students.FirstOrDefault(
//             s => s.MaSinhVien == maSinhVien
//         );
//     }
// }


using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services;

public class StudentService : IStudentService
{
    private readonly List<Student> students = new List<Student>
    {
        new Student
        {
            MaSinhVien = "SV01",
            HoTen = "Nguyen Van An",
            Tuoi = 20
        },
        new Student
        {
            MaSinhVien = "SV02",
            HoTen = "Tran Thi Mai",
            Tuoi = 21
        },
        new Student
        {
            MaSinhVien = "SV03",
            HoTen = "Le Van Nam",
            Tuoi = 22
        }
    };

    // Lấy danh sách, tìm kiếm, lọc, sắp xếp và phân trang
    public List<Student> LayDanhSachSinhVien(
        int? tuoiToiThieu,
        string? keyword,
        bool giamDan,
        int page,
        int pageSize)
    {
        IEnumerable<Student> query = students;

        // Lọc theo tuổi
        if (tuoiToiThieu.HasValue)
        {
            query = query.Where(
                s => s.Tuoi >= tuoiToiThieu.Value
            );
        }

        // Tìm kiếm theo họ tên
        if (!string.IsNullOrWhiteSpace(keyword))
        {
            string tuKhoa = keyword.Trim();

            query = query.Where(s => s.HoTen.Contains(
                tuKhoa,
                StringComparison.OrdinalIgnoreCase
            ));
        }

        // Sắp xếp theo tuổi
        if (giamDan)
        {
            query = query.OrderByDescending(s => s.Tuoi)
                         .ThenBy(s => s.MaSinhVien);
        }
        else
        {
            query = query.OrderBy(s => s.Tuoi)
                         .ThenBy(s => s.MaSinhVien);
        }

        // Phân trang và trả về kết quả
        return query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    // Tìm sinh viên theo mã
    public Student? TimSinhVienTheoMa(string maSinhVien)
    {
        return students.FirstOrDefault(s =>
            string.Equals(
                s.MaSinhVien,
                maSinhVien,
                StringComparison.OrdinalIgnoreCase
            )
        );
    }

    // Thêm sinh viên
    public bool ThemSinhVien(Student student)
    {
        bool tonTai = students.Any(s =>
            string.Equals(
                s.MaSinhVien,
                student.MaSinhVien,
                StringComparison.OrdinalIgnoreCase
            )
        );

        if (tonTai)
        {
            return false;
        }

        students.Add(student);
        return true;
    }

    // Cập nhật sinh viên
    public bool CapNhatSinhVien(
        string maSinhVien,
        string hoTen,
        int tuoi)
    {
        Student? student = TimSinhVienTheoMa(maSinhVien);

        if (student == null)
        {
            return false;
        }

        student.HoTen = hoTen;
        student.Tuoi = tuoi;

        return true;
    }

    // Xóa sinh viên
    public bool XoaSinhVien(string maSinhVien)
    {
        Student? student = TimSinhVienTheoMa(maSinhVien);

        if (student == null)
        {
            return false;
        }

        students.Remove(student);
        return true;
    }
}
