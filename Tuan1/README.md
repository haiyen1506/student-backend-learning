# TUẦN 1 - C# CƠ BẢN VÀ GIT

## 1. Nội dung học tập

Trong tuần này, em đã tìm hiểu và thực hành các kiến thức C# cơ bản thông qua chương trình Console quản lý thông tin và tính điểm sinh viên.

### 1.1. C# cơ bản

- Khai báo và sử dụng biến (Variable).
- Sử dụng các kiểu dữ liệu `string`, `int`, `double`, `bool`.
- Làm quen với Nullable thông qua `string?`.
- Sử dụng toán tử số học, so sánh và logic.
- Nhập dữ liệu bằng `Console.ReadLine()`.
- Hiển thị kết quả bằng `Console.WriteLine()`.

### 1.2. Input Validation

- Chuyển đổi dữ liệu đầu vào bằng `int.TryParse()` và `double.TryParse()`.
- Kiểm tra họ tên không được để trống.
- Kiểm tra tuổi hợp lệ trong khoảng 1–120.
- Kiểm tra điểm các môn trong khoảng 0–10.
- Xử lý trường hợp người dùng nhập chữ thay vì số.

**Ghi chú:** Nội dung `Parse` và so sánh với `TryParse` cần bổ sung bài thực hành riêng.

### 1.3. Cấu trúc điều khiển

- Sử dụng `if`, `else if`, `else` để kiểm tra điều kiện và xếp loại.
- Sử dụng `while` để tạo menu lặp.
- Sử dụng `switch/case` để xử lý lựa chọn.
- Tạo hàm `NhapVaTinhDiem()` để tách chức năng nhập và tính điểm sinh viên.

## 2. Bài thực hành: HelloStudent

**Loại chương trình:** C# Console Application.

**Source code:** [HelloStudent](../console-manager/HelloStudent/)

**File chính:** [Program.cs](../console-manager/HelloStudent/Program.cs)

### Các chức năng đã triển khai

1. Hiển thị menu chương trình.
2. Nhập họ tên và tuổi sinh viên.
3. Kiểm tra thông tin nhập vào.
4. Nhập điểm Toán, Văn và Tiếng Anh.
5. Kiểm tra điểm hợp lệ.
6. Tính điểm trung bình ba môn.
7. Xếp loại học lực: Giỏi, Khá, Trung bình, Yếu.
8. Xét kết quả Đạt hoặc Không đạt.
9. Quay lại menu sau khi thực hiện chức năng.
10. Thoát chương trình khi chọn `0`.

### Quy tắc xếp loại trong bài thực hành

| Điểm trung bình | Xếp loại |
|---|---|
| >= 8.0 | Giỏi |
| >= 6.5 và < 8.0 | Khá |
| >= 5.0 và < 6.5 | Trung bình |
| < 5.0 | Yếu |

- Điểm trung bình từ 5 trở lên: Đạt.
- Điểm trung bình dưới 5: Không đạt.

## 3. Cách chạy chương trình

**Yêu cầu:** Máy tính đã cài .NET SDK tương thích với project.

Mở PowerShell tại thư mục `student-backend-learning` và chạy:

```powershell
dotnet run --project .\console-manager\HelloStudent\HelloStudent.csproj
```

### Ví dụ kết quả mong đợi

```text
========== QUẢN LÝ SINH VIÊN ==========
1. Nhập thông tin và tính điểm sinh viên
0. Thoát chương trình

Mời bạn chọn: 1

Nhập họ tên sinh viên: Nguyen Van A
Nhập tuổi sinh viên: 20
Nhập điểm Toán: 8
Nhập điểm Văn: 7
Nhập điểm Anh: 9

--- KẾT QUẢ HỌC TẬP ---
Điểm trung bình: 8.00
Xếp loại: Giỏi
Kết quả: Đạt
```

*Ví dụ minh họa; cách hiển thị dấu thập phân phụ thuộc cấu hình ngôn ngữ của máy.*

## 4. Kiểm thử chương trình

Các trường hợp đã thực hành và phản hồi kết quả:

| Trường hợp | Kết quả |
|---|---|
| Nhập tuổi 20 | Chấp nhận |
| Nhập tuổi `abc` | Báo tuổi không hợp lệ |
| Nhập điểm Toán 2 | Chấp nhận |
| Nhập điểm Toán `abc` | Báo điểm không hợp lệ |
| Chọn chức năng nhập sinh viên | Menu gọi hàm nhập và tính điểm |
| Hoàn thành chức năng | Menu hiển thị lại |

Các tình huống biên khác sẽ tiếp tục được kiểm thử và bổ sung.

## 5. Git và GitHub

Các thao tác đã thực hành:

- `git init` — khởi tạo repository.
- `git status` — kiểm tra thay đổi.
- `git add` — chuẩn bị file.
- `git commit` — lưu phiên bản code.
- `git push` — đưa code lên GitHub.
- `.gitignore` — loại trừ các file không cần thiết.


# Student Management API - Week 03

## 1. Giới thiệu

Dự án RESTful Web API quản lý sinh viên được xây dựng
bằng ASP.NET Core Web API (.NET 8).

Dự án thuộc lộ trình học ASP.NET Core Backend Developer.

## 2. Công nghệ sử dụng

- C#
- .NET 8
- ASP.NET Core Web API
- Swagger / OpenAPI
- LINQ
- Dependency Injection
- Data Annotations
- Git và GitHub

## 3. Chức năng

- Lấy danh sách sinh viên.
- Tìm sinh viên theo mã.
- Thêm sinh viên.
- Cập nhật thông tin sinh viên.
- Xóa sinh viên.
- Kiểm tra trùng mã sinh viên.
- Tìm kiếm sinh viên theo tên.
- Lọc sinh viên theo tuổi.
- Sắp xếp tăng dần và giảm dần.
- Phân trang dữ liệu.
- Kiểm tra dữ liệu đầu vào.
- Chuẩn hóa API Response.

## 4. Cấu trúc project

- Controllers: Tiếp nhận và xử lý HTTP Request.
- Models: Mô tả dữ liệu sinh viên.
- DTOs: Quy định dữ liệu đầu vào và đầu ra.
- Services: Xử lý logic nghiệp vụ.
- Common: Chứa cấu trúc ApiResponse dùng chung.
- Program.cs: Cấu hình và khởi chạy ứng dụng.

## 5. API Endpoints

| Method | Endpoint | Chức năng |
|--------|----------|-----------|
| GET | /api/students | Lấy danh sách |
| GET | /api/students/{maSinhVien} | Tìm theo mã |
| POST | /api/students | Thêm sinh viên |
| PUT | /api/students/{maSinhVien} | Cập nhật |
| DELETE | /api/students/{maSinhVien} | Xóa |

## 6. Query Parameters

| Parameter | Ý nghĩa |
|-----------|---------|
| tuoiToiThieu | Lọc theo tuổi tối thiểu |
| keyword | Tìm kiếm theo tên |
| giamDan | Sắp xếp giảm dần |
| page | Số trang |
| pageSize | Số sinh viên mỗi trang |

## 7. HTTP Status Codes

- 200 OK
- 201 Created
- 204 No Content
- 400 Bad Request
- 404 Not Found
- 409 Conflict

## 8. Cấu trúc ApiResponse

    {
        "success": true,
        "message": "Thanh cong",
        "data": [],
        "errors": null
    }

HTTP 204 không chứa Response Body.

## 9. Hướng dẫn chạy project

Yêu cầu: Cài đặt .NET 8 SDK.

Chạy terminal tại thư mục StudentManagementAPI:

    dotnet restore
    dotnet build
    dotnet run

Truy cập Swagger:

    http://localhost:5259/swagger

## 10. Kiến thức đã thực hành

- HTTP và RESTful API.
- Controller và Routing.
- Model Binding.
- DTO và Validation.
- Service và Interface.
- Dependency Injection.
- CRUD.
- LINQ.
- Pagination.
- Chuẩn hóa API Response.

## 11. Hạn chế hiện tại

- Dữ liệu được lưu trong RAM.
- Dữ liệu thay đổi sẽ mất khi khởi động lại ứng dụng.
- Chưa kết nối SQL Server.
- Chưa xử lý truy cập đồng thời an toàn.
- Chưa có Authentication và Authorization hoàn chỉnh.
- Chưa có Global Exception Handling.
- Chưa hoàn thành đầy đủ các trường hợp kiểm thử.
- Chưa có kiểm thử tự động.
