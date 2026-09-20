
//*Ý tưởng
//Nhập dãy số thực và nhập giá trị số thực k.
//Dùng 2 vòng lặp lồng nhau để xét mọi đoạn con [i, j].
//Tính tổng dồn các phần tử trong đoạn, nếu tổng bằng k và độ dài đoạn (j - i + 1) lớn hơn độ dài max hiện tại, tiến hành lưu lại vị trí i, j và cập nhật max.  
//In thông báo không tìm thấy, đoạn có 1 phần tử hoặc danh sách các phần tử thuộc đoạn dài nhất vừa tìm được.


//*Mã giả
// Procedure TimDoan(day)
//     Input k
//     max_len = 0, dau = -1, cuoi = -1

//     For i từ 0 đến day.Length - 1 Do
//         tong = 0
//         For j từ i đến day.Length - 1 Do
//             tong = tong + day[j]
//             If tong == k và (j - i + 1) > max_len Then
//                 max_len = j - i + 1
//                 dau = i
//                 cuoi = j
//             EndIf
//         EndFor
//     EndFor

//     If max_len == 0 Then
//         Output "Khong ton tai day co tong bang ", k
//     Else
//         Output "Doan [", dau, ",", cuoi, "] dai nhat co tong bang ", k, ": "
//         For idx từ dau đến cuoi Do
//             Output day[idx], " "
//         EndFor
//     EndIf
// EndProcedure

using System;

namespace Buoi10
{
    public class Baitap4
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

        public static void TimDoan(double[] day)
        {
            double k;
            Console.Write("Nhap so k: ");
            k=double.Parse(Console.ReadLine());
            double max=0;
            int dau=-1,cuoi=-1;
            for(int i=0; i <= day.Length-1; i++)
            {
                
                double tong=0;
                for(int j = i; j <= day.Length - 1; j++)
                {   
                    tong+=day[j];
                    if (tong == k && (j-i+1)>max)
                    {

                        max=j-i+1;
                        dau=i;
                        cuoi=j;
                    }
                }
            }

            if (max == 0)
            {
                Console.Write("Khong ton tai day co tong bang {0}.",k);
            }
            else if (max == 1)
            {
                Console.Write("Day chi co mot gia tri bang {0} la {1}",k,day[dau]);
            }
            else
            {
                Console.Write("Doan [{0},{1}] dai nhat co tong bang {2}: ",dau,cuoi,k);
                for(int i = dau; i <= cuoi; i++)
                {
                    Console.Write(day[i]+", ");
                }
            }
        }
        public static void Giaibai4(String[] args)
        {
            double[] a=null;
            Nhapdayso(ref a);
            TimDoan(a);
        }

    }
}


//Test cases
//1:
//   Nhập mảng: 1 -2 3 -4 5
//   Nhập k: 2
//   Output: Doan [1,4] dai nhat co tong bang 2: -2, 3, -4, 5,
//2:
//   Nhập mảng: 1 2 3 4 5
//   Nhập k: 20
//   Output: không tồn tại dãy con có tổng bằng 20
//3:
//   Nhập mảng: 1 2 3 4 5
//   Nhập k: 15
//   Output: Doan [0,4] dai nhat co tong bang 15: 1, 2, 3, 4, 5,
///4:
//   Nhập mảng: 1 2 3 4 5
//   Nhập k: 2
//   Output: Day chi co mot gia tri bang 2 la 2
