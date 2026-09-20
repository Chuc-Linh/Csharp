using System;
using System.Collections.Generic;
using System.Globalization;

/*
Chương trình: BÀI TẬP BUỔI 12
Nội dung:
    Bài 1. Tổng các số chẵn, lẻ
    Bài 2. Đếm số trên biên
    Bài 3. Ma trận toàn lẻ
    Bài 4. Liệt kê dòng tăng dần
    Bài 5. Liệt kê cột có tổng lớn nhất
*/

namespace NNLTBuoi12
{
    public class Buoi12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bai 1. Tong cac so chan, le");
            TongChanLeMang2C();

            Console.WriteLine("Bai 2. Dem so tren bien");
            DemSoTrenBienMang2C();

            Console.WriteLine("Bai 3. Ma tran toan le");
            MaTranToanLe();

            Console.WriteLine("Bai 4. Liet ke dong tang dan");
            DongTangDan();

            Console.WriteLine("Bai 5. Liet ke cot co tong lon nhat");
            CotTongLonNhat();
        }

        /*
        Phát biểu đề bài: TongChanLeMang2C
        Cho ma trận A chứa các số nguyên có n dòng và m cột (1 <= n, m <= 100).
        Hãy tính tổng các số chẵn, số lẻ có trong ma trận A.

        Ý tưởng:
        - Nhập n, m và ma trận A.
        - Duyệt từng phần tử.
        - Số chia hết cho 2 cộng vào tổng chẵn, ngược lại cộng vào tổng lẻ.

        Mã giả:
        tongChan = 0, tongLe = 0
        với mỗi A[i,j]:
            nếu A[i,j] % 2 == 0:
                tongChan += A[i,j]
            ngược lại:
                tongLe += A[i,j]
        */

        public static void TongChanLeMang2C()
        {
            int n = NhapKichThuoc("Nhap so dong n: ");
            int m = NhapKichThuoc("Nhap so cot m: ");
            int[,] a = NhapMaTranNguyen(n, m);

            Console.WriteLine("// Nhap A");
            InMaTran(a);

            int tongChan = 0;
            int tongLe = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] % 2 == 0)
                        tongChan += a[i, j];
                    else
                        tongLe += a[i, j];

            Console.WriteLine("Tong cac so chan la {0} va tong so le la {1}.",
                              tongChan, tongLe);
        }

        /*
        Phát biểu đề bài: DemSoTrenBienMang2C
        Cho ma trận A chứa các số thực có n dòng và m cột (1 <= n, m <= 100).
        Hãy đếm các số dương, âm và không trên biên ma trận A.

        Ý tưởng:
        Phần tử A[i,j] nằm trên biên khi:
        i == 0 hoặc i == n - 1 hoặc j == 0 hoặc j == m - 1.

        Mã giả:
        duong = am = khong = 0
        với mỗi A[i,j]:
            nếu A[i,j] nằm trên biên:
                nếu > 0: duong++
                nếu < 0: am++
                ngược lại: khong++
        */

        public static void DemSoTrenBienMang2C()
        {
            int n = NhapKichThuoc("Nhap so dong n: ");
            int m = NhapKichThuoc("Nhap so cot m: ");
            double[,] a = NhapMaTranThuc(n, m);

            Console.WriteLine("// Nhap ma tran A");
            InMaTran(a);

            int duong = 0, am = 0, khong = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        if (a[i, j] > 0)
                            duong++;
                        else if (a[i, j] < 0)
                            am++;
                        else
                            khong++;
                    }
                }
            }

            Console.WriteLine("Tren duong bien co {0} so duong, {1} so am va {2} so khong.",
                              duong, am, khong);
        }

        /*
        Phát biểu đề bài: MaTranToanLe
        Cho ma trận A chứa các số nguyên có n dòng và m cột (1 <= n, m <= 100).
        Hãy kiểm tra xem ma trận có toàn lẻ không?

        Ý tưởng:
        - Giả sử ma trận toàn lẻ.
        - Nếu gặp một phần tử chẵn thì kết luận không toàn lẻ.

        Mã giả:
        toanLe = true
        duyệt A:
            nếu A[i,j] % 2 == 0:
                toanLe = false
                dừng
        */

        public static void MaTranToanLe()
        {
            int n = NhapKichThuoc("Nhap so dong n: ");
            int m = NhapKichThuoc("Nhap so cot m: ");
            int[,] a = NhapMaTranNguyen(n, m);

            Console.WriteLine("// Nhap A");
            InMaTran(a);

            bool toanLe = true;

            for (int i = 0; i < n && toanLe; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        toanLe = false;
                        break;
                    }
                }
            }

            if (toanLe)
                Console.WriteLine("Mang A toan le!");
            else
                Console.WriteLine("Mang A khong toan le!");
        }

        /*
        Phát biểu đề bài: DongTangDan
        Cho ma trận A chứa các số nguyên có n dòng và m cột (1 <= n, m <= 100).
        Hãy liệt kê các dòng mà các giá trị tạo thành dãy tăng.

        Ý tưởng:
        - Xét từng dòng.
        - Nếu mọi phần tử phía sau đều lớn hơn phần tử ngay trước thì dòng tăng.
        - Theo ví dụ đề bài, chỉ số dòng bắt đầu từ 0.

        Mã giả:
        với mỗi dòng i:
            tang = true
            với j từ 1 đến m - 1:
                nếu A[i,j] <= A[i,j-1]:
                    tang = false
                    dừng
            nếu tang:
                lưu i
        */

        public static void DongTangDan()
        {
            int n = NhapKichThuoc("Nhap so dong n: ");
            int m = NhapKichThuoc("Nhap so cot m: ");
            int[,] a = NhapMaTranNguyen(n, m);

            Console.WriteLine("// Nhap A");
            InMaTran(a);

            List<int> cacDong = new List<int>();

            for (int i = 0; i < n; i++)
            {
                bool tang = true;

                for (int j = 1; j < m; j++)
                {
                    if (a[i, j] <= a[i, j - 1])
                    {
                        tang = false;
                        break;
                    }
                }

                if (tang)
                    cacDong.Add(i);
            }

            Console.WriteLine("Cac dong tao thanh day tang: {0}",
                              string.Join(" ", cacDong));
        }

        /*
        Phát biểu đề bài: CotTongLonNhat
        Cho ma trận A chứa các số thực có n dòng và m cột (1 <= n, m <= 100).
        Hãy liệt kê các cột có tổng các giá trị lớn nhất.

        Ý tưởng:
        - Tính tổng từng cột.
        - Tìm tổng lớn nhất.
        - Liệt kê tất cả cột có tổng bằng giá trị lớn nhất.
        - Theo ví dụ đề bài, chỉ số cột bắt đầu từ 0.

        Mã giả:
        tính tongCot[j]
        max = tongCot[0]
        tìm max
        với mỗi j:
            nếu tongCot[j] == max:
                lưu j
        */

        public static void CotTongLonNhat()
        {
            int n = NhapKichThuoc("Nhap so dong n: ");
            int m = NhapKichThuoc("Nhap so cot m: ");
            double[,] a = NhapMaTranThuc(n, m);

            Console.WriteLine("// Nhap A");
            InMaTran(a);

            double[] tongCot = new double[m];

            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                    tongCot[j] += a[i, j];

            double max = tongCot[0];

            for (int j = 1; j < m; j++)
                if (tongCot[j] > max)
                    max = tongCot[j];

            List<int> cacCot = new List<int>();

            for (int j = 0; j < m; j++)
                if (Math.Abs(tongCot[j] - max) < 1e-9)
                    cacCot.Add(j);

            Console.WriteLine("Cac cot co tong lon nhat: {0}",
                              string.Join(" ", cacCot));
        }

        // Hàm dùng chung để nhập số dòng hoặc số cột.
        // Theo đề bài: 1 <= n, m <= 100.
        public static int NhapKichThuoc(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();

                if (input == null)
                    throw new InvalidOperationException("Khong con du lieu dau vao.");

                if (int.TryParse(input, out int value) && value >= 1 && value <= 100)
                    return value;

                Console.WriteLine("Kich thuoc khong hop le!");
            }
        }

        // Hàm dùng chung để nhập ma trận số nguyên.
        // Có thể nhập nhiều phần tử trên cùng một dòng.
        public static int[,] NhapMaTranNguyen(int n, int m)
        {
            int[,] a = new int[n, m];
            int dem = 0;

            while (dem < n * m)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    throw new InvalidOperationException("Khong con du lieu dau vao.");

                string[] parts = input.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string part in parts)
                {
                    if (dem >= n * m)
                        break;

                    if (int.TryParse(part, out int value))
                    {
                        int i = dem / m;
                        int j = dem % m;
                        a[i, j] = value;
                        dem++;
                    }
                    else
                    {
                        Console.WriteLine("Phan tu khong hop le!");
                    }
                }
            }

            return a;
        }

        // Hàm dùng chung để nhập ma trận số thực.
        // InvariantCulture giúp nhập số thập phân bằng dấu chấm như 1.5, -3.2.
        public static double[,] NhapMaTranThuc(int n, int m)
        {
            double[,] a = new double[n, m];
            int dem = 0;

            while (dem < n * m)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    throw new InvalidOperationException("Khong con du lieu dau vao.");

                string[] parts = input.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string part in parts)
                {
                    if (dem >= n * m)
                        break;

                    if (double.TryParse(part, NumberStyles.Float,
                                        CultureInfo.InvariantCulture, out double value))
                    {
                        int i = dem / m;
                        int j = dem % m;
                        a[i, j] = value;
                        dem++;
                    }
                    else
                    {
                        Console.WriteLine("Phan tu khong hop le!");
                    }
                }
            }

            return a;
        }

        public static void InMaTran(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            Console.WriteLine("Mang co {0} dong x {1} cot:", n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ", a[i, j]);

                Console.WriteLine();
            }
        }

        public static void InMaTran(double[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            Console.WriteLine("Mang co {0} dong x {1} cot:", n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ",
                        a[i, j].ToString("0.########", CultureInfo.InvariantCulture));

                Console.WriteLine();
            }
        }
    }
}
