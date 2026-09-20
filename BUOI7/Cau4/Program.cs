/*
* CHƯƠNG TRÌNH TÍNH NGÀY TRƯỚC 
* Tác giả : Nguyễn Ngọc Xuân Trúc
* Ngày viết: 20/9/2026
*
* Phát biểu đề bài:Nhập vào ngày, tháng, năm. Hỏi ngày trước đó là ngày nào?
* Ý tưởng:
B1: Kiểm tra tính hợp lệ của ngày tháng năm
Cần kiểm tra:
nam >= 1
thang từ 1 đến 12
ngay từ 1 đến số ngày tối đa của tháng đó
B2: Xác định số ngày của từng tháng
Tháng 1, 3, 5, 7, 8, 10, 12: 31
Tháng 4, 6, 9, 11: 30
Tháng 2: 28 (không nhuận) hoặc 29 (nhuận)
B3: Kiểm tra năm nhuận
Năm nhuận là năm:
Chia hết cho 4 VÀ không chia hết cho 100
HOẶC chia hết cho 400
B4: Tìm ngày trước đó
Trường hợp 1: ngay > 1 (ngày bình thường)
ngayTruoc = ngay - 1
thangTruoc = thang
namTruoc = nam
Trường hợp 2: ngay == 1 và thang > 1 (đầu tháng, không phải 1/1)
ngayTruoc = số ngày của tháng trước
thangTruoc = thang - 1
namTruoc = nam
Trường hợp 3: ngay == 1 và thang == 1 (1/1)
ngayTruoc = 31 (ngày 31/12)
thangTruoc = 12
namTruoc = nam - 1
B5: In kết quả
Format: Ngay truoc ngay d/m/y la ngay d/m/y.
* Mã giả:CHƯƠNG TRÌNH Tìm ngày trước

BẮT ĐẦU
    // Bước 1: Nhập ngày, tháng, năm
    LẶP:
        In "Moi ban nhap ngay: "
        Đọc ngay
        NẾU ngay không hợp lệ: LẶP LẠI
    
    LẶP:
        In "Moi ban nhap thang: "
        Đọc thang
        NẾU thang < 1 HOẶC thang > 12: LẶP LẠI
    
    LẶP:
        In "Moi ban nhap nam: "
        Đọc nam
        NẾU nam < 1: LẶP LẠI
    
    // Bước 2: Kiểm tra ngày có hợp lệ trong tháng không
    soNgayTrongThang = LaySoNgayTrongThang(thang, nam)
    NẾU ngay < 1 HOẶC ngay > soNgayTrongThang:
        In "Ngay khong hop le!"
        KẾT THÚC
    
    // Bước 3: Tìm ngày trước
    NẾU ngay > 1:
        ngayTruoc = ngay - 1
        thangTruoc = thang
        namTruoc = nam
    NGƯỢC LẠI:  // ngay == 1
        NẾU thang > 1:
            thangTruoc = thang - 1
            namTruoc = nam
            ngayTruoc = LaySoNgayTrongThang(thangTruoc, namTruoc)
        NGƯỢC LẠI:  // thang == 1
            ngayTruoc = 31
            thangTruoc = 12
            namTruoc = nam - 1
    
    // Bước 4: In kết quả
    In "Ngay truoc ngay " + ngay + "/" + thang + "/" + nam + " la ngay " + ngayTruoc + "/" + thangTruoc + "/" + namTruoc + "."
    
    Dừng màn hình
KẾT THÚC


HÀM KiemTraNamNhuan(nam):
    NẾU (nam % 4 == 0 VÀ nam % 100 != 0) HOẶC (nam % 400 == 0):
        TRẢ VỀ ĐÚNG
    NGƯỢC LẠI:
        TRẢ VỀ SAI
HẾT HÀM
HÀM LaySoNgayTrongThang(thang, nam):
    NẾU thang == 2:
        NẾU KiemTraNamNhuan(nam):
            TRẢ VỀ 29
        NGƯỢC LẠI:
            TRẢ VỀ 28
    NGƯỢC LẠI NẾU thang == 4 HOẶC thang == 6 HOẶC thang == 9 HOẶC thang == 11:
        TRẢ VỀ 30
    NGƯỢC LẠI:
        TRẢ VỀ 31
HẾT HÀM
*/
using System;

namespace Cau4
{
    class TimNgayTruoc
    {        public static void Main(string[] args)
        {
            //BƯỚC 1: NHẬP NGÀY, THÁNG, NĂM
            int ngay, thang, nam;
            Console.Write("Moi ban nhap ngay: ");
            while (!int.TryParse(Console.ReadLine(), out ngay) || ngay < 1 || ngay > 31)
            {
                Console.Write("Nhap sai! Vui long nhap ngay (1-31): ");
            }
            Console.Write("Moi ban nhap thang: ");
            while (!int.TryParse(Console.ReadLine(), out thang) || thang < 1 || thang > 12)
            {
                Console.Write("Nhap sai! Vui long nhap thang (1-12): ");
            }
            Console.Write("Moi ban nhap nam: ");
            while (!int.TryParse(Console.ReadLine(), out nam) || nam < 1)
            {
                Console.Write("Nhap sai! Vui long nhap nam duong: ");
            }
            //BƯỚC 2: KIỂM TRA NGÀY HỢP LỆ
            int soNgayTrongThang = LaySoNgayTrongThang(thang, nam);
            if (ngay > soNgayTrongThang)
            {
                Console.WriteLine($"Ngay {ngay}/{thang}/{nam} khong hop le!");
                Console.ReadLine();
                return;
            }
            //BƯỚC 3: TÌM NGÀY TRƯỚC
            int ngayTruoc, thangTruoc, namTruoc;
            if (ngay > 1)
            {
            // Trường hợp 1: Ngày bình thường
                ngayTruoc = ngay - 1;
                thangTruoc = thang;
                namTruoc = nam;
            }
            else if (thang > 1)
            {
            // Trường hợp 2: Đầu tháng (không phải 1/1)
                thangTruoc = thang - 1;
                namTruoc = nam;
                ngayTruoc = LaySoNgayTrongThang(thangTruoc, namTruoc);
            }
            else
            {
                // Trường hợp 3: 1/1
                ngayTruoc = 31;
                thangTruoc = 12;
                namTruoc = nam - 1;
            }
            //BƯỚC 4: IN KẾT QUẢ
            Console.WriteLine($"Ngay truoc ngay {ngay}/{thang}/{nam} la ngay {ngayTruoc}/{thangTruoc}/{namTruoc}.");
            Console.ReadLine();
        }
        //HÀM KIỂM TRA NĂM NHUẬN 
        static bool KiemTraNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }

        //HÀM LẤY SỐ NGÀY TRONG THÁNG
        static int LaySoNgayTrongThang(int thang, int nam)
        {
            if (thang == 2)
            {
                if (KiemTraNamNhuan(nam))
                {
                    return 29;
                }
                return 28;
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                return 30;
            }
            return 31;
        }
    }
}

