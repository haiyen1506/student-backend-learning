using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.DTOs;

// Dữ liệu gửi lên khi thêm sinh viên
public class CreateStudentDto
{
    [Required]
    [RegularExpression(@"^[a-zA-Z0-9-]+$")]
    public string MaSinhVien { get; set; } = string.Empty;

    [Required]
    public string HoTen { get; set; } = string.Empty;

    [Range(1, 150)]
    public int Tuoi { get; set; }
}

// Dữ liệu gửi lên khi cập nhật sinh viên
public class UpdateStudentDto
{
    [Required]
    public string HoTen { get; set; } = string.Empty;

    [Range(1, 150)]
    public int Tuoi { get; set; }
}

// Dữ liệu trả về cho Client
public class StudentResponseDto
{
    public string MaSinhVien { get; set; } = string.Empty;

    public string HoTen { get; set; } = string.Empty;

    public int Tuoi { get; set; }
}