using System;
/*
Chương trình: BÀI TẬP BUỔI 5
Tác giả: Bùi Phúc Hưng
Ngày viết: 12/09/2026
*/

/*
Phát biểu đề bài: GiaTriBieuThuc.*

Nhập vào số nguyên dương n. Hãy tính giá trị của hai biểu thức:
S1 = 1/1 + 1/2 + ... + 1/n
S2 = 1/n - 1/(n-1) + 1/(n-2) - ... + (-1)^(n+1)*1/1

Ý tưởng:
Cho người dùng nhập số n
Dùng vòng lặp để tính tổng S1 và S2

Mã giả:
Nhập n
S1 = 0
Cho i chạy từ 1 đến n
    S1 = S1 + 1/i
S2 = 0
Duyệt i từ n xuống 1
    Cộng hoặc trừ 1/i vào S2
In ra KQ S1 và S2
*/

using System;

namespace NMLT.Buoi05
{
    public class GiaTriBieuThuc
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n;
            double s1 = 0;
            double s2 = 0;
            int dau = 1;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());

            // Tính S1
            for (int i = 1; i <= n; i++)
            {
                s1 = s1 + 1.0 / i;
            }

            // Tính S2
            for (int i = n; i >= 1; i--)
            {
                s2 = s2 + dau * (1.0 / i);
                dau = -dau;
            }

            // Xuất kết quả
            Console.WriteLine("S1(n={0}) = {1}", n, s1);
            Console.WriteLine("S2(n={0}) = {1}", n, s2);
        }
    }
}