/*
* CHƯƠNG TRÌNH KIỂM TRA SỐ HOÀN HẢO
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 13/9/2026
*
* Phát biểu đề bài:Số tự nhiên n gọi là số hoàn hảo nếu tổng các ước tự nhiên của nó (không kể chính nó) bằng n. Cho số tự nhiên n, kiểm tra xem n có là số hoàn hảo không.
* Ý tưởng: Bước 1: Tìm tất cả ước của n (không kể n)
Ước của n là số mà n chia hết.
Ví dụ n = 6: các ước là 1, 2, 3, 6. Không kể 6, còn 1, 2, 3.
Cách tìm ước: Duyệt từ 1 đến n-1, số nào chia hết cho n thì là ước.
Bước 2: Tính tổng các ước
Cộng dồn tất cả ước tìm được
Lưu vào biến tongUoc
Bước 3: So sánh tổng với n
Nếu tongUoc == n -> số hoàn hảo 
Ngược lại -> không phải 
Bước 4: In kết quả theo định dạng đề bài
Bước 5: Tối ưu — chỉ duyệt đến n/2
* Mã giả:
CHƯƠNG TRÌNH Kiểm tra số hoàn hảo
BẮT ĐẦU
// Bước 1: Nhập n
    LẶP:
        In "Moi ban nhap n: "
        Đọc n
        NẾU n không phải số nguyên HOẶC n <= 0:
        In "Nhap sai!"
    LẶP LẠI
// Bước 2: Tìm và tính tổng các ước (không kể n)
    tongUoc = 0
    VỚI i TỪ 1 ĐẾN n/2:
    NẾU n % i == 0:
        tongUoc = tongUoc + i
// Bước 3: Kiểm tra và in kết quả
    NẾU tongUoc == n:
// In dạng: n = u1 + u2 + ... + uk la so hoan hao.
    In n + " = "
    laUocDauTien = ĐÚNG
    VỚI i TỪ 1 ĐẾN n/2:
    NẾU n % i == 0:
    NẾU KHÔNG laUocDauTien:
        In " + "
        In i
        laUocDauTien = SAI
        In " la so hoan hao."
    NGƯỢC LẠI:
        In n + " khong la so hoan hao."
    Dừng màn hình
KẾT THÚC
*/
using System;

namespace BUOI6
{ class KiemTraSoHoanHao
    { public static void Main(string[] args)
        {
        //BƯỚC 1: NHẬP n
        long n;
        Console.Write("Moi ban nhap n: ");
        while (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
            Console.Write("Nhap sai! Vui long nhap so nguyen duong: ");
            }
        //BƯỚC 2: TÍNH TỔNG CÁC ƯỚC (KHÔNG KỂ n)
            long tongUoc = 0;
        // Chỉ duyệt đến n/2 vì ước lớn nhất (không kể n) là n/2
            for (long i = 1; i <= n / 2; i++)
            {
            if (n % i == 0)   // i là ước của n
            {tongUoc = tongUoc + i;}
            }
        //BƯỚC 3: KIỂM TRA VÀ IN KẾT QUẢ
            if (tongUoc == n)
            {//TRƯỜNG HỢP: n là số hoàn hảo
                Console.Write($"{n} = ");
                bool laUocDauTien = true;
                for (long i = 1; i <= n / 2; i++)
                { if (n % i == 0) {
                        if (!laUocDauTien)
                        {
                            Console.Write(" + ");
                        }
                    Console.Write(i);
                    laUocDauTien = false;}
                }
                Console.WriteLine(" la so hoan hao.");
            }
            else
            {
            // TRƯỜNG HỢP: n không phải số hoàn hảo
                Console.WriteLine($"{n} khong la so hoan hao.");
            }

            Console.ReadLine();
        }
    }
}