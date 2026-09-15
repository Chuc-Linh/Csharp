using System;
/*
Chương trình: BÀI TẬP BUỔI 4
Nội dung: 5 bài tập mẫu + 5 bài tập cơ bản + 5 bài tập nâng cao
Tác giả: Bùi Phúc Hưng
Ngày viết: 11/09/2026
*/

/*
Phát biểu đề bài: TinhChatSo.*
Cho số tự nhiên n có 4 chữ số. Hãy xác định:
(a) có biểu diễn n có đối xứng không?
(b) n có 3 chữ số giống nhau không?
(c) n có 4 chữ số khác nhau không?
(Lưu ý: sắp xếp các chữ số)

Ý tưởng:
Nhập số tự nhiên n có 4 chữ số
Tách n thành 4 chữ số: a, b, c, d theo hàng nghìn, trăm, chục, đơn vị
Kiểm tra số đối xứng bằng cách so sánh các chữ số đầu với cuối và chữ số thứ 2 với 3
Kiểm tra có 3 chữ số giống nhau bằng cách so sánh các TH 3 trong 4 số bằng nhau
Kiểm tra 4 chữ số khác nhau bằng cách kiểm tra các chữ số không trùng nhau


Mã giả:
Nhập n
Tách n thành 4 chữ số a, b, c, d

Nếu a == d và b == c
    In số đối xứng

Nếu có 3 chữ số giống nhau
    In có 3 chữ số giống nhau

Nếu 4 chữ số không trùng nhau
    In có 4 chữ số khác nhau
    
*/
namespace NMLT.Buoi04
{
    public class TinhChatSo
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n;
            int a, b, c, d;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so n: ");
            n = int.Parse(Console.ReadLine());

            // Tách các chữ số theo hàng
            a = n / 1000;
            b = n / 100 % 10;
            c = n / 10 % 10;
            d = n % 10;

            // Kiểm tra số đối xứng
            if (a == d && b == c)
                Console.WriteLine("{0} la so doi xung.", n);
            else
                Console.WriteLine("{0} khong la so doi xung.", n);

            // Kiểm tra có 3 chữ số giống nhau
            if ((a == b && b == c) ||
                (a == b && b == d) ||
                (a == c && c == d) ||
                (b == c && c == d))
                Console.WriteLine("{0} co 3 chu so giong nhau.", n);
            else
                Console.WriteLine("{0} khong co 3 chu so giong nhau.", n);

            // Kiểm tra có 4 chữ số khác nhau
            if (a != b && a != c && a != d &&
                b != c && b != d &&
                c != d)
                Console.WriteLine("{0} co 4 chu so khac nhau.", n);
            else
                Console.WriteLine("{0} khong co 4 chu so khac nhau.", n);
        }
    }
}