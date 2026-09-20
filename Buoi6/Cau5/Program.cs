/*
* CHƯƠNG TRÌNH LIỆT KÊ SỐ HOÀN HẢO
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 14/9/2026
*
* Phát biểu đề bài: Nhập số nguyên dương n. Hãy liệt kê các số hoàn hảo trong đoạn [1, n] theo thứ tự giảm dần.
* Ý tưởng:
a) Số k là số hoàn hảo nếu: Tổng các ước của k (không kể k) == k
Ta có thể viết hàm KiemTraHoanHao(k) trả về true/false.
Duyệt từ 1 đến n
VỚI k TỪ 1 ĐẾN n:
    NẾU KiemTraHoanHao(k):
       In k
-> Nhưng nếu in luôn thì kết quả tăng dần:
b) In giảm dần
Duyệt từ n về 1 (giảm dần từ đầu)
VỚI k TỪ n GIẢM VỀ 1:
    NẾU KiemTraHoanHao(k) -> in k 
c) Trường hợp không có số hoàn hảo 
Đếm số lượng số hoàn hảo tìm được. Nếu dem == 0-> in không có
* Mã giả:
CHƯƠNG TRÌNH Liệt kê số hoàn hảo
BẮT ĐẦU
    //Bước 1: Nhập n
    LẶP:
        In "Moi ban nhap so n: "
        Đọc n
        NẾU n không phải số nguyên HOẶC n <= 0:
        In "Nhap sai!"
    LẶP LẠI
    // Bước 2: In tiêu đề
    In "Cac so hoan hao trong doan [1, n]: " (không xuống dòng)
    // Bước 3: Duyệt TỪ n VỀ 1 để in giảm dần
    dem = 0
    VỚI k TỪ n GIẢM VỀ 1:
        NẾU KiemTraHoanHao(k) == ĐÚNG:
            In k + " "
            dem = dem + 1
    // Bước 4: Xử lý nếu không có số hoàn hảo
    NẾU dem == 0:
        In "khong co"
    Xuống dòng
    Dừng màn hình
KẾT THÚC
HÀM KiemTraHoanHao(k):
    NẾU k < 2:
        TRẢ VỀ SAI
    tongUoc = 0
    VỚI i TỪ 1 ĐẾN k/2:
        NẾU k % i == 0:
        tongUoc = tongUoc + i
    TRẢ VỀ (tongUoc == k)
HẾT HÀM
*/
using System;
namespace BUOI6
{class LietKeSoHoanHao
    {public static void Main(string[] args)
        {
        //BƯỚC 1: NHẬP n
        long n;
        Console.Write("Moi ban nhap so n: ");
        while (!long.TryParse(Console.ReadLine(), out n) || n <= 0)
        { Console.Write("Nhap sai! Vui long nhap so nguyen duong: ");}
        //BƯỚC 2: IN TIÊU ĐỀ
          Console.Write($"Cac so hoan hao trong doan [1, {n}]: ");
        //BƯỚC 3: DUYỆT TỪ n VỀ 1 (GIẢM DẦN)
          int dem = 0;   // Đếm số lượng số hoàn hảo tìm được
          for (long k = n; k >= 1; k--){
                if (KiemTraHoanHao(k))
                {
                Console.Write(k + " ");
                dem = dem + 1;}
            }
        //BƯỚC 4: XỬ LÝ NẾU KHÔNG CÓ SỐ HOÀN HẢO
            if (dem == 0)
            {
                Console.Write("khong co");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        //HÀM KIỂM TRA 1 SỐ CÓ PHẢI SỐ HOÀN HẢO KHÔNG
        static bool KiemTraHoanHao(long k)
        {
        // Số hoàn hảo nhỏ nhất là 6, nên k < 2 chắc chắn không phải
            if (k < 2)
            {return false;}

        // Tính tổng các ước (không kể k)
            long tongUoc = 0;
            for (long i = 1; i <= k / 2; i++)
            {
                if (k % i == 0)
                {
                    tongUoc = tongUoc + i;
                }
            }

            // So sánh tổng với k
            return tongUoc == k;
        }
    }
}
//              Liet ke so hoan hao
// TEST 1: Vi du de bai (n = 10)
// ------------------------------------------------------------
// Input:
//   10
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 10]: 6 
//
// ------------------------------------------------------------
// TEST 2: n = 30 (co 2 so hoan hao)
// ------------------------------------------------------------
// Input:
//   30
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 30]: 28 6 
//
// ------------------------------------------------------------
// TEST 3: n = 500 (co 3 so hoan hao)
// ------------------------------------------------------------
// Input:
//   500
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 500]: 496 28 6 
//
// ------------------------------------------------------------
// TEST 4: n = 5 (khong co so hoan hao)
// ------------------------------------------------------------
// Input:
//   5
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 5]: khong co
//
// ------------------------------------------------------------
// TEST 5: n = 6 (co 1 so hoan hao)
// ------------------------------------------------------------
// Input:
//   6
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 6]: 6 
//
// ------------------------------------------------------------
// TEST 6: n = 10000 (co 4 so hoan hao)
// ------------------------------------------------------------
// Input:
//   10000
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 10000]: 8128 496 28 6 
//
// ------------------------------------------------------------
// TEST 7: n = 1 (khong co so hoan hao)
// ------------------------------------------------------------
// Input:
//   1
//
// Output mong doi:
//   Moi ban nhap so n: Cac so hoan hao trong doan [1, 1]: khong co
//
// ------------------------------------------------------------
// TEST 8: Nhap sai (so am)
// ------------------------------------------------------------
// Input:
//   -5
//   30
//
// Output mong doi:
//   Moi ban nhap so n: Nhap sai! Vui long nhap so nguyen duong: 
//   Cac so hoan hao trong doan [1, 30]: 28 6 
//
// 
