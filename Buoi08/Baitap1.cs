
//*Ý tưởng:
// - Xây dựng hàm phụ nhận vào một số nguyên x  sau đó chạy vòng lặp for từ 1 tới x để tính tích các số từ 1 đến x (x!).
// - Xây dựng hàm tính Ckn bằng cách sử dụng lại hàm tính giai thừa để áp dụng trực tiếp công thức toán học.
// - Luồng xử lý chính nhập hai số nguyên k và n từ bàn phím, gọi hàm tính Ckn , sau đó in kết quả ra màn hình.

//*Mã giả:
// Hàm tính giai thừa của x
// Function GiaiThua(x)
//     Tich = 1
//     For i từ 1 đến x Do
//         Tich = Tich * i
//     EndFor
//     Return Tich
// EndFunction

// // Hàm tính tổ hợp C(n, k)
// Function TinhCkn(n, k)
//     Return GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k))
// EndFunction

// Chương trình chính
// Procedure Main
//     Output "Moi ban nhap k: "
//     Input k
//     Output "Moi ban nhap n: "
//     Input n

//     kq = TinhCkn(n, k)

//     Output "C(", k, ", ", n, ") = ", kq
// EndProcedure

using System;

namespace Buoi08
{
    public class Baitap1
    {
        public static double giaithua(int n)
        {
            double m;
            int i;
            m=1;
            for(i=1; i<=n; i++)
            {
                m = m*i;
            }
            return m;
        }

        public static double TinhCkn(int n, int k)
        {
            return (giaithua(n)/(giaithua(k)*giaithua(n-k)));
        }


        public static void Giaibai1(String[] args)
        {
            int n, k;
            double kq;
            Console.Write("Moi ban nhap so nguyen n: ");
            n= int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap so nguyen k: ");
            k= int.Parse(Console.ReadLine());

            kq= TinhCkn(n,k);
            Console.Write(" Gia tri cua Ckn la:{0} ", kq);
        }
    }
}