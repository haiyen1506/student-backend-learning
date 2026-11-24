public interface IStudentService
{
    int DemSinhVien();
    bool ThemSinhVien(Student student);
    List <Student> LayDanhSachSinhVien();
    // Student? TimSinhVienTheoMa (string maSinhVien);
    bool CapNhatHoTen(string maSinhVien, string hoTenMoi);
    bool XoaSinhVien(string maSinhVien);
    List<Student> LocSinhVienTheoTuoi(int tuoiToiThieu);
    List<string> LayDanhSachHoTen();
    List<Student> SapXepTheoTuoi();
    Student? TimSinhVienTheoMa(string maSinhVien);
    int DemSinhVienTheoTuoi (int tuoiToiThieu);
    int TinhTongTuoi();
    double TinhTuoiTrungBinh();
    int TimTuoiNhoNhat();
    int TimTuoiLonNhat();
    List<Student> LaySinhVienPhanTrang(int page, int pageSize);
    List<string> LayHoTenSinhVienTheoTuoi(int tuoiToiThieu);
    Task<List<Student>> LayDanhSachSinhVienAsync();



    // List<student>: Kiểu dữ liệu trả về
    //LocSinhVienTheoTuoi	Tên chức năng
    //int tuoiToiThieu	Tuổi tối thiểu cần lọc

}
