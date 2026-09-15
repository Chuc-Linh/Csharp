
//*Ý tưởng
// Nhập mảng một chiều
// Duyệt qua tlaanf lượt các phần tử trong mảng.
//  Các phần tử chãn đầu tiên và cuối cùng được lưu vị trí bằng biến "dau" và "cuoi".
//  Biến dau được khởi tạo giá trị -1 như một cờ, khi ghi nhận giá trị chẵn đầu tiên biến dau sẽ lưu lại vị trí của nó(khác -1) và kooong lưu vị trí các số chẵn sau
//  Xét các trường hợp mảng không có số chẵn dương nào, có duy nhất 1 số, hoặc có từ 2 số trở lên để in vị trí và giá trị tương ứng.

//*Mã giả
// Procedure ChanDauCuoi(day)
//     dau = -1, cuoi = -1
//     For i từ 0 đến day.Length - 1 Do
//         If day[i] Mod 2 == 0 và day[i] > 0 Then
//             If dau == -1 Then dau = i EndIf
//             cuoi = i
//         EndIf
//     EndFor

//     If dau == -1 Then
//         Output "Khong co gia tri chan duong"
//     ElseIf dau == cuoi Then
//         Output "Co 1 gia tri duy nhat tai vi tri: ", dau
//     Else
//         Output "Dau tien tai: ", dau, ", Cuoi cung tai: ", cuoi
//     EndIf
// EndProcedure
using System;

namespace Buoi09
{
    public class Baitap2
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

        public static void Chandaucuoi(int[] day)
        {
            int dau=-1,cuoi=-1;
            for(int i = 0; i <= day.Length-1; i++)
            {
                if (day[i] % 2 == 0 && day[i]>0 && dau ==-1 )
                {
                    dau=i;
                }
                if (day[i] % 2 == 0 && day[i]>0)
                {
                    cuoi=i;
                }

            }

            if (dau == cuoi && dau!=-1)
            {
                Console.Write("Day so co mot gia tri chan duy nhat o vi tri {0} co gia tri {1}",dau,day[dau]);
            }

            else if (dau == -1)
            {
                Console.Write("Day so khong có gia tri chan nao.");
            }

            else{
                Console.WriteLine("Gia tri chan dau tien o vi tri {0} co gia tri {1}.", dau, day[dau]);
                Console.WriteLine("Gia tri chan cuoi cung o vi tri {0} co gia tri {1}.", cuoi, day[cuoi]);
            }
        }

        public static void Giaibai2(String[] args)
        {
            int[] a=null;
            Nhapdayso(ref a);
            Chandaucuoi(a);
        }
    }
}