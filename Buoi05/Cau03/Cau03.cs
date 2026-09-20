using System;
/*
Chương trình: BÀI TẬP BUỔI 5
Tác giả: Bùi Phúc Hưng
Ngày viết: 13/09/2026
*/

/*
Phát biểu đề bài: TongPhanSoSaiSo.*

Nhập vào số thực a và độ sai số epsilon (<= 0.1).Hãy tính tổng sau đây:
S = 1/a + 1/(a+1) +...+ 1/(a+n) ...cho đến khi 1/(a+n) < epsilon

Ý tưởng:
Cho người dùng nhập a và epsilon
Dùng vòng lặp cộng các phân số vào S
Dừng khi phân số nhỏ hơn epsilon

Mã giả:
Nhập a
Nhập epsilon
S = 0
n = 0
Trong khi 1/(a+n) >= epsilon
    S = S + 1/(a+n)
    n = n + 1
In ra S
*/

using System;

namespace NMLT.Buoi05
{
    public class TongPhanSoSaiSo
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            double a, epsilon, S = 0;
            int n = 0;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap sai so epsilon (<= 0.1): ");
            epsilon = double.Parse(Console.ReadLine());

            // Tính tổng
            while (1.0 / (a + n) >= epsilon)
            {
                S = S + 1.0 / (a + n);
                n++;
            }

            // Xuất kết quả
            Console.WriteLine("Gia tri cua bieu thuc S(a = {0}, epsilon = {1}) = {2}", a, epsilon, S);
        }
    }
}