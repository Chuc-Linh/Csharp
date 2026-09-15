using System;
/*
Chương trình: BÀI TẬP BUỔI 4
Nội dung: 5 bài tập mẫu + 5 bài tập cơ bản + 5 bài tập nâng cao
Tác giả: Bùi Phúc Hưng
Ngày viết: 10/09/2026
*/

/*
Phát biểu đề bài: PhanLoaiTamGiac.*

Nhập vào ba số thực a, b, c. Hỏi ba số đó có tạo thành một tam giác không? 
Nếu có, nó tạo thành tam giác gì? (thường, cân, vuông, vuông cân, đều).

Ý tưởng:
Nhập 3 số thực a, b, c
Điều kiện tạo thành tam giác: a > 0, b > 0, c > 0 và tổng 2 cạnh bất kỳ lớn hơn cạnh còn lại

Phân loại tam giác:
Đều: a == b và b == c
Vuông cân: vừa vuông vừa cân
Vuông: a*a + b*b == c*c
Cân: a == b hoặc a == c hoặc b == c
Còn lại là tam giác thường.

Mã giả:
Nhập a, b, c

Nếu (a > 0 và b > 0 và c > 0 và a + b > c và a + c > b và b + c > a)
    Nếu (a == b và b == c)
        loại = đều
    Ngược lại nếu (vuông và cân)
        loại = vuông cân
    Ngược lại nếu (a*a + b*b == c*c hoặc a*a + c*c == b*b hoặc b*b + c*c == a*a)
        loại = vuông
    Ngược lại nếu (a == b hoặc a == c hoặc b == c)
        loại = cân
    Ngược lại
        loại = thường

    In ra tam giác và loại tam giác
Ngược lại
    In ra ko phải là tam giác
*/

// BÀI TẬP CƠ BẢN CÂU 4
namespace NMLT.Buoi04
{
    public class PhanLoaiTamGiac
    {
        public static void Main(string[] args)
        {
            // khai báo biến
            double a, b, c;

            // nhập dữ liệu
            Console.WriteLine("Moi ban nhap ba so thuc a, b, c: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            // ktra điều kiện
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ba so ({0}, {1}, {2}) tao thanh duoc tam giac.", a, b, c);

                // TG vuông
                bool laVuong = (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);

                // TG cân
                bool laCan = (a == b) || (a == c) || (b == c);

                // Xét loại
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac tao thanh la tam giac deu.");
                }
                else if (laVuong && laCan)
                {
                    Console.WriteLine("Tam giac tao thanh la tam giac vuong can.");
                }
                else if (laVuong)
                {
                    Console.WriteLine("Tam giac tao thanh la tam giac vuong.");
                }
                else if (laCan)
                {
                    Console.WriteLine("Tam giac tao thanh la tam giac can.");
                }
                else
                {
                    Console.WriteLine("Tam giac tao thanh la tam giac thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ba so ({0}, {1}, {2}) khong tao thanh duoc tam giac.", a, b, c);
            }
        }
    }
}