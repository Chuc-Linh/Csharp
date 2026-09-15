using System;
/*
Chương trình: BÀI TẬP BUỔI 4
Nội dung: 5 bài tập mẫu + 5 bài tập cơ bản + 5 bài tập nâng cao
Tác giả: Bùi Phúc Hưng
Ngày viết: 09/09/2026
*/

/*
Phát biểu đề bài: TienNuoc.*

Cứ mỗi tháng nhân viên nước đi ghi chỉ số nước của từng hộ gia đình bao gồm thông tin chỉ số nước cũ, 
chỉ số nước mới và số người tiêu thụ (đã đăng ký). Biết bảng giá định mức sử dụng nước của từng người trên tháng:
- 4m^3 đầu tiên: 4.400 Đ/m^3
- 2m^3 kế tiếp: 8.300 Đ/m^3
- Những m^3 tiếp theo: 10.500 Đ/m^3
Tổng số tiền mà hộ phải trả cho bên bán nước là số tiền tính được theo số m^3 tiêu thụ trên tổng số người 
đăng ký trong hộ cộng với tiền thuế giá trị gia tăng là 5% và phí bảo vệ môi trường là 10%. 
Hãy tính số tiền nước tiêu thụ của một hộ gia đình.

Ý tưởng:
Cho người dùng nhập chỉ số nước cũ, chỉ số nước mới và số người tiêu thụ.
Tính lượng nước tiêu thụ: tongNuoc = chiSoMoi - chiSoCu.
Tính các mốc định mức tiêu thụ cho toàn bộ hộ gia đình:
- Định mức 1 = 4 * soNguoi
- Định mức 2 = 2 * soNguoi
Tính tổng tiền phải trả bằng cách cộng thêm thuế GTGT (5%) và phí BVMT (10%):

Thuế = Tiền chưa thuế * 0.05 , Phí BVMT = Tiền chưa thuế * 0.1 
Tổng tiền = Tiền chưa thuế + Thuế + Phí BVMT 
Từ đó ra: Tổng tiền = Tiền chưa thuế * (1+0.05+0.1)

In ra số khối nước tiêu thụ và tổng tiền cần thanh toán.

Mã giả:
Nhập chiSoCu, chiSoMoi, soNguoi
tongNuoc = chiSoMoi - chiSoCu
dinhMuc1 = 4 * soNguoi
dinhMuc2 = 2 * soNguoi

Nếu (tongNuoc <= dinhMuc1)
    tienChuaThue = tongNuoc * 4400
Ngược lại nếu (tongNuoc <= dinhMuc1 + dinhMuc2)
    tienChuaThue = dinhMuc1 * 4400 + (tongNuoc - dinhMuc1) * 8300
Ngược lại
    tienChuaThue = dinhMuc1 * 4400 + dinhMuc2 * 8300 + (tongNuoc - dinhMuc1 - dinhMuc2) * 10500

tongTien = tienChuaThue * 1.15
Xuất tongNuoc và tongTien
*/

// BÀI TẬP CƠ BẢN CÂU 2
namespace NMLT.Buoi04
{
    public class TienNuoc
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            double chiSoCu, chiSoMoi, tongNuoc;
            int soNguoi;
            double tienChuaThue = 0;
            double tongTien;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap chi so tieu thu nuoc thang truoc (m^3): ");
            chiSoCu = double.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap chi so tieu thu nuoc trong thang (m^3): ");
            chiSoMoi = double.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap so nguoi tieu thu: ");
            soNguoi = int.Parse(Console.ReadLine());

            // Tính tổng số khối nước tiêu thụ
            tongNuoc = chiSoMoi - chiSoCu;

            if (tongNuoc < 0)
            {
                Console.WriteLine("Chi so moi phai lon hon hoac bang chi so cu.");
                return;
            }

            // Tính theo tổng số người trong hộ gia đình
            double dinhMuc1 = 4 * soNguoi; // 4m3 đầu tiên
            double dinhMuc2 = 2 * soNguoi; // 2m3 kế tiếp

            if (tongNuoc <= dinhMuc1)
            {
                tienChuaThue = tongNuoc * 4400;
            }
            else if (tongNuoc <= dinhMuc1 + dinhMuc2)
            {
                tienChuaThue = (dinhMuc1 * 4400) + (tongNuoc - dinhMuc1) * 8300;
            }
            else
            {
                tienChuaThue = (dinhMuc1 * 4400) + (dinhMuc2 * 8300) + (tongNuoc - dinhMuc1 - dinhMuc2) * 10500;
            }

            // Cộng thuế 5% và phí bảo vệ môi trường 10%
            tongTien = tienChuaThue * 1.15;

            // Xuất kết quả
            Console.WriteLine("So tien phai tra cho {0} m^3 tieu thu trong thang la {1:N0} Đ.", tongNuoc, tongTien);
        }
    }
}