using System;
/*
Chương trình: BÀI TẬP BUỔI 4
Nội dung: 5 bài tập mẫu + 5 bài tập cơ bản + 5 bài tập nâng cao
Tác giả: Bùi Phúc Hưng
Ngày viết: 09/09/2026
*/

/*
Phát biểu đề bài: DiemTrungBinh.*

Viết chương trình nhập vào 3 điểm Toán, Lý, Hóa. Tính ĐTB và phân loại học sinh như sau:
ĐTB = (Toán * 2 + Lý * 3 + Hóa)/6.
Sau đó xếp loại học lực: 
- Nếu 8 <= DTB <= 10 xếp loại Giỏi
- Nếu 6.5 <= DTB < 8 xếp loại Khá
- Nếu 5 <= DTB < 6.5 xếp loại Trung bình
- Nếu DTB < 5 xếp loại Yếu
Ý tưởng:
- Cho người dùng nhập điểm của 3 môn Toán, Lý, Hóa.
- Tính ĐTB theo yêu cầu đề.

Mã giả:
Console.Write("Moi ban nhap diem toan, ly, hoa: ")
double toan = double.Parse(Console.ReadLine())
double ly = double.Parse(Console.ReadLine())
double hoa = double.Parse(Console.ReadLine())

dtb = (toan * 2 + ly * 3 + hoa) / 6

Nếu (dtb >= 6.5)
    In ra dtb định dạng 2 số lẻ và loại Khá
Ngược lại nếu (dtb >= 5)
    In ra dtb định dạng 2 số lẻ và loại Trung bình
Ngược lại
    In ra dtb định dạng 2 số lẻ và loại Yếu
*/

// BÀI TẬP CƠ BẢN CÂU 1
namespace NMLT.Buoi04
{
    public class DiemTrungBinh
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            double toan, ly, hoa, dtb;

            // Nhập dữ liệu
            Console.Write("Moi ban nhap diem toan, ly, hoa: ");
            toan = double.Parse(Console.ReadLine());
            ly = double.Parse(Console.ReadLine());
            hoa = double.Parse(Console.ReadLine());

            // Tính ĐTB
            dtb = (toan * 2 + ly * 3 + hoa) / 6;

            // Xếp loại
            if (dtb >= 6.5)
                Console.WriteLine("Ban co diem trung binh {0:F2} duoc xep loai Kha.", dtb);
            else if (dtb >= 5)
                Console.WriteLine("Ban co diem trung binh {0:F2} duoc xep loai Trung binh.", dtb);
            else
                Console.WriteLine("Ban co diem trung binh {0:F2} duoc xep loai Yeu.", dtb);
        }
    }
}