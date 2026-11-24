public class Student
{
    public string MaSinhVien { get; set; }
    public string HoTen { get; set; }
    private int _tuoi;

    public int Tuoi
   {
       get { return _tuoi; }
       private set { _tuoi = value; }
   }

    // Constructor
    public Student(string ma, string ten, int tuoi)
    {
        this.MaSinhVien = ma;
        this.HoTen = ten;
        this.Tuoi = tuoi;
    }
    // Constructor chỉ nhận mã và tên
    public Student(string ma, string ten) : this(ma, ten, 0)
    {
    }
    public bool CapNhatTuoi(int tuoiMoi) // Cho phép program.cs gọi phương thức
    {// bool: Phương thức trả về có hoặc không
        if (tuoiMoi <=0 || tuoiMoi >120) // Nếu tuổi nhỏ hơn bằng 0 hoặc lớn hơn 120 thì về false
        {
            return false;
        }
        Tuoi = tuoiMoi;
        return true;
    }


}
