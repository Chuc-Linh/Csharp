
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
            Timdaucuoi(a);
        }
    }
}