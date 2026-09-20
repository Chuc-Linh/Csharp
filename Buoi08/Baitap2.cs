
//Ý tưởng:
//  Số hoàn hảo là số có tổng các ước số thực sự (các ước nhỏ hơn nó) bằng chính nó.
// Xây dựng hàm tìm số hoàn hảo bằng cách duyệt từ 1 đến x-1, nếu i là ước của x thì cộng dồn vào tổng; cuối cùng so sánh tổng đó với x.
// Xây dựng hàm liệt kê các số hoàn hảo bằng cách duyệt các số nguyên i trong đoạn [1,n], số nào là số hoàn hảo thì in ra màn hình.

//Mã giả:
// Hàm kiểm tra số hoàn hảo (trả về True/False)
// Function KiemTraSoHoanHao(x)
//     TongUoc = 0
//     For i từ 1 đến x - 1 Do
//         If x chia hết cho i Then
//             TongUoc = TongUoc + i
//         EndIf
//     EndFor

//     If TongUoc == x Then
//         Return True
//     Else
//         Return False
//     EndIf
// EndFunction

// Hàm liệt kê các số hoàn hảo từ 1 đến n
// Procedure LietKeSoHoanHao(n)
//     Output "Cac so hoan hao trong doan [1, ", n, "] la: "
//     For i từ n giảm về 1 Do
//         If KiemTraSoHoanHao(i) == True Then
//             Output i, " "
//         EndIf
//     EndFor
// EndProcedure

// // Chương trình chính
// Procedure Main
//     Output "Moi nhap so nguyen n: "
//     Input n

//     LietKeSoHoanHao(n)
// EndProcedure
using System;

namespace Buoi08
{
    public class Baitap2
    {
        public static int sohoanhao(int x)
        {
            int i;
            int kt=0;
            for (i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    kt+=i;
                }
            }
            if (kt == x)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static void Lietkesohh(int n)
        {
            Console.Write("Cac so hoan hao trong doan [1,{0}] la: ", n);

            for(int i = n; i >= 1; i--)
            {
                if (sohoanhao(i) == 1)
                {
                    Console.Write(i+" ");
                }
            }
        }

        public static void Giaibai2(String[] args)
        {
            int n;
            Console.Write("Moi nhap so nguyen n: ");
            n=int.Parse(Console.ReadLine());
            Lietkesohh(n);
        }
    }
}

//Test cases
//1:
// Moi nhap so nguyen n: 6
// Cac so hoan hao trong doan [1,6] la: 6
//2:
// Moi nhap so nguyen n: 30
// Cac so hoan hao trong doan [1,30] la: 28 6
//3:
// Moi nhap so nguyen n: 100
// Cac so hoan hao trong doan [1,100] la: 28 6
//4:
// Moi nhap so nguyen n: 500
// Cac so hoan hao trong doan [1,500] la: 496 28 6
