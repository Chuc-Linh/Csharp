
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
            Console.Write("Moi ban nhap so luong phan tu: ");
            n=int.Parse(Console.ReadLine());
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