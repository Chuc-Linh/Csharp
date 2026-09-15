//*Ý tưởng
//Khởi tạo và nhập dãy số nguyên n phần tử.
//Duyệt từ phần tử thứ 2 (i = 1) đến phần tử kế cuối (Length - 2).
//Nếu phần tử hiện tại bé hơn cả 2 phần tử lân cận (cực tiểu) hoặc lớn hơn cả 2 phần tử lân cận (cực đại) thì cộng dồn giá trị vào biến tổng.

//*Mã giả
// Procedure TongCucTri(day)
//     tong = 0
//     For i từ 1 đến day.Length - 2 Do
//         // Kiểm tra cực tiểu hoặc cực đại
//         If (day[i-1] > day[i] và day[i+1] > day[i]) hoặc 
//            (day[i-1] < day[i] và day[i+1] < day[i]) Then
//             tong = tong + day[i]
//         EndIf
//     EndFor
//     Output "Tong cac phan tu cuc tri: ", tong
// EndProcedure


using System;

namespace Buoi10
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

        public static void Tongcuctri( int[] day)
        {
            int tong=0;
            for(int i=1; i <= day.Length - 2; i++)
            {
                if((day[i-1]>day[i]&& day[i + 1] > day[i]) || (day[i - 1] < day[i] && day[i + 1] < day[i]))
                {
                    tong+=day[i];
                }
            }

            Console.Write("Tong cac phan tu trong day so: {0}", tong);
        }
        public static void Giaibai1(String[] args)
        {
            int[] a=null;
            Nhapdayso(ref a);
            Tongcuctri(a);
        }
    }
}