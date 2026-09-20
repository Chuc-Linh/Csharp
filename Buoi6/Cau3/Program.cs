/*
* CHƯƠNG TRÌNH PHÂN TÍCH THỪA SỐ NGUYÊN TỐ
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 13/9/2026
*
* Phát biểu đề bài: Nhập số nguyên n (n > 1). Hãy phân tích n thành tích các thừa số nguyên tố.
* Ý tưởng: Số nguyên tố là số chỉ chia hết cho 1 và chính nó. 
Thuật toán phân tích thừa số nguyên tố kinh điển: 
Với mỗi số nguyên tố p bắt đầu từ 2:
Trong khi n chia hết cho p:
    n = n / p
        Đếm số lần chia (đó là số mũ)
    Nếu số lần > 0:
        In ra p^số_lần
    p = p + 1 (thử số tiếp theo)
Lặp đến khi p > n
Cải tiến: chỉ thử đến căn bậc 2 của n 
* Mã giả: CHƯƠNG TRÌNH Phân tích thừa số nguyên tố
BẮT ĐẦU
// Bước 1: Nhập n
    LẶP:
        In "Moi ban nhap so nguyen n: "
        Đọc n
        NẾU n không phải số nguyên HOẶC n <= 1:
        In "Nhap sai! n phai > 1"
    LẶP LẠI
// Bước 2: Chuẩn bị in kết quả
    In "n = " (không xuống dòng)
    nGoc = n              // Lưu lại giá trị gốc để in
    laThuaSoDauTien = ĐÚNG
// Bước 3: Phân tích
    p = 2
    TRONG KHI p * p <= n:
        dem = 0
    TRONG KHI n % p == 0:
        n = n / p
        dem = dem + 1
    NẾU dem > 0:
    NẾU KHÔNG laThuaSoDauTien:
        In " x "
        In p
    NẾU dem > 1:
        In "^(dem)"
        laThuaSoDauTien = SAI
        p = p + 1
// Bước 4: Nếu n còn lại > 1, đó là số nguyên tố cuối
    NẾU n > 1:
    NẾU KHÔNG laThuaSoDauTien:
        In " x "
        In n
    Xuống dòng
    Dừng màn hình
KẾT THÚC
*/
using System;

namespace BUOI6
{   class PhanTichThuaSo1
{   public static void Main(string[] args){
    //BƯỚC 1: NHẬP n
    long n;
    Console.Write("Moi ban nhap so nguyen n: ");
    while (!long.TryParse(Console.ReadLine(), out n) || n <= 1)
    { Console.Write("Nhap sai! Vui long nhap so nguyen > 1: "); }
    //BƯỚC 2: IN PHẦN ĐẦU "n = "
      Console.Write($"{n} = ");
        long nGoc = n;   // Giữ giá trị gốc (n sẽ bị thay đổi trong vòng lặp)
        bool laThuaSoDauTien = true;   // Để biết khi nào cần in " x "
    //BƯỚC 3: PHÂN TÍCH THỪA SỐ NGUYÊN TỐ
        for (long p = 2; p * p <= n; p++){
        int dem = 0;   // Đếm số lần p chia hết n
        // Chia liên tục cho p khi còn chia hết
        while (n % p == 0){
            n = n / p;
            dem = dem + 1;}
        // Nếu p có xuất hiện ít nhất 1 lần
            if (dem > 0){
        // In dấu " x " trước thừa số (trừ thừa số đầu tiên)
            if (!laThuaSoDauTien)
        { Console.Write(" x ");}
        // In thừa số p
        Console.Write(p);
        // In số mũ nếu > 1
        if (dem > 1)
        {Console.Write($"^{dem}");}
        // Đánh dấu đã in ít nhất 1 thừa số
                    laThuaSoDauTien = false;
                }
            }
        //BƯỚC 4: XỬ LÝ SỐ NGUYÊN TỐ CÒN LẠI
        // Nếu sau vòng lặp mà n > 1, thì n là số nguyên tố cuối cùng
            if (n > 1)
            {if (!laThuaSoDauTien)
                {Console.Write(" x ");}
                Console.Write(n);
            }
            Console.WriteLine();   // Xuống dòng cuối
            Console.ReadLine();
        }
    }
//              Phan tich thua so nguyen to
// ============================================================
//
// ------------------------------------------------------------
// TEST 1: Vi du de bai
// ------------------------------------------------------------
// Input:
//   100
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 100 = 2^2 x 5^2
//
// ------------------------------------------------------------
// TEST 2: So co 2 thua so khac nhau
// ------------------------------------------------------------
// Input:
//   12
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 12 = 2^2 x 3
//
// ------------------------------------------------------------
// TEST 3: So co 3 thua so
// ------------------------------------------------------------
// Input:
//   30
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 30 = 2 x 3 x 5
//
// ------------------------------------------------------------
// TEST 4: So la luy thua
// ------------------------------------------------------------
// Input:
//   8
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 8 = 2^3
//
// ------------------------------------------------------------
// TEST 5: So nguyen to
// ------------------------------------------------------------
// Input:
//   7
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 7 = 7
//
// ------------------------------------------------------------
// TEST 6: So nguyen to nho nhat
// ------------------------------------------------------------
// Input:
//   2
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 2 = 2
//
// ------------------------------------------------------------
// TEST 7: So 14 (2 thua so)
// ------------------------------------------------------------
// Input:
//   14
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 14 = 2 x 7
//
// ------------------------------------------------------------
// TEST 8: So nguyen to lon
// ------------------------------------------------------------
// Input:
//   999999999989
//
// Output mong doi:
//   Moi ban nhap so nguyen n: 999999999989 = 999999999989
//
// ------------------------------------------------------------
// TEST 9: Nhap sai n (n = 1)
// ------------------------------------------------------------
// Input:
//   1
//   100
//
// Output mong doi:
//   Moi ban nhap so nguyen n: Nhap sai! Vui long nhap so nguyen > 1: 
//   100 = 2^2 x 5^2
//
// ============================================================
