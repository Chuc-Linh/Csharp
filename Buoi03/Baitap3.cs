// Ý TƯỞNG:
//   - Công thức nghiệm phương trình bậc 2 dựa vào "biệt thức" delta:
//         delta = b^2 - 4*a*c
//   - Dựa vào dấu của delta mà số nghiệm khác nhau:
//       + delta > 0  -> phương trình có 2 nghiệm phân biệt:
//            x1 = (-b + sqrt(delta)) / (2a)
//            x2 = (-b - sqrt(delta)) / (2a)
//       + delta = 0  -> phương trình có nghiệm kép (1 nghiệm):
//            x = -b / (2a)
//       + delta < 0  -> phương trình vô nghiệm (trong tập số thực),
//            vì không lấy căn bậc 2 của số âm được.
//   - Trường hợp đặc biệt: nếu a = 0 thì đây không còn là phương trình bậc 2 nữa (mất số hạng x^2), nên cần xét riêng để tránh chia cho 0 khi tính (2a) ở mẫu số.

// MÃ GIẢ:
//   BẮT ĐẦU
//     In ra: "Moi ban nhap he so a, b, c: "
//     Đọc 3 số thực a, b, c

//     NẾU a == 0 THÌ
//     In ra thông báo "khong phai phuong trinh bac 2"
//     NGƯỢC LẠI
//         delta <- b*b - 4*a*c
//         NẾU delta > 0 THÌ
//             x1 <- (-b + sqrt(delta)) / (2*a)
//             x2 <- (-b - sqrt(delta)) / (2*a)
//             In ra: "...co: 2 nghiem, x1 = .., x2 = .."
//         NGƯỢC LẠI NẾU delta == 0 THÌ
//             x <- -b / (2*a)
//             In ra: "...co: 1 nghiem, x = .."
//         NGƯỢC LẠI
//             In ra: "...vo nghiem"
//   KẾT THÚC

// TEST CASE:
//   Input:  a=1, b=5, c=6
//   Diễn giải: delta = 25 - 24 = 1 > 0
//              x1 = (-5+1)/2 = -2, x2 = (-5-1)/2 = -3
//   Output: Phuong trinh bac 2 1x^2 + 5x + 6 = 0 co: 2 nghiem,
//           x1 = -2.00, x2 = -3.00.

//   Input:  a=1, b=2, c=1
//   Diễn giải: delta = 4 - 4 = 0
//              x = -2/2 = -1
//   Output: Phuong trinh bac 2 1x^2 + 2x + 1 = 0 co: 1 nghiem,
//           x = -1.00.

//   Input:  a=1, b=1, c=1
//   Diễn giải: delta = 1 - 4 = -3 < 0
//   Output: Phuong trinh bac 2 1x^2 + 1x + 1 = 0 vo nghiem.


using System;
 
namespace Buoi03
{
    class Baitap3
    {
        public static void Mainbt3()
        {
            // Bước 1: Đọc 3 hệ số a, b, c trên cùng 1 dòng
            Console.Write("Moi ban nhap he so a, b, c: ");
            string input = Console.ReadLine()!;
            string[] parts = input.Split(' ');
 
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);
            double c = double.Parse(parts[2]);
 
            string tieuDe = $"Phuong trinh bac 2 {a}x^2 + {b}x + {c} = 0";
 
            // Bước 2: Xét trường hợp a = 0 (không còn là bậc 2)
            if (a == 0)
            {
                Console.WriteLine($"{tieuDe} khong phai la phuong trinh bac 2.");
                return;
            }
 
            // Bước 3: Tính delta để xét số nghiệm
            double delta = b * b - 4 * a * c;
 
            if (delta > 0)
            {
                // 2 nghiệm phân biệt
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"{tieuDe} co: 2 nghiem, x1 = {x1:0.00}, x2 = {x2:0.00}.");
            }
            else if (delta == 0)
            {
                // Nghiệm kép
                double x = -b / (2 * a);
                Console.WriteLine($"{tieuDe} co: 1 nghiem, x = {x:0.00}.");
            }
            else
            {
                // delta < 0 -> vô nghiệm thực
                Console.WriteLine($"{tieuDe} vo nghiem.");
            }
        }
    }
}
 