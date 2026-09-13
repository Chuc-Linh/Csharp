using System;
/*
Chương trình: BÀI TẬP BUỔI 1
Nội dung: 4 bài tập cơ bản 
Tác giả: Lâm Duy Chúc Linh
Ngày viết: 08/09/2026
*/
// B. Bài tập cơ bản
/*
Phát biểu đề bài: HinhTron.*
Nhập vào bán kính R của một hình tròn. Hãy tính diện tích và chu vi hình tròn đó.
In kết quả với 1 số lẻ thập phân
Ý tưởng: cho người dùng nhập bán kính
Từ đó tính diện tích S và chu vi P
Mã giả:
Console.WriteLine("Nhap ban kinh")
double bankinh = double.Pasre(Console.ReadLine())
S = 3.14*bankinh*bankinh
P = 2*3.14*bankinh
*/
namespace NNLTBuoi1
{
    public class Buoi1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bai tap hinhtron");
            HinhTron();

            Console.WriteLine("Bai tap doisanggiay");
            DoiSangGiay();

            Console.WriteLine("Bai tap DoiSangGioPhutGiay");
            DoiSangGioPhutGiay();

            Console.WriteLine("Bai tap TinhMu");
            TinhMu();
        }

        public static void HinhTron()
        {
            Console.WriteLine("Hay nhap ban kinh");

            double bankinh;

            // double.TryParse là ktr xem là bankinh nhập vào có chuyển về double dc hay k
            /* TryParse sẽ làm 2 việc cùng lúc đó là chuyển về double và gán dữ liệu vào bankinh(out bankinh)
            nếu chuyển k dc thì nó thông báo nhưng nếu chuyển về double nhưng mà  <=0 thì cx báo lỗi*/

            while (true)
            {
                string? input = Console.ReadLine();

                // Nếu chạy test mà đã hết dữ liệu đầu vào thì thoát để tránh vòng lặp vô hạn
                if (input == null)
                    return;

                if (double.TryParse(input, out bankinh) && bankinh > 0)
                    break;

                Console.WriteLine("Ban kinh khong hop le!");
                Console.WriteLine("Hay nhap lai ban kinh:");
            }

            double pi = 3.14;
            double S = pi * Math.Pow(bankinh, 2);
            double P = 2 * pi * bankinh;

            Console.WriteLine("Dien tich S = {0}", S);
            Console.WriteLine("Chu vi P = {0:#.0}", P);
        }

        public static void DoiSangGiay()
        {
            /*
Phát biểu đề bài: DoiSangGiay.
Nhập vào giờ, phút, giây. Hãy đổi toàn bộ thời gian đã nhập sang giây.

Ý tưởng:
- Cho người dùng nhập lần lượt số giờ, số phút và số giây.
- Kiểm tra dữ liệu nhập vào có hợp lệ hay không.
- Đổi giờ sang giây bằng cách nhân với 3600.
- Đổi phút sang giây bằng cách nhân với 60.
- Cộng số giây ban đầu để được tổng số giây.

Mã giả:
Console.WriteLine("Nhap so gio")
hour = int.Parse(Console.ReadLine())
Console.WriteLine("Nhap so phut")
minute = int.Parse(Console.ReadLine())
Console.WriteLine("Nhap so giay")
second = int.Parse(Console.ReadLine())
tong = hour * 3600 + minute * 60 + second
Console.WriteLine(tong)
*/
            int hour, minute, second, tong;

            Console.WriteLine("Nhap so gio: ");
            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                // Cho phép 0 giờ, giờ tối đa 24
                if (int.TryParse(input, out hour) && hour >= 0 && hour <= 24)
                    break;

                Console.WriteLine("Gio khong hop le!");
                Console.WriteLine("Hay nhap lai gio:");
            }

            Console.WriteLine("Nhap so phut: ");
            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                // Phút hợp lệ từ 0 đến 59
                if (int.TryParse(input, out minute) && minute >= 0 && minute <= 59)
                    break;

                Console.WriteLine("Phut khong hop le!");
                Console.WriteLine("Hay nhap lai phut:");
            }

            Console.WriteLine("Nhap so giay: ");
            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                // Giây hợp lệ từ 0 đến 59
                if (int.TryParse(input, out second) && second >= 0 && second <= 59)
                    break;

                Console.WriteLine("Giay  khong hop le!");
                Console.WriteLine("Hay nhap lai giay :");
            }

            tong = hour * 3600 + minute * 60 + second;
            Console.WriteLine("Tong so giay cua {0}:{1}:{2} la {3}", hour, minute, second, tong);
        }
        /*
Phát biểu đề bài: DoiSangGioPhutGiay.
Nhập vào một số giây. Hãy đổi số giây đó sang dạng giờ : phút : giây.

Ý tưởng:
- Cho người dùng nhập tổng số giây.
- Lấy tổng số giây chia nguyên cho 3600 để tìm số giờ.
- Lấy phần dư sau khi chia cho 3600 để tìm số giây còn lại.
- Lấy số giây còn lại chia nguyên cho 60 để tìm số phút.
- Phần dư khi chia cho 60 chính là số giây.

Mã giả:
Console.WriteLine("Nhap so giay")
tonggiay = int.Parse(Console.ReadLine())
hour = tonggiay / 3600
tonggiay = tonggiay % 3600
minute = tonggiay / 60
second = tonggiay % 60
Console.WriteLine(hour + ":" + minute + ":" + second)
*/
        public static void DoiSangGioPhutGiay()
        {
            int hour, minute, second, tonggiay;

            Console.WriteLine("Nhap so giay: ");

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                if (int.TryParse(input, out tonggiay) && tonggiay > 0)
                    break;

                Console.WriteLine("Giay khong hop le!");
                Console.WriteLine("Hay nhap lai giay:");
            }

            int giaybandau = tonggiay;

            hour = tonggiay / 3600;
            tonggiay %= 3600;

            minute = tonggiay / 60;
            second = tonggiay % 60;

            Console.WriteLine("{0} giay co dang {1}:{2}:{3}", giaybandau, hour, minute, second);
        }
/*Phát biểu đề bài: TinhMu.
Nhập vào số dương a và số nguyên không âm n. Hãy tính a mũ n.

Ý tưởng:
- Cho người dùng nhập cơ số a và số mũ n.
- Kiểm tra a phải là số dương và n phải là số nguyên không âm.
- Sử dụng Math.Pow(a, n) để tính a mũ n.
- In kết quả ra màn hình.

Mã giả:
Console.WriteLine("Nhap a")
a = double.Parse(Console.ReadLine())
Console.WriteLine("Nhap n")
n = int.Parse(Console.ReadLine())
ketqua = Math.Pow(a, n)
Console.WriteLine(ketqua)
*/
        public static void TinhMu()
        {
            double a;
            int n;

            Console.WriteLine("Nhap so duong a =  ");

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                // a là số dương nên phải > 0
                if (double.TryParse(input, out a) && a > 0)
                    break;

                Console.WriteLine("a khong hop le!");
                Console.WriteLine("Hay nhap lai a:");
            }

            Console.WriteLine("Nhap so mu n = ");

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    return;

                if (int.TryParse(input, out n) && n >= 0)
                    break;

                Console.WriteLine("n khong hop le!");
                Console.WriteLine("Hay nhap lai n:");
            }

            double ketqua = Math.Pow(a, n);
            Console.WriteLine("Ket qua {0} ^ {1} = {2}", a, n, ketqua);
        }
    }
}
