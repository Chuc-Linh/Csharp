//Ý TƯỞNG:
//   - Đây là hàm số "phân đoạn" (piecewise function): tùy giá trị x rơi vào khoảng nào mà dùng công thức tương ứng.
//   - Cách xử lý: dùng if / else if / else, kiểm tra điều kiện lần lượt theo đúng thứ tự các khoảng trong đề bài, vì các khoảng không chồng lấn nhau (mỗi x chỉ rơi vào đúng 1 khoảng).
//   - Lưu ý dùng Math.Pow(x, 4) để tính x^4 (lũy thừa bậc 4).


// MÃ GIẢ:
//   BẮT ĐẦU
//     In ra: "Moi ban nhap so thuc x: "
//     Đọc số thực x

//     NẾU x <= 0 THÌ f1 <- 0
//     NGƯỢC LẠI NẾU x <= 1 THÌ f1 <- x
//     NGƯỢC LẠI f1 <- x^4

//     NẾU x <= 2 THÌ f2 <- x^2 + 4x + 5
//     NGƯỢC LẠI f2 <- 1 / (x^2 + 4x + 5)

//     In ra: "f1(x) = f1."
//     In ra: "f2(x) = f2."
//   KẾT THÚC


// TEST CASE:
//   Input:  x = 1.2
//   Diễn giải:
//     f1: vì x=1.2 > 1  -> f1 = x^4 = 1.2^4 = 2.0736
//     f2: vì x=1.2 <= 2 -> f2 = x^2+4x+5 = 1.44+4.8+5 = 11.24
//   Output: f1(1.2) = 2.07.
//           f2(1.2) = 11.24.

//   Input:  x = 0.5
//   Diễn giải:
//     f1: vì 0 < 0.5 <= 1 -> f1 = x = 0.5
//     f2: vì 0.5 <= 2     -> f2 = 0.25+2+5 = 7.25
//   Output: f1(0.5) = 0.50.
//           f2(0.5) = 7.25.

//   Input:  x = -3
//   Diễn giải:
//     f1: vì x <= 0 -> f1 = 0
//     f2: vì x <= 2 -> f2 = 9-12+5 = 2
//   Output: f1(-3) = 0.00.
//           f2(-3) = 2.00.

//   Input:  x = 3
//   Diễn giải:
//     f1: vì x > 1 -> f1 = 3^4 = 81
//     f2: vì x > 2 -> f2 = 1/(9+12+5) = 1/26 = 0.0385
//   Output: f1(3) = 81.00.
//           f2(3) = 0.04.



using System;
 
namespace Buoi03
{
    class Baitap2
    {
        public static void Mainbt2()
        {
            // Bước 1: Đọc số thực x từ bàn phím
            Console.Write("Moi ban nhap so thuc x: ");
            double x = double.Parse(Console.ReadLine()!);
 
            // Bước 2: Tính f1(x) theo từng khoảng
            double f1;
            if (x <= 0)
                f1 = 0;
            else if (x <= 1)
                f1 = x;
            else
                f1 = Math.Pow(x, 4); // x^4
 
            // Bước 3: Tính f2(x) theo từng khoảng
            double f2;
            if (x <= 2)
                f2 = x * x + 4 * x + 5;
            else
                f2 = 1 / (x * x + 4 * x + 5);
 
            // Bước 4: In kết quả
            Console.WriteLine($"f1({x}) = {f1:0.00}.");
            Console.WriteLine($"f2({x}) = {f2:0.00}.");
        }
    }
}
