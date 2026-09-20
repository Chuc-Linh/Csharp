// Ý TƯỞNG:
//   C# có hàm Math.Max(x, y) và Math.Min(x, y), mỗi hàm chỉ so sánh được 2 số một lúc.
//   =>Để tìm max/min của 5 số, ta "gộp" dần từng cặp lại:
//
//       max(a,b,c,d,e) = Max( Max( Max( Max(a,b), c), d), e)
//       min(a,b,c,d,e) = Min( Min( Min( Min(a,b), c), d), e)
//
//     so sánh a với b trước, lấy kết quả so với c, lấy kết quả đó so với d, rồi so với e -> ra giá trị cuối cùng.

// MÃ GIẢ:
//   BẮT ĐẦU
//     In ra: "Moi ban nhap 5 so a, b, c, d ,e: "
//     Đọc 1 dòng, tách thành 5 số a, b, c, d, e
//     max <- lớn nhất trong 5 số (gộp dần từng cặp)
//     min <- nhỏ nhất trong 5 số (gộp dần từng cặp)
//     In ra: "Gia tri lon nhat cua a, b, c, d, e la max."
//     In ra: "Gia tri nho nhat cua a, b, c, d, e la min."
//   KẾT THÚC


// TEST CASE:
//   Input:  1 5 6 2 8
//   Output: Gia tri lon nhat cua 1, 5, 6, 2, 8 la 8.
//           Gia tri nho nhat cua 1, 5, 6, 2, 8 la 1.

//   Input:  10 10 10 10 10   (5 số bằng nhau)
//   Output: Gia tri lon nhat cua 10, 10, 10, 10, 10 la 10.
//           Gia tri nho nhat cua 10, 10, 10, 10, 10 la 10.

//   Input:  -3 -8 0 -1 -5   (có số âm)
//   Output: Gia tri lon nhat cua -3, -8, 0, -1, -5 la 0.
//           Gia tri nho nhat cua -3, -8, 0, -1, -5 la -8.



using System;
 
namespace Buoi03
{
    class Baitap1
    {
        public static void Mainbt1()
        {
            // Bước 1: Đọc 5 số trên cùng 1 dòng, cách nhau bởi dấu cách
            Console.Write("Moi ban nhap 5 so a, b, c, d ,e: ");
            string input = Console.ReadLine()!;
            string[] parts = input.Split(' ');
 
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);
            int d = int.Parse(parts[3]);
            int e = int.Parse(parts[4]);
 
            // Bước 2: Gộp dần từng cặp để tìm max/min của cả 5 số
            int max = Math.Max(Math.Max(Math.Max(Math.Max(a, b), c), d), e);
            int min = Math.Min(Math.Min(Math.Min(Math.Min(a, b), c), d), e);
 
            // Bước 3: In kết quả
            Console.WriteLine($"Gia tri lon nhat cua {a}, {b}, {c}, {d}, {e} la {max}.");
            Console.WriteLine($"Gia tri nho nhat cua {a}, {b}, {c}, {d}, {e} la {min}.");
        }
    }
}
