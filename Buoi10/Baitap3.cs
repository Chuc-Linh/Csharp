//*Ý tưởng
//Khởi tạo và nhập dãy số thực n phần tử.
//Giả sử dãy ban đầu là đan dấu (co = 1).
//Duyệt các cặp liên tiếp, nếu tồn tại bất kỳ cặp kề nhau nào có tích không âm (day[i] * day[i+1] >= 0), đánh dấu co = 0 (không phải đan dấu).
//Kiểm tra biến co để thông báo kết quả.


//*Mã giả
// Procedure DayDanDau(day)
//     co = 1
//     For i từ 0 đến day.Length - 2 Do
//         If day[i] * day[i+1] >= 0 Then
//             co = 0
//         EndIf
//     EndFor

//     If co == 1 Then
//         Output "Day so tren la day dan dau."
//     Else
//         Output "Day so tren khong phai la day dan dau."
//     EndIf
// EndProcedure


using System;

namespace Buoi10
{
    public class Baitap3
    {
        public static void Nhapdayso(ref double[] day)
        {
            int i,n;
            Console.Write("Moi ban nhap so luong phan tu: ");
            n=int.Parse(Console.ReadLine());
            day=new double[n];
            for(i=0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i);
                day[i]= double.Parse(Console.ReadLine());

            }
        }

        public static void Daydandau(double[] day)
        {
            int co=1;
            for(int i = 0; i <= day.Length - 2; i++)
            {
                if (day[i] * day[i + 1] >= 0)
                {
                    co=0;
                }
            }
            if (co == 0)
            {
                Console.Write("Day so tren khong phai la day dan dau.");
            }
            else
            {
                Console.Write("Day so tren là day dan dau.");
            }
        }

        public static void Giaibai3(String[] args)
        {
            double[] a=null;
            Nhapdayso(ref a);
            Daydandau(a);
        }
    }
}