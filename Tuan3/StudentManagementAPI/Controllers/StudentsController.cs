// // // // // using Microsoft.AspNetCore.Mvc; // cho phép sử dụng các thành phần của ASP.NET Core MVC như ControllerBase, IActionResult, httpget, apicontroller
// // // // // namespace StudentManagementAPI.Controllers; // namespace dùng để tổ chức các class và tránh xung đột tên các class trong project
// // // // // [ApiController] // thuộc tính attribute bổ sung cho code
// // // // // [Route("api/students")] // quy định hướng dẫn cơ sở để client truy cập controller này
// // // // // public class StudentController : ControllerBase // Dấu : trong bài inheritance( kế thừa) học tuần 2
// // // // // { //studentcontroller kế thừa class controllerbase của ASP.Net core giúp sử dụng những method có sẵn
// // // // //     [HttpGet] // Dòng quy định HTTP Method
// // // // //     public IActionResult GetStudents()
// // // // //     {
// // // // //         return Ok ("Danh sach sinh vien");

// // // // //     }
// // // // // }
// // // // using Microsoft.AspNetCore.Mvc;
// // // // using StudentManagementAPI.Models;

// // // // namespace StudentManagementAPI.Controllers;

// // // // [ApiController]
// // // // [Route("api/students")]
// // // // public class StudentsController : ControllerBase
// // // // {
// // // //     // [HttpGet]
// // // //     // public IActionResult GetStudents()
// // // //     // {
// // // //     //     List<Student> students = new List<Student>
// // // //     //     {
// // // //     //         new Student
// // // //     //         {
// // // //     //             MaSinhVien = "SV01",
// // // //     //             HoTen = "Nguyen Van An",
// // // //     //             Tuoi = 20
// // // //     //         },
// // // //     //         new Student
// // // //     //         {
// // // //     //             MaSinhVien = "SV02",
// // // //     //             HoTen = "Tran Thi Mai",
// // // //     //             Tuoi = 21
// // // //     //         }
// // // //     //     };

// // // //     //     return Ok(students);
// // // //     // }
// // // //     [HttpGet("{maSinhVien}")]
// // // //     public IActionResult GetStudentById(string maSinhVien)
// // // //     {
// // // //         Student? student = students.FirstOrDefault(
// // // //             s => s.MaSinhVien == maSinhVien
// // // //         );
// // // //         if (student == null)
// // // //         {
// // // //             return NotFound("Khong tim thay sinh vien");

// // // //         }
// // // //         return Ok(student);
// // // //     }
// // // // }
// // // using Microsoft.AspNetCore.Mvc;
// // // using StudentManagementAPI.Models;

// // // namespace StudentManagementAPI.Controllers;

// // // [ApiController]
// // // [Route("api/students")]
// // // public class StudentsController : ControllerBase
// // // {
// // //     private readonly List<Student> students = new List<Student>
// // //     {
// // //         new Student
// // //         {
// // //             MaSinhVien = "SV01",
// // //             HoTen = "Nguyen Van An",
// // //             Tuoi = 20
// // //         },
// // //         new Student
// // //         {
// // //             MaSinhVien = "SV02",
// // //             HoTen = "Tran Thi Mai",
// // //             Tuoi = 21
// // //         },
// // //         new Student
// // //         {
// // //             MaSinhVien = "SV03",
// // //             HoTen = "Le Van Nam",
// // //             Tuoi = 22
// // //         }
// // //     };

// // //     // [HttpGet]
// // //     // public IActionResult GetStudents()
// // //     // {
// // //     //     return Ok(students);
// // //     // }
// // //     [HttpGet]
// // //     public IActionResult GetStudents(int? tuoiToiThieu)
// // //     {
// // //         if (tuoiToiThieu.HasValue)// Kiểm tra xem client có truyền giá trị tuổi hay không
// // //         {
// // //             var ketQua = students.Where(s => s.Tuoi >= tuoiToiThieu.Value).ToList();
// // //             return Ok(ketQua);

// // //         }
// // //         return Ok(students);
// // //     }

// // //     [HttpGet("{maSinhVien}")]
// // //     public IActionResult GetStudentById(string maSinhVien)
// // //     {
// // //         Student? student = students.FirstOrDefault(
// // //             s => s.MaSinhVien == maSinhVien
// // //         );

// // //         if (student == null)
// // //         {
// // //             return NotFound("Khong tim thay sinh vien");
// // //         }

// // //         return Ok(student);
// // //     }
// // // }


// // using Microsoft.AspNetCore.Mvc;
// // using StudentManagementAPI.Models;
// // using StudentManagementAPI.Services;

// // namespace StudentManagementAPI.Controllers;

// // [ApiController]
// // [Route("api/students")]
// // public class StudentsController : ControllerBase
// // {
// //     private readonly IStudentService _studentService;// khai báo 1 field để lưu đối tượng Service mà Controller sử

// //     // Nhận Service thông qua Constructor
// //     public StudentsController(IStudentService studentService)
// //     {
// //         _studentService = studentService;
// //     }

// //     // Lấy danh sách và lọc sinh viên theo tuổi
// //     [HttpGet]
// //     public IActionResult GetStudents(int? tuoiToiThieu)
// //     {
// //         var students = _studentService.LayDanhSachSinhVien(tuoiToiThieu);

// //         return Ok(students);
// //     }

// //     // Tìm sinh viên theo mã
// //     [HttpGet("{maSinhVien}")]
// //     public IActionResult GetStudentById(string maSinhVien)
// //     {
// //         Student? student = _studentService.TimSinhVienTheoMa(maSinhVien);

// //         if (student == null)
// //         {
// //             return NotFound("Khong tim thay sinh vien");
// //         }

// //         return Ok(student);
// //     }
// // }


// using Microsoft.AspNetCore.Mvc;
// using System.ComponentModel.DataAnnotations;
// using StudentManagementAPI.Models;
// using StudentManagementAPI.Services;
// using StudentManagementAPI.DTOs;

// namespace StudentManagementAPI.Controllers;

// [ApiController]
// [Route("api/students")]
// public class StudentsController : ControllerBase
// {
//     private readonly IStudentService _studentService;

//     public StudentsController(IStudentService studentService)
//     {
//         _studentService = studentService;
//     }

//     // GET: Lấy danh sách sinh viên
//     [HttpGet]
//     public IActionResult GetStudents(
//         [FromQuery] int? tuoiToiThieu,
//         [FromQuery] string? keyword,
//         [FromQuery] bool giamDan = false,
//         [FromQuery, Range(1, 100000)] int page = 1,
//         [FromQuery, Range(1, 100)] int pageSize = 10)
//     {
//         var students = _studentService.LayDanhSachSinhVien(
//             tuoiToiThieu,
//             keyword,
//             giamDan,
//             page,
//             pageSize
//         );

//         var ketQua = students.Select(ToResponse).ToList();

//         return Ok(ketQua);
//     }

//     // GET: Tìm sinh viên theo mã
//     [HttpGet("{maSinhVien}")]
//     public IActionResult GetStudentById(string maSinhVien)
//     {
//         Student? student = _studentService
//             .TimSinhVienTheoMa(maSinhVien);

//         if (student == null)
//         {
//             return NotFound("Khong tim thay sinh vien");
//         }

//         return Ok(ToResponse(student));
//     }

//     // POST: Thêm sinh viên
//     [HttpPost]
//     public IActionResult CreateStudent(
//         [FromBody] CreateStudentDto dto)
//     {
//         Student student = new Student
//         {
//             MaSinhVien = dto.MaSinhVien,
//             HoTen = dto.HoTen.Trim(),
//             Tuoi = dto.Tuoi
//         };

//         bool thanhCong = _studentService.ThemSinhVien(student);

//         if (!thanhCong)
//         {
//             return Conflict("Ma sinh vien da ton tai");
//         }

//         return CreatedAtAction(
//             nameof(GetStudentById),
//             new { maSinhVien = student.MaSinhVien },
//             ToResponse(student)
//         );
//     }

//     // PUT: Cập nhật sinh viên
//     [HttpPut("{maSinhVien}")]
//     public IActionResult UpdateStudent(
//         string maSinhVien,
//         [FromBody] UpdateStudentDto dto)
//     {
//         bool thanhCong = _studentService.CapNhatSinhVien(
//             maSinhVien,
//             dto.HoTen.Trim(),
//             dto.Tuoi
//         );

//         if (!thanhCong)
//         {
//             return NotFound("Khong tim thay sinh vien");
//         }

//         return NoContent();
//     }

//     // DELETE: Xóa sinh viên
//     [HttpDelete("{maSinhVien}")]
//     public IActionResult DeleteStudent(string maSinhVien)
//     {
//         bool thanhCong = _studentService.XoaSinhVien(maSinhVien);

//         if (!thanhCong)
//         {
//             return NotFound("Khong tim thay sinh vien");
//         }

//         return NoContent();
//     }

//     // Chuyển Student Model thành Response DTO
//     private static StudentResponseDto ToResponse(Student student)
//     {
//         return new StudentResponseDto
//         {
//             MaSinhVien = student.MaSinhVien,
//             HoTen = student.HoTen,
//             Tuoi = student.Tuoi
//         };
//     }
// }


using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Common;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    // GET: Lấy danh sách sinh viên
    [HttpGet]
    public IActionResult GetStudents(
        [FromQuery] int? tuoiToiThieu,
        [FromQuery] string? keyword,
        [FromQuery] bool giamDan = false,
        [FromQuery, Range(1, 100000)] int page = 1,
        [FromQuery, Range(1, 100)] int pageSize = 10)
    {
        var students = _studentService.LayDanhSachSinhVien(
            tuoiToiThieu,
            keyword,
            giamDan,
            page,
            pageSize
        );

        var ketQua = students.Select(ToResponse).ToList();

        return Ok(new ApiResponse<List<StudentResponseDto>>
        {
            Success = true,
            Message = "Lay danh sach sinh vien thanh cong",
            Data = ketQua
        });
    }

    // GET: Tìm sinh viên theo mã
    [HttpGet("{maSinhVien}")]
    public IActionResult GetStudentById(string maSinhVien)
    {
        Student? student = _studentService
            .TimSinhVienTheoMa(maSinhVien);

        if (student == null)
        {
            return NotFound(new ApiResponse<object>
            {
                Success = false,
                Message = "Khong tim thay sinh vien"
            });
        }

        return Ok(new ApiResponse<StudentResponseDto>
        {
            Success = true,
            Message = "Tim thay sinh vien",
            Data = ToResponse(student)
        });
    }

    // POST: Thêm sinh viên
    [HttpPost]
    public IActionResult CreateStudent(
        [FromBody] CreateStudentDto dto)
    {
        Student student = new Student
        {
            MaSinhVien = dto.MaSinhVien,
            HoTen = dto.HoTen.Trim(),
            Tuoi = dto.Tuoi
        };

        bool thanhCong = _studentService.ThemSinhVien(student);

        if (!thanhCong)
        {
            return Conflict(new ApiResponse<object>
            {
                Success = false,
                Message = "Ma sinh vien da ton tai"
            });
        }

        return CreatedAtAction(
            nameof(GetStudentById),
            new { maSinhVien = student.MaSinhVien },
            new ApiResponse<StudentResponseDto>
            {
                Success = true,
                Message = "Them sinh vien thanh cong",
                Data = ToResponse(student)
            }
        );
    }

    // PUT: Cập nhật sinh viên
    [HttpPut("{maSinhVien}")]
    public IActionResult UpdateStudent(
        string maSinhVien,
        [FromBody] UpdateStudentDto dto)
    {
        bool thanhCong = _studentService.CapNhatSinhVien(
            maSinhVien,
            dto.HoTen.Trim(),
            dto.Tuoi
        );

        if (!thanhCong)
        {
            return NotFound(new ApiResponse<object>
            {
                Success = false,
                Message = "Khong tim thay sinh vien"
            });
        }

        return NoContent();
    }

    // DELETE: Xóa sinh viên
    [HttpDelete("{maSinhVien}")]
    public IActionResult DeleteStudent(string maSinhVien)
    {
        bool thanhCong = _studentService.XoaSinhVien(maSinhVien);

        if (!thanhCong)
        {
            return NotFound(new ApiResponse<object>
            {
                Success = false,
                Message = "Khong tim thay sinh vien"
            });
        }

        return NoContent();
    }

    // Chuyển Student Model thành Response DTO
    private static StudentResponseDto ToResponse(Student student)
    {
        return new StudentResponseDto
        {
            MaSinhVien = student.MaSinhVien,
            HoTen = student.HoTen,
            Tuoi = student.Tuoi
        };
    }
}
