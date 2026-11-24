// using Microsoft.AspNetCore.Mvc; // cho phép sử dụng các thành phần của ASP.NET Core MVC như ControllerBase, IActionResult, httpget, apicontroller
// namespace StudentManagementAPI.Controllers; // namespace dùng để tổ chức các class và tránh xung đột tên các class trong project
// [ApiController] // thuộc tính attribute bổ sung cho code
// [Route("api/students")] // quy định hướng dẫn cơ sở để client truy cập controller này
// public class StudentController : ControllerBase // Dấu : trong bài inheritance( kế thừa) học tuần 2
// { //studentcontroller kế thừa class controllerbase của ASP.Net core giúp sử dụng những method có sẵn
//     [HttpGet] // Dòng quy định HTTP Method
//     public IActionResult GetStudents()
//     {
//         return Ok ("Danh sach sinh vien");

//     }
// }
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers;

[ApiController]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStudents()
    {
        List<Student> students = new List<Student>
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
            }
        };

        return Ok(students);
    }
}