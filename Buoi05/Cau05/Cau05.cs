using System;
/*
Chương trình: BÀI TẬP BUỔI 5
Tác giả: Bùi Phúc Hưng
Ngày viết: 14/09/2026
*/

/*
Viết chương trình hiển thị thực đơn:
THUC DON
1. Tinh dien tich tam giac
2. Tinh dien tich hinh chu nhat
3. Tinh dien tich hinh tron
4. Thoat
------------------------------------
Moi ban chon chuc nang [1, 2, 3, 4]:
Hiển thị kết quả chức năng người dùng chọn lựa, dừng chờ người dùng nhập phím bất kỳ và xóa màn hình để hiển thị lại thực đơn. 
Chương trình thoát khi người dùng chọn Thoát.

Ý tưởng:
In ra menu 4 lựa chọn cho người dùng nhập 
Dùng switch-case kiểm tra số vừa nhập:
  - Chọn 1, 2, 3: in ra thông báo chức năng tương ứng
  - Chọn 4: thoát chương trình
Sau khi in xong (nếu chưa bấm 4), cho tạm dừng chờ bấm phím rồi xóa sạch màn hình để vẽ lại menu
Lặp lại toàn bộ quá trình bằng vòng lặp do-while cho đến khi người dùng chọn 4 thì dừng.

Mã giả:
Lặp lại
    In ra danh sách menu từ 1 đến 4
    Nhập luaChon

    Xét luaChon
        Trường hợp 1: In "Ban moi vua chon chuc nang tinh dien tich tam giac."
        Trường hợp 2: In "Ban moi vua chon chuc nang tinh dien tich hinh chu nhat."
        Trường hợp 3: In "Ban moi vua chon chuc nang tinh dien tich hinh tron."
        Trường hợp 4: Thoát

    Nếu luaChon != 4 thì
        In "Ban nhan phim bat ky de tiep tuc ... "
        Chờ bấm phím
        Xóa màn hình
Trong khi luaChon != 4
*/

namespace NMLT.Buoi05
{
    public class ThucDon
    {
        public static void Main(string[] args)
        {
            int luaChon;

            do
            {
                // In thực đơn
                Console.WriteLine("THUC DON");
                Console.WriteLine("1. Tinh dien tich tam giac");
                Console.WriteLine("2. Tinh dien tich hinh chu nhat");
                Console.WriteLine("3. Tinh dien tich hinh tron");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("------------------------------------");

                // Nhập lựa chọn
                Console.Write("Moi ban chon chuc nang [1, 2, 3, 4]: ");
                luaChon = int.Parse(Console.ReadLine());

                Console.WriteLine("------------------------------------");

                // Xử lý lựa chọn
                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich tam giac.");
                        break;
                    case 2:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich hinh chu nhat.");
                        break;
                    case 3:
                        Console.WriteLine("Ban moi vua chon chuc nang tinh dien tich hinh tron.");
                        break;
                    case 4:
                        Console.WriteLine("Chuong trinh da thoat.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }

                // Nếu chưa chọn thoát thì dừng màn hình và xóa để hiện lại menu
                if (luaChon != 4)
                {
                    Console.WriteLine();
                    Console.Write("Ban nhan phim bat ky de tiep tuc ... ");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (luaChon != 4);
        }
    }
}