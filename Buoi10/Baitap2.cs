//*Ý tưởng
//Khởi tạo và nhập dãy số thực n phần tử.
//Duyệt các cặp phần tử liên tiếp từ i = 0 đến Length - 2.
//Hai số kề nhau trái dấu khi tích của chúng nhỏ hơn 0 (day[i] * day[i+1] < 0).
//Tăng biến đếm mỗi khi điều kiện thỏa mãn

//*Mã giả
// Procedure KeNhauTraiDau(day)
//     dem = 0
//     For i từ 0 đến day.Length - 2 Do
//         If day[i] * day[i+1] < 0 Then
//             dem = dem + 1
//         EndIf
//     EndFor
//     Output "So luong cac phan tu ke nhau trai dau: ", dem
// EndProcedure



using System;

namespace Buoi10
{
    public class Baitap2
    {
        public static void Nhapdayso(ref double[] day)
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
            day=new double[n];
            for(i=0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i);
                day[i]= double.Parse(Console.ReadLine());

            }
        }

        public static void Kenhautraidau(double[] day)
        {
            int dem=0;
            for(int i = 0; i <= day.Length - 2; i++)
            {
                if (day[i] * day[i + 1] < 0)
                {
                    dem++;
                }
            }
            Console.Write("So luong cac phan tu ke nhau trai dau: {0}", dem);
        }

        public static void Giaibai2(String[] args)
        {
            double[] a=null;
            Nhapdayso(ref a);
            Kenhautraidau(a);
        }
    }
}

//Test cases
//1:
//   Nhập mảng: 1 -2 3 -4 5
//   Output: So luong cac phan tu ke nhau trai dau: 4
//2:
//   Nhập mảng: 1 2 3 4 5
//   Output: So luong cac phan tu ke nhau trai dau: 0
//3:
//   Nhập mảng: -1 -2 -3 -4
//   Output: So luong cac phan tu ke nhau trai dau: 0
//4:
//   Nhập mảng: 1 -2 -3 4 -5
//   Output: So luong cac phan tu ke nhau trai dau: 3
