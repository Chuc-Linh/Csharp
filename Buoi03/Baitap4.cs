// Ý TƯỞNG:
//   - Có đúng 12 tháng, mỗi tháng ứng với 1 tên tiếng Anh cố định(January, February, ..., December) -> không cần tính toán gì, chỉ cần "tra bảng" (lookup).
//   - Cách làm gọn nhất: tạo 1 mảng (array) chứa sẵn 12 tên tháng theo đúng thứ tự, rồi dùng tháng nhập vào làm CHỈ SỐ để lấy ra tên tương ứng.
//   - Lưu ý: mảng trong C# đánh chỉ số bắt đầu từ 0, còn tháng thì bắt đầu từ 1. Nên tháng 1 sẽ nằm ở chỉ số 0 của mảng, tháng 2 ở chỉ số 1,... Vậy công thức lấy đúng phần tử là:
//         tenThang = mangTenThang[thang - 1]
//   - Ngoài ra nên kiểm tra tháng nhập vào có hợp lệ không (phải nằm trong khoảng 1 đến 12), để tránh lỗi truy cập mảng ngoài phạm vi (index out of range).

// MÃ GIẢ:
//   BẮT ĐẦU
//     Tạo mảng tenThang gồm 12 phần tử: "January", "February", ..., "December"
//     In ra: "Moi ban nhap vao thang: "
//     Đọc số nguyên thang

//     NẾU thang < 1 HOẶC thang > 12 THÌ
//         In ra thông báo "Thang khong hop le!"
//     NGƯỢC LẠI
//         ten <- tenThang[thang - 1]
//         In ra: "Tieng anh cua thang thang la ten."
//   KẾT THÚC
 
// TEST CASE:
//   Input:  thang = 5
//   Output: Tieng anh cua thang 5 la May.
//
//   Input:  thang = 1
//   Output: Tieng anh cua thang 1 la January.
 
//   Input:  thang = 12
//   Output: Tieng anh cua thang 12 la December.

//   Input:  thang = 13   (trường hợp không hợp lệ)
//   Output: Thang khong hop le!


using System;
 
namespace Buoi03
{
    class Baitap4
    {
        public static void Mainbt4()
        {
            // Bước 1: Tạo sẵn mảng chứa tên 12 tháng, đúng thứ tự
            // Chỉ số 0 -> January (tháng 1), chỉ số 11 -> December (tháng 12)
            string[] tenThang = new string[]
            {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };
 
            // Bước 2: Đọc tháng từ bàn phím
            Console.Write("Moi ban nhap vao thang: ");
            int thang = int.Parse(Console.ReadLine()!);
 
            // Bước 3: Kiểm tra hợp lệ trước khi tra bảng
            if (thang < 1 || thang > 12)
            {
                Console.WriteLine("Thang khong hop le!");
                return;
            }
 
            // Bước 4: Tra tên tháng bằng chỉ số (thang - 1)
            string ten = tenThang[thang - 1];
 
            // Bước 5: In kết quả
            Console.WriteLine($"Tieng anh cua thang {thang} la {ten}.");
        }
    }
}
