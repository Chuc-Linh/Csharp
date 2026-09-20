
//* Ý tưởng:
//Hàm đếm số lần xuất hiện của một chữ số: Tách từng chữ số hàng đơn vị của $n$ bằng phép chia lấy dư n % 10, nếu bằng chữ số cần đếm thì tăng biến đếm.
//  Sau đó bỏ chữ số vừa xét bằng phép chia lấy nguyên n = n / 10 cho đến khi n = 0. Biến đếm cuối cùng sẽ đém đc số lần xuất hiện của chữ số cần đếm trong n.
//Hàm thống kê chữ số: Duyệt các chữ số i từ 0 đến 9. Gọi hàm đếm số lần xuất hiện của i trong n, nếu số lần xuất hiện lớn hơn 0 thì in kết quả ra màn hình.

//* Mã giả:
// Hàm đếm số lần xuất hiện của chữ số cs trong số n
// Function DemChuSo(n, cs)
//     dem = 0
//     While n != 0 Do
//         If (n Mod 10) == cs Then
//             dem = dem + 1
//         EndIf
//         n = n / 10
//     EndWhile
//     Return dem
// EndFunction

// Hàm thống kê các chữ số xuất hiện trong n
// Procedure ThongKeChuSo(n)
//     For i từ 0 đến 9 Do
//         so_lan = DemChuSo(n, i)
//         If so_lan != 0 Then
//             Output "Chu so ", i, " xuat hien ", so_lan, " lan."
//         EndIf
//     EndFor
// EndProcedure

// Chương trình chính
// Procedure Main
//     Output "Nhap so nguyen duong n: "
//     Input n

//     ThongKeChuSo(n)
// EndProcedure

using System;

namespace Buoi08
{
    public class Baitap4
    {
        public static int Demchuso(int n, int cs)
        {
            int dem=0;
            while (n != 0)
            {
                if ((n % 10) == cs)
                {
                    dem=dem+1;
                }
                n=n/10;
            }
            return dem;
        }

        public static void Demchuso(int n)
        {
            for(int i=0; i <= 9; i++)
            {
                if (Demchuso(n, i) != 0)
                {
                    Console.WriteLine("Chu so {0} xuat hien {1} lan.",i , Demchuso(n,i));
                }
            }
        }

        public static void Giaibai4(String[] args)
        {
            int n;
            Console.Write("Nhap so nguyen duong n: ");
            n= int.Parse(Console.ReadLine());
            Demchuso(n);
        }
    }
}

//Test cases
//1:
// Moi nhap so nguyen duong n: 123321
// Chu so 1 xuat hien 2 lan.
// Chu so 2 xuat hien 2 lan.
// Chu so 3 xuat hien 2 lan.
//2:
// Moi nhap so nguyen duong n: 100200300
// Chu so 0 xuat hien 6 lan.
// Chu so 1 xuat hien 1 lan.
// Chu so 2 xuat hien 1 lan.
// Chu so 3 xuat hien 1 lan.
//3:
// Moi nhap so nguyen duong n: 112233
// Chu so 1 xuat hien 2 lan.
// Chu so 2 xuat hien 2 lan.
// Chu so 3 xuat hien 2 lan.
//4:
// Moi nhap so nguyen duong n: 9876543210
// Chu so 0 xuat hien 1 lan.
// Chu so 1 xuat hien 1 lan.
// Chu so 2 xuat hien 1 lan.
// Chu so 3 xuat hien 1 lan.
// Chu so 4 xuat hien 1 lan.
// Chu so 5 xuat hien 1 lan.
// Chu so 6 xuat hien 1 lan.
// Chu so 7 xuat hien 1 lan.
// Chu so 8 xuat hien 1 lan.
// Chu so 9 xuat hien 1 lan.
