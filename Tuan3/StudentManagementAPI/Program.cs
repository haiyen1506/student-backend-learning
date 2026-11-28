// using StudentManagementAPI.Services;
// var builder = WebApplication.CreateBuilder(args);

// // // Đăng ký các dịch vụ vào DI Container.


// builder.Services.AddControllers();
// builder.Services.AddSingleton<IStudentService, StudentService>(); // khi có class nào cần IStudentService, hãy cung cấp cho đối tượng StudentService
// // Tìm hiểu thêm về cách cấu hình Swagger/OpenAPI
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Cấu hình quy trình xử lý HTTP Request.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();


using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Services;
using StudentManagementAPI.Common;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký các dịch vụ vào DI Container.

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var errors = context.ModelState
                .Where(x => x.Value != null &&
                            x.Value.Errors.Count > 0)
                .ToDictionary(
                    x => x.Key,
                    x => x.Value!.Errors
                        .Select(e => string.IsNullOrEmpty(e.ErrorMessage)
                            ? "Du lieu khong hop le"
                            : e.ErrorMessage)
                        .ToArray()
                );

            return new BadRequestObjectResult(
                new ApiResponse<object>
                {
                    Success = false,
                    Message = "Du lieu khong hop le",
                    Errors = errors
                }
            );
        };
    });

builder.Services.AddSingleton<IStudentService, StudentService>();

// Tìm hiểu thêm về cách cấu hình Swagger/OpenAPI tại https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Cấu hình quy trình xử lý HTTP Request.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
