/*
* CHƯƠNG TRÌNH TÍNH SỐ PI
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 20/9/2026
* Phát biểu đề bài: Nhập vào sai số epsilon. Viết chương trình tính số π với độ sai số epsilon theo công thức:
π = 4 × (1 − 1/3 + 1/5 − 1/7 + ... + (−1)ⁿ × 1/(2n+1) + ...)
cho đến khi 4/(2n+1) < epsilon
* Ý tưởng: 
B1: Nhập epsilon
Nhập số thực epsilon > 0 (ví dụ 0.001, 0.0001, 1e-6)
Dùng double vì đây là số thực
B2: Tính tổng chuỗi
Bắt đầu với n = 0
Cộng từng số hạng (−1)ⁿ/(2n+1) vào tổng
Tăng n lên 1
Lặp cho đến khi 4/(2n+1) < epsilon
B3: Nhân tổng với 4 để ra π
pi = 4 × tong
B4: Tính sai số thực tế
So sánh với π thật: Math.PI ≈ 3.14159265358979
Sai số thực tế = |pi_tính_được − Math.PI|
B5: In kết quả
In π tính được
In sai số thực tế
* Mã giả:CHƯƠNG TRÌNH Tính số Pi
BẮT ĐẦU
// Bước 1: Nhập epsilon
    LẶP:
        In "Moi ban nhap do sai so epsilon: "
        Đọc epsilon
        NẾU epsilon không phải số thực HOẶC epsilon <= 0:
            In "Nhap sai!"
            LẶP LẠI
    
 // Bước 2: Tính tổng chuỗi
    tong = 0.0
    n = 0
    dau = 1.0
    LẶP LẠI (do-while):
        tong = tong + dau * 1.0 / (2*n + 1)
        dau = -dau        // Đổi dấu cho số hạng tiếp theo
        n = n + 1
    TRONG KHI (4.0 / (2*n + 1) >= epsilon)
    
// Bước 3: Tính Pi
    pi = 4.0 * tong
    
// Bước 4: Tính sai số thực tế
    saiSoThucTe = |pi - Math.PI|
    
// Bước 5: In kết quả
    In "So pi tinh den do chinh xac " + epsilon + " la " + pi
    In "Do sai so so thuc te la " + saiSoThucTe
    
    Dừng màn hình
KẾT THÚC
*/
using System;

namespace BUOI7
{
    class TinhSoPi
    {
        public static void Main(string[] args)
        {
            // BƯỚC 1: NHẬP epsilo
            double epsilon;
            Console.Write("Moi ban nhap do sai so epsilon: ");
            while (!double.TryParse(Console.ReadLine(), out epsilon) || epsilon <= 0)
            {
                Console.Write("Nhap sai! Vui long nhap so thuc duong: ");
            }

            //BƯỚC 2: TÍNH TỔNG CHUỖI
            double tong = 0.0;
            int n = 0;
            double dau = 1.0;
            do
            {
                // Cộng số hạng (−1)^n / (2n+1)
                tong = tong + dau * 1.0 / (2 * n + 1);

                // Đổi dấu cho số hạng tiếp theo
                dau = -dau;

                // Tăng n
                n = n + 1;
            }
            while (4.0 / (2 * n + 1) >= epsilon);

            //BƯỚC 3: TÍNH Pi
            double pi = 4.0 * tong;

            //BƯỚC 4: TÍNH SAI SỐ THỰC TẾ
            double saiSoThucTe = Math.Abs(pi - Math.PI);

            //BƯỚC 5: IN KẾT QUẢ
            Console.WriteLine($"So pi tinh den do chinh xac {epsilon} la {pi}.");
            Console.WriteLine($"Do sai so so thuc te la {saiSoThucTe}.");

            Console.ReadLine();
        }
    }
}
// ============================================================
//              Tinh so Pi (cong thuc Leibniz)
// ============================================================
//
// LUU Y: Ket qua Pi co the sai lech vai chu so cuoi
//        do sai so dau phay dong cua may tinh.
//        Day la hien tuong BINH THUONG.
//
// ------------------------------------------------------------
// TEST 1: Vi du de bai (epsilon = 0.001)
// ------------------------------------------------------------
// Input:
//   0.001
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: 
//   So pi tinh den do chinh xac 0.001 la 3.14109265362104.
//   Do sai so so thuc te la 0.000500000031244611.
//
// ------------------------------------------------------------
// TEST 2: epsilon = 0.0001 (chinh xac hon)
// ------------------------------------------------------------
// Input:
//   0.0001
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: 
//   So pi tinh den do chinh xac 0.0001 la 3.14149265359003.
//   Do sai so so thuc te la 9.99999997406814E-05.
//
// ------------------------------------------------------------
// TEST 3: epsilon = 1e-6 (rat chinh xac)
// ------------------------------------------------------------
// Input:
//   1e-6
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: 
//   So pi tinh den do chinh xac 1E-06 la 3.14159165358977.
//   Do sai so so thuc te la 1.00000001511301E-06.
//
// ------------------------------------------------------------
// TEST 4: epsilon = 1 (dung ngay)
// ------------------------------------------------------------
// Input:
//   1
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: 
//   So pi tinh den do chinh xac 1 la 4.
//   Do sai so so thuc te la 0.858407346410207.
//
// ------------------------------------------------------------
// TEST 5: epsilon = 0.1
// ------------------------------------------------------------
// Input:
//   0.1
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: 
//   So pi tinh den do chinh xac 0.1 la 3.33968253968254.
//   Do sai so so thuc te la 0.198089886092746.
//
// ------------------------------------------------------------
// TEST 6: Nhap sai (epsilon am)
// ------------------------------------------------------------
// Input:
//   -0.5
//   0.001
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: Nhap sai! Vui long nhap so thuc duong: 
//   So pi tinh den do chinh xac 0.001 la 3.14109265362104.
//   Do sai so so thuc te la 0.000500000031244611.
//
// ------------------------------------------------------------
// TEST 7: Nhap sai (chuoi ky tu)
// ------------------------------------------------------------
// Input:
//   abc
//   0.001
//
// Output mong doi:
//   Moi ban nhap do sai so epsilon: Nhap sai! Vui long nhap so thuc duong: 
//   So pi tinh den do chinh xac 0.001 la 3.14109265362104.
//   Do sai so so thuc te la 0.000500000031244611.
