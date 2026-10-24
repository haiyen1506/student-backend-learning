Console.OutputEncoding = System.Text.Encoding.UTF8;

// Ví dụ 1: Parse
string input1 = "20";
int tuoi1 = int.Parse(input1);

Console.WriteLine($"Parse thành công: {tuoi1}");

// Ví dụ 2: TryParse
string? input2 = "abc";
bool hopLe = int.TryParse(input2, out int tuoi2);

Console.WriteLine($"TryParse thành công: {hopLe}");
Console.WriteLine($"Giá trị tuổi: {tuoi2}");