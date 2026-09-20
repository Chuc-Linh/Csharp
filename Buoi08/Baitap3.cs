
//Ý tưởng:
// - Hàm tìm UCLN: Tìm ước số chung lớn nhất của từ số n và mẫu số m bằng giải thuật Euclid.
// - Giải thuật Euclid: Muốn tìm UCLN của hai số, ta lấy số lớn chia cho số nhỏ, lấy phần dư.
//     Sau đó lấy số nhỏ chia cho phần dư. Cứ tiếp tục như vậy cho đến khi phép chia hết, tức là phần dư bằng 0. Khi đó, số chia cuối cùng chính là UCLN
// - Hàm rút gọn phân số: Kiểm tra mẫu số m, nếu m = 0 thì thông báo không hợp lệ. Ngược lại, chia cả tử số $n$ và mẫu số m cho UCLN vừa tìm được để ra phân số tối giản và in kết quả. 

//*Mã giả:
// Hàm tìm ước số chung lớn nhất bằng thuật toán Euclid
// Function UCLN(n, m)
//     x = n
//     y = m
//     While y != 0 Do
//         z = y
//         y = x Mod y
//         x = z
//     EndWhile
//     Return x
// EndFunction

// Hàm rút gọn và in phân số
// Procedure RutGonPhanSo(n, m)
//     If m == 0 Then
//         Output "Phan so khong hop le!"
//     Else
//         uc = UCLN(n, m)
//         h = n / uc  // Tử số tối giản
//         k = m / uc  // Mẫu số tối giản
//         Output "Gia tri của phan so ", n, "/", m, " la: ", h, "/", k
//     EndIf
// EndProcedure

// Chương trình chính
// Procedure Main
//     Output "Nhap tu so n: "
//     Input n
//     Output "Nhap mau so m: "
//     Input m

//     RutGonPhanSo(n, m)
// EndProcedure


using System;

namespace Buoi08
{
    public class Baitap3
    {
        public static int UCLN(int n, int m)
        {
            int x=n;
            int y=m;
            int z=0;
            while (y != 0)
            {
                z=y;
                y= x%y;
                x=z;
            }
            return z;
        }
        
        public static void Rutgonps(int n, int m)
        {
             if (m == 0)
            {
                Console.Write("Phan so khong hop le!");
            }
            else
            {
            int h=n/UCLN(n,m);
            int k=m/UCLN(n,m);
            
            Console.Write("Gia tri cua phan so {0}/{1} la: {2}/{3}", n,m,h,k);
            }
        }
        public static void Giaibai3(String[] args)
        {
            int n,m;
            Console.Write("Nhap tu so n: ");
            n= int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so m: ");
            m= int.Parse(Console.ReadLine());
            Rutgonps(n,m);
        }
    } 
}

//Test cases
//1:
// Moi nhap tu so n: 4
// Moi nhap mau so m: 8
// Gia tri cua phan so 4/8 la: 1/2
//2:
// Moi nhap tu so n: 5
// Moi nhap mau so m: 0
// Phan so khong hop le!
//3:
// Moi nhap tu so n: 12
// Moi nhap mau so m: 16
// Gia tri cua phan so 12/16 la: 3/4
//4:
// Moi nhap tu so n: 15
// Moi nhap mau so m: 25
// Gia tri cua phan so 15/25 la: 3/5
