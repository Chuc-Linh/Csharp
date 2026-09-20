using System;
/*
Chương trình: BÀI TẬP BUỔI 5
Tác giả: Bùi Phúc Hưng
Ngày viết: 12/09/2026
*/

/*
Phát biểu đề bài: GiaiThua.*

Nhập vào số nguyên dương n (1 <= n <= 12). Hãy tính n!.

Ý tưởng:
Nhập n
Ta cần một biến để lưu kết quả, ban đầu cho bằng 1
Sau đó cho i chạy từ 1 đến n, mỗi lần lấy kết quả nhân với i

Mã giả:
Nhập n
Cho i chạy từ 1 đến n
    kq = kq * i
In KQ
*/

using System;

namespace NMLT.Buoi05
{
    public class GiaiThua
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int n;
            int kq = 1;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap so n: ");
            n = int.Parse(Console.ReadLine());

            // Tính giai thừa
            for (int i = 1; i <= n; i++)
            {
                kq = kq * i;
            }

            // Xuất kết quả
            Console.WriteLine("{0}! = {1}", n, kq);
        }
    }
}

