// using StudentManagementAPI.Models;
// namespace StudentManagementAPI.Services;
// public interface IStudentService
// {
//     List<Student> LayDanhSachSinhVien(int? tuoiToiThieu);
//     Student? TimSinhVienTheoMa(string maSinhVien);
    
// }

using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services;

public interface IStudentService
{
    List<Student> LayDanhSachSinhVien(
        int? tuoiToiThieu,
        string? keyword,
        bool giamDan,
        int page,
        int pageSize
    );

    Student? TimSinhVienTheoMa(string maSinhVien);

    bool ThemSinhVien(Student student);

    bool CapNhatSinhVien(
        string maSinhVien,
        string hoTen,
        int tuoi
    );

    bool XoaSinhVien(string maSinhVien);
}