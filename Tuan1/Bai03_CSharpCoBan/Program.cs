Console.OutputEncoding = System.Text.Encoding.UTF8; // Thiết lập mã hóa cho đầu ra console giúp hiển thị Tiếng Việt

string hoTen = "Nguyen Van A";
int tuoi = 20;
double diem = 8.5; // double lưu số thực như là 8.5
bool duTuoi = tuoi >=18; // bool lưu giá trị logic true hoặc false

Console.WriteLine($"Họ tên: {hoTen}");
Console.WriteLine($"Tuổi ban đầu:{tuoi}");

tuoi = 21;

Console.WriteLine($"Tuổi sau khi thay đổi:{tuoi}");

int tuoiSinhVien = 20;//Tuổi sinh viên có kiểu số nguyên và gán giá trị 20
bool du18Tuoi = tuoiSinhVien >=18;
Console.WriteLine($"Tuổi: {tuoiSinhVien}");
Console.WriteLine($"Đủ 18 tuổi: {du18Tuoi}");

if (du18Tuoi)
{
    Console.WriteLine("Sinh viên được phép đăng kí");
}
else
{
    Console.WriteLine("Sinh viên chưa đủ tuổi đăng kí");
    
}

// Bài học: if -else if - else

int tuoiKiemTra = 20;

if (tuoiKiemTra <18)
{
    Console.WriteLine("Chưa đủ 18 tuổi");
}

else if (tuoiKiemTra <23)
{
    Console.WriteLine("Thuộc nhóm tuổi từ 18 đến 22");
}

else
{
    Console.WriteLine("Tù 23 tuổi trở lên");
}

//Bài tập vòng lặp for
for (int  i = 1; i<=10; i++)
{
    Console.WriteLine($"Sinh viên thú {i}");
}

 //Vòng lặp while
 //Cú pháp
 // while(dieukien)
 //{
 //  Các câu lệnh thực hiện khi điều kiện đúng
 //}

int j = 1;
while (j<=3)
{
    Console.WriteLine(j);
    j++;
}

//break
while(true)
{
    Console.WriteLine("Mời bạn chọn:");
    //Khai báo biến lựa chọn
    string ? luachon = Console.ReadLine();


    if (luachon == "0")
    {
       Console.WriteLine("Đã thoát menu");
    break; 
    }
}

//Tiểu mục 4: Continue trong C#
//continue: Bỏ qua phàn code còn lại của lượt lặp hiện tại và chuyến sang lượt tiếp theo

for (int i = 1; i<=5; i++)
{
    if(i ==3)
    {
        continue;

    }

    Console.WriteLine(i);
}

// List trong C#

// Cú pháp: List<string> danhSach = new List<string>();
// List là lớp  danh sách
// <string>: Là kiểu dữ liệu của phần tử
// danhSach:  tên biến
// new: tạo đối tượng mới
// List<string>() Khởi tạo danh sách rỗng
//List<int> danhSachTuoi = new List<int>(); // Danh sách lưu số nguyên
//List<string> danhSachTen = new List<string>(); // Danh sách chuỗi

// Bước 1. Tạo danh sách rỗng
List<string> danhsachSinhVien = new List<string>(); // danh sách rỗng, count =0
// Bước 2. Thêm sinh viên
danhsachSinhVien.Add("An"); // Sau câu lệnh này, index 0 là An
danhsachSinhVien.Add("Bình");
danhsachSinhVien.Add("Yến");
danhsachSinhVien.Add("Dũng");
 // index 2
//Bước 3. Hiển thị số lượng
Console.WriteLine ($"Số sinh viên: {danhsachSinhVien.Count}");

// Bước 4. Hiển thị sinh viên đầu tiên
Console.WriteLine($"Sinh viên cuối cùng:{danhsachSinhVien[3]}");


