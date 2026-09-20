
//*Ý tưởng
// Nhập mảng một chiều
// Chạy vòng lặp for để duyệt qua lần lượt các phần tử trong mảng nếu phần tử là số chẵn thì in ra

//*Mã giả
// Function NhapDaySo(Ref day)
//     Input n
//     KhoiTao day gom n phan tu
//     For i từ 0 đến n - 1 Do
//         Input day[i]
//     EndFor
// EndFunction

// Procedure LietKeChan(day)
//     For i từ day.Length - 1 giảm về 0 Do
//         If day[i] Mod 2 == 0 Then
//             Output day[i]
//         EndIf
//     EndFor
// EndProcedure

using System;

namespace Buoi09
{
    public class Baitap1
    {
        public static void Nhapdayso(ref int[] day)
        {
            int i,n;
            do
        {
            Console.Write("Moi ban nhap so luong phan tu (1 - 500): ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 500)
            {
                Console.WriteLine("So luong phan tu phai tu 1 den 500!");
            }

            } while (n < 1 || n > 500);
            day=new int[n];
            for(i=0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i);
                day[i]= int.Parse(Console.ReadLine());

            }
        }
        public static void Lietkechan(int[] day)
        {
            Console.Write("Cac phan tu chan trong mang: ");
            for(int i=day.Length-1; i >= 0; i--)
            {
                if (day[i] % 2 == 0)
                {
                    Console.Write(day[i]+" ");
                }
            }
        }
        public static void Giaibai1(String[] args)
        {
            int[] a=null;
            Nhapdayso(ref a);
            Lietkechan(a);
        }
    }
}

//Test cases
//1:
//   Nhập mảng: 1 2 3 4 5 6
//   Output: 6 4 2
//2:
//   Nhập mảng: 7 8 9 10
//   Output: 10 8
//3:
//   Nhập mảng: 1 3 5
//   Output: (không có số chẵn nào)
//4:
//   Nhập mảng: 2 4 6 8
//   Output: 8 6 4 2
