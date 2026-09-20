
/*
* CHƯƠNG TRÌNH XỬ LÝ CHỮ SỐ
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 13/9/2026
*
* Phát biểu đề bài: Đề bài yêu cầu nhập số nguyên n và hãy:
(a) Cho biết chữ số thứ k (tính từ trái sang)
(b) Tính tổng các chữ số lẻ
(c) Tìm chữ số lẻ nhỏ nhất và lớn nhất 
Ví dụ:Moi ban nhap so nguyen n: 182345
Moi ban nhap vi tri k: 2
Chu so o vi tri 2 (tinh tu trai) cua 182345 la 8.
Tong cac chu so le cua 182345 la 9.
182345 co chu so le nho nhat la 1 va lon nhat la 5.
* Ý tưởng: Lấy n và k được nhập từ bàn phím. Sau đó phân tích n để lấy các chữ số. 
Phân tích n bằng cách chuyển n thành chuỗi string rồi duyệt từng ký tự. 
a) Chữ số k: 
CHuyển n thành chuỗi -> Chữ số thứ k(tính từ trái)= ký tự ở vị trí k-1)(vì mảng bắt đầu từ 0)
b) Tổng chữ số lẻ: 
Duyệt từng ký tự trong chuỗi -> chuyển ký tự thành số -> nếu số đó lẻ (% 2 != 0) → cộng vào tổng
c) Chữ số lẻ nhỏ nhất và lớn nhất 
Khởi tạo minLe = 10, maxLe = -1 (giá trị đặc biệt)
Duyệt từng chữ số lẻ:
Nếu nhỏ hơn minLe → cập nhật minLe
Nếu lớn hơn maxLe → cập nhật maxLe
* Mã giả: CHƯƠNG TRÌNH Xử lý chữ số
BẮT ĐẦU
    // Bước 1: Nhập n
    LẶP:
        In "Moi ban nhap so nguyen n: "
        Đọc n từ bàn phím
        NẾU n không phải số nguyên dương:
        In "Nhap sai! Vui long nhap lai"
        LẶP LẠI
    
    // Bước 2: Nhập k
    LẶP:
        In "Moi ban nhap vi tri k: "
        Đọc k từ bàn phím
        NẾU k không phải số nguyên HOẶC k < 1 HOẶC k > số chữ số của n:
        In "Nhap sai! Vui long nhap lai"
        LẶP LẠI
    
    // Bước 3: Chuyển n thành chuỗi
    chuoiN = chuyển n thành string
    
    // Bước 4: (a) Tìm chữ số thứ k
    chuSoThuK = chuoiN[k - 1]     // Mảng bắt đầu từ 0
    In "Chu so o vi tri k (tinh tu trai) cua n la chuSoThuK"
    
    // Bước 5: (b) Tính tổng chữ số lẻ
    tongLe = 0
    VỚI MỖI ký tự c TRONG chuoiN:
        so = chuyển c thành số nguyên
        NẾU so % 2 != 0:    // số lẻ
            tongLe = tongLe + so
    In "Tong cac chu so le cua n la tongLe"
    
    // Bước 6: (c) Tìm chữ số lẻ nhỏ nhất và lớn nhất
    minLe = 10      // Ban đầu đặt lớn hơn mọi chữ số
    maxLe = -1      // Ban đầu đặt nhỏ hơn mọi chữ số
    VỚI MỖI ký tự c TRONG chuoiN:
        so = chuyển c thành số nguyên
        NẾU so % 2 != 0:
            NẾU so < minLe: minLe = so
            NẾU so > maxLe: maxLe = so
    
    NẾU minLe == 10:    // Không có chữ số lẻ nào
        In "n khong co chu so le"
    NGƯỢC LẠI:
        In "n co chu so le nho nhat la minLe va lon nhat la maxLe"
KẾT THÚC
*/
using System;
namespace BUOI7 
{ class Xulichuso
    { public static void Main(string[] args)
    {
    //BƯỚC 1: NHẬP n
    long n;
    Console.Write("Nhap so nguyen n(n>0): ");
    while (!long.TryParse(Console.ReadLine(), out n) || n <= 0){
    Console.Write("Nhap sai! Nhap so nguyen duong: "); }
        //Chuyển n thành chuỗi để dễ xử lý từng chữ số
            string chuoiN = n.ToString();
            int soChuSo = chuoiN.Length;
    //BƯỚC 2: NHẬP k
    int k;
    Console.Write("Nhap vi tri k: ");
    while (!int.TryParse(Console.ReadLine(), out k) || k < 1 || k > soChuSo){
    Console.Write($"Nhap sai! Nhap k tu 1 den {soChuSo}: "); }
    //BƯỚC 3: a tìm chữ số k
        // Mảng/chuỗi bắt đầu từ vị trí 0, nên chữ số thứ k ở vị trí k-1
            char chuSoThuK = chuoiN[k - 1];
            Console.WriteLine($"Chu so o vi tri {k} (tinh tu trai) cua {n} la {chuSoThuK}.");
    //BƯỚC 4:b TÍNH TỔNG CHỮ SỐ LẺ 
    int tongLe = 0;
    for (int i = 0; i < soChuSo; i++)
    { //Chuyển ký tự thành số: '5' - '0' = 5
        int chuSo = chuoiN[i] - '0';
    // Kiểm tra số lẻ
        if (chuSo % 2 != 0)       
        { tongLe = tongLe + chuSo;} }
        Console.WriteLine($"Tong cac chu so le cua {n} la {tongLe}.");
    //BƯỚC 5:c TÌM CHỮ SỐ LẺ NHỎ NHẤT VÀ LỚN NHẤT
        int minLe = 10;   //Ban đầu đặt lớn hơn mọi chữ số (0-9)
        int maxLe = -1;   //Ban đầu đặt nhỏ hơn mọi chữ số (0-9)
            for (int i = 0; i < soChuSo; i++)
         {int chuSo = chuoiN[i] - '0';
            if (chuSo % 2 != 0) {
                if (chuSo < minLe)
                     minLe = chuSo;
                if (chuSo > maxLe)
                    maxLe = chuSo;  }
        } if (minLe == 10) {
            Console.WriteLine($"{n} khong co chu so le.");   }
         else {
            Console.WriteLine($"{n} co chu so le nho nhat la {minLe} va lon nhat la {maxLe}.");
            }
            Console.ReadLine();
        }
    }
}
// ============================================================
//              Xu ly chu so (1)
// ============================================================
//
// ------------------------------------------------------------
// TEST 1: Vi du de bai
// ------------------------------------------------------------
// Input:
//   182345
//   2
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 2 (tinh tu trai) cua 182345 la 8.
//   Tong cac chu so le cua 182345 la 9.
//   182345 co chu so le nho nhat la 1 va lon nhat la 5.
//
// ------------------------------------------------------------
// TEST 2: So khong co chu so le
// ------------------------------------------------------------
// Input:
//   2468
//   3
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 3 (tinh tu trai) cua 2468 la 6.
//   Tong cac chu so le cua 2468 la 0.
//   2468 khong co chu so le.
//
// ------------------------------------------------------------
// TEST 3: So co 1 chu so
// ------------------------------------------------------------
// Input:
//   7
//   1
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 1 (tinh tu trai) cua 7 la 7.
//   Tong cac chu so le cua 7 la 7.
//   7 co chu so le nho nhat la 7 va lon nhat la 7.
//
// ------------------------------------------------------------
// TEST 4: Toan so le
// ------------------------------------------------------------
// Input:
//   13579
//   5
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 5 (tinh tu trai) cua 13579 la 9.
//   Tong cac chu so le cua 13579 la 25.
//   13579 co chu so le nho nhat la 1 va lon nhat la 9.
//
// ------------------------------------------------------------
// TEST 5: So lon (kiem tra long)
// ------------------------------------------------------------
// Input:
//   154491287489
//   5
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 5 (tinh tu trai) cua 154491287489 la 9.
//   Tong cac chu so le cua 154491287489 la 25.
//   154491287489 co chu so le nho nhat la 1 va lon nhat la 9.
//
// ------------------------------------------------------------
// TEST 6: So 100
// ------------------------------------------------------------
// Input:
//   100
//   1
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 1 (tinh tu trai) cua 100 la 1.
//   Tong cac chu so le cua 100 la 1.
//   100 co chu so le nho nhat la 1 va lon nhat la 1.
//
// ------------------------------------------------------------
// TEST 7: Nhap sai k (lon hon so chu so)
// ------------------------------------------------------------
// Input:
//   123
//   5
//   3
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Nhap sai! Vui long nhap k tu 1 den 3: 
//   Chu so o vi tri 3 (tinh tu trai) cua 123 la 3.
//   Tong cac chu so le cua 123 la 4.
//   123 co chu so le nho nhat la 1 va lon nhat la 3.
//
// ------------------------------------------------------------
// TEST 8: Nhap sai n (so am)
// ------------------------------------------------------------
// Input:
//   -5
//   6
//   1
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Nhap sai! Vui long nhap so nguyen duong: 
//   Moi ban nhap vi tri k: 
//   Chu so o vi tri 1 (tinh tu trai) cua 6 la 6.
//   Tong cac chu so le cua 6 la 6.
//   6 co chu so le nho nhat la 6 va lon nhat la 6.
//
// ------------------------------------------------------------
// TEST 9: So 9999 (toan so 9)
// ------------------------------------------------------------
// Input:
//   9999
//   1
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Moi ban nhap vi tri k: 
//   Chu so o vi tri 1 (tinh tu trai) cua 9999 la 9.
//   Tong cac chu so le cua 9999 la 36.
//   9999 co chu so le nho nhat la 9 va lon nhat la 9.
