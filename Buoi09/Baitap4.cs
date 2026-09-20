
//Ý tưởng
//Nhập dãy số thực và nhập số thực x cần tìm
//Duyệt qua mảng, nếu phần tử bằng x thì ghi nhận chỉ số đầu tiên (dau) và cập nhật chỉ số cuối cùng (cuoi).
//Thông báo không tìm thấy, tìm thấy 1 vị trí hoặc các vị trí xuất hiện đầu/cuối của x.

//Mã giả

// Procedure TimDauCuoi(day)
//     Input x
//     dau = -1, cuoi = -1
//     For i từ 0 đến day.Length - 1 Do
//         If day[i] == x Then
//             If dau == -1 Then dau = i EndIf
//             cuoi = i
//         EndIf
//     EndFor

//     If dau == -1 Then
//         Output "Khong tim thay x"
//     ElseIf dau == cuoi Then
//         Output "x xuat hien duy nhat tai vi tri: ", dau
//     Else
//         Output "x dau tien tai: ", dau, ", x cuoi cung tai: ", cuoi
//     EndIf
// EndProcedure



using System;

namespace Buoi09
{
    public class Baitap4
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

        public static void Xuatdayso(int[] day)
    {
        Console.WriteLine("Day so co {0} phan tu:", day.Length);

        for (int i = 0; i < day.Length; i++)
        {
            Console.Write(day[i] + " ");
        }

        Console.WriteLine();
    }

        public static void Timdaucuoi(double[] day)
        {
            Console.WriteLine("* Tim kiem");
            Console.Write("Nhap so can tim: ");
            double x=double.Parse(Console.ReadLine());

            int dau=-1,cuoi=-1;
            for(int i = 0; i <= day.Length-1; i++)
            {
                if (day[i] == x && dau == -1 )
                {
                    dau=i;
                }
                if (day[i] == x )
                {
                    cuoi=i;
                }

            }

            if (dau == cuoi && dau!=-1)
            {
                Console.Write("Day so co mot gia tri x duy nhat o vi tri {0} co gia tri {1}",dau,day[dau]);
            }
            else if (dau == -1)
            {
                Console.Write("Day so khong có gia tri x can tim.");
            }
            else{
                Console.WriteLine("Gia tri x dau tien o vi tri {0} co gia tri {1}.", dau, day[dau]);
                Console.WriteLine("Gia tri x cuoi cung o vi tri {0} co gia tri {1}.", cuoi, day[cuoi]);
            }
        }

        public static void Giaibai4(String[] args)
        {
            double[] a=null;
            Nhapdayso(ref a);
            Xuatdayso(a);
            Timdaucuoi(a);
        }
    }
}


//Test cases
//1:
//   Nhập mảng: 1 2 3 4 5 6
//   Nhập số cần tìm: 4
//   Output: Giá trị x đầu tiên ở vị trí 3 có giá trị 4.
//           Giá trị x cuối cùng ở vị trí 3 có giá trị 4.
//2:
//   Nhập mảng: 7 8 9 10
//   Nhập số cần tìm: 5
//   Output: Dãy số không có giá trị x cần tìm.
//3:
//   Nhập mảng: 1 3 5 3 7
//   Nhập số cần tìm: 3
//   Output: Giá trị x đầu tiên ở vị trí 1 có giá trị 3.
//           Giá trị x cuối cùng ở vị trí 3 có giá trị 3.
//4:
//   Nhập mảng: 2 4 6 8
//   Nhập số cần tìm: 6
//   Output: Day số có một giá trị x duy nhất ở vị trí 2 có giá trị 6.
