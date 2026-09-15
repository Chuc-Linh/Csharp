using System;
/*
Chương trình: BÀI TẬP BUỔI 4
Nội dung: 5 bài tập mẫu + 5 bài tập cơ bản + 5 bài tập nâng cao
Tác giả: Bùi Phúc Hưng
Ngày viết: 10/09/2026
*/

/*
Phát biểu đề bài: NgaySau.*

Nhập vào ngày, tháng, năm. Hỏi ngày tiếp theo là ngày nào?
Dữ liệu nhập: ba số nguyên ngày tháng năm
Dữ liệu xuất: in ra ngày tiếp theo

Ý tưởng:
Cho người dùng nhập ngày tháng năm
Dùng switch-case tìm số ngày của tháng

Riêng tháng 2: Năm nhuận chia hết cho 400 hoặc chia hết cho 4 mà ko chia hết cho 100 thì có 29 ngày, ngược lại có 28 ngày
Từ đó ra: (năm % 400 == 0) hoặc (năm % 4 == 0 và năm % 100 != 0).

Nếu chưa hết tháng thì tăng thêm 1 ngày
Nếu là ngày cuối tháng thì đổi ngày về 1, tăng thêm 1 tháng 
(riêng tháng 12 thì đổi về tháng 1 và tăng thêm 1 năm)

Mã giả:
Nhập ngày tháng năm
Tìm số ngày trong tháng dựa vào tháng (tháng 2 kiểm tra năm nhuận: năm chia hết cho 400 hoặc chia hết cho 4 nhưng không chia hết cho 100)
Nếu (ngày < số ngày trong tháng)
    ngày mới=ngày + 1
    tháng mới=tháng
    năm mới=năm
Ngược lại
    ngày mới=1
    Nếu (tháng == 12)
        tháng mới=1
        năm mới=năm + 1
    Ngược lại
        tháng mới=tháng + 1
        năm mới=năm

In ra ngày tiếp theo
*/

// BÀI TẬP CƠ BẢN CÂU 3
namespace NMLT.Buoi04
{
    public class NgaySau
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            int ngay, thang, nam;
            int ngayKeTiep, thangKeTiep, namKeTiep;
            int soNgayTrongThang = 0;

            // Nhập ngày tháng năm
            Console.Write("Moi ban nhap ngay, thang, nam: ");
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ngay = int.Parse(parts[0]);
            thang = int.Parse(parts[1]);
            nam = int.Parse(parts[2]);

            // Kiểm tra số ngày của tháng có đúng hay ko
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    soNgayTrongThang = 31; // các tháng có 31 ngày
                    break;
                case 4: case 6: case 9: case 11:
                    soNgayTrongThang = 30; // các tháng có 30 ngày
                    break;
                case 2:
                    // Tính năm nhuận
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                    {
                        soNgayTrongThang = 29;
                    }
                    else
                    {
                        soNgayTrongThang = 28;
                    }
                    break;
            }

            // Tìm ngày kế tiếp
            if (ngay < soNgayTrongThang)
            {
                // Chưa phải ngày cuối tháng nên chỉ cần tăng ngày
                ngayKeTiep = ngay + 1;
                thangKeTiep = thang;
                namKeTiep = nam;
            }
            else
            {
                // Là ngày cuối cùng của tháng thì quay về ngày 1
                ngayKeTiep = 1;

                if (thang == 12)
                {
                    // nếu là ngày cuối của năm thì chuyển sang năm tiếp theo
                    thangKeTiep = 1;
                    namKeTiep = nam + 1;
                }
                else
                {
                    // không phải ngày cuối của năm thì chỉ chuyển sang tháng tiếp theo
                    thangKeTiep = thang + 1;
                    namKeTiep = nam;
                }
            }

            // In kết quả 
            Console.WriteLine("Ngay sau ngay {0}/{1}/{2} la ngay {3}/{4}/{5}.", 
                ngay, thang, nam, ngayKeTiep, thangKeTiep, namKeTiep);
        }
    }
}