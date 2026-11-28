namespace StudentManagementAPI.Common;
public class ApiResponse<T>
{
    //Trạng thái xử lý
    public bool Success {get; set;}
    //Thông báo kết  quả
    public string Message {get; set;} =  string.Empty;
    //Dữ liệu trả về
    public T? Data {get; set;}
    //Chi tiết lỗi kiểm tra dữ liệu
    public Dictionary<string, string []>? Errors {get; set;}
}