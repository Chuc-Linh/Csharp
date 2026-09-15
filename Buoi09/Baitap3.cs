
//*Ý tưởng
// Nhập dãy số nguyên
// Dùng 3 biến đếm am, duong, khong. Duyệt từ đầu đến cuối mảng, so sánh từng phần tử với số 0 để tăng biến đếm tương ứng.
// In số lượng của từng loại ra màn hình

//*Mã giả
//Procedure Dem(day)
//     am = 0, duong = 0, khong = 0
//     For i từ 0 đến day.Length - 1 Do
//         If day[i] < 0 Then
//             am = am + 1
//         ElseIf day[i] > 0 Then
//             duong = duong + 1
//         Else
//             khong = khong + 1
//         EndIf
//     EndFor
//     Output "Co ", am, " so am, ", khong, " so 0, ", duong, " so duong."
// EndProcedure


using System;

namespace Buoi09
{
    public class Baitap3
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

        public static void Dem(int[] day)
        {
            int am=0,duong=0, khong=0;

            for(int i=0; i < day.Length; i++)
            {
                if (day[i] < 0)
                {
                    am++;
                }
                else if (day[i] > 0)
                {
                    duong++;
                }
                else
                {
                    khong++;
                }
            }

            Console.Write("Day so co {0} so am, {1} so khong va {2} so duong.", am, khong, duong);
        }

        public static void Giaibai3(String[] args)
        {
            int[] a=null;
            Nhapdayso(ref a);
            Dem(a);
        }
    }
}