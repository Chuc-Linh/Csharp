using System;
/*
Chương trình: BÀI TẬP BUỔI 5
Tác giả: Bùi Phúc Hưng
Ngày viết: 14/09/2026
*/

/*
Phát biểu đề bài: TimBeNhatThoa.*

Nhập vào số thực a. Hãy tìm số nguyên dương n bé nhất thỏa:
1 + 1/2 + 1/3 + ... + 1/n > a

Ý tưởng:
Cho người dùng nhập số thực a
Khởi tạo tổng S = 0 và n = 0
Dùng vòng lặp while: trong khi S <= a, tăng n lên 1 rồi cộng dồn 1/n vào S
Khi S > a thì dừng lại, giá trị n hiện tại chính là số nguyên dương bé nhất cần tìm

Mã giả:
Nhập a
S = 0
n = 0
Trong khi (S <= a)
    n = n + 1
    S = S + 1.0 / n
In ra n
*/

namespace NMLT.Buoi05
{
    public class TimBeNhatThoa
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            double a, S = 0;
            int n = 0;

            // Nhập dữ liệu
            Console.Write("nhap a: ");
            a = double.Parse(Console.ReadLine());

            // Tìm n bé nhất thỏa biểu thức > a
            while (S <= a)
            {
                n++;
                S = S + 1.0 / n;
            }

            // Xuất kết quả
            Console.WriteLine("So nguyen duong n be nhat thoa man la: {0}", n);
        }
    }
}