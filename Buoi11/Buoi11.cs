using System;
using System.Collections.Generic;
using System.Linq;
/*
Chương trình: BÀI TẬP BUỔI 11
Nội dung: 4 bài tập cơ bản 
Tác giả: Lâm Duy Chúc Linh
Ngày viết: 13/09/2026
*/
// B. Bài tập cơ bản


namespace NNLTBuoi11
{
    public class Buoi11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bai 1. Sap chan le");
            SapChanLe();

            Console.WriteLine("Bai 2. Xoa phan tu chan");
            XoaChan();

            Console.WriteLine("Bai 3. Them chan le");
            ThemChanLe();

            Console.WriteLine("Bai 4. Dao Day");
            DaoDay();

            Console.WriteLine("Bai 5. Tron Day");
            TronDay();
        }

        /*
        Phát biểu đề bài: SapChanLe
        Cho số nguyên n (n <= 500) và dãy số nguyên a0, a1, ..., an-1.
        Hãy sắp xếp các số chẵn ở phía trước tăng dần,
        các số lẻ ở phía sau giảm dần.

        Ý tưởng:
        - Nhập n và n phần tử của mảng.
        - Tách các số chẵn và số lẻ.
        - Sắp xếp số chẵn tăng dần.
        - Sắp xếp số lẻ giảm dần.
        - Ghép hai phần lại và in kết quả.

        Mã giả:
        Nhập n
        Nhập mảng a
        chan = các phần tử chẵn
        le = các phần tử lẻ
        sắp xếp chan tăng dần
        sắp xếp le giảm dần
        kết quả = chan + le
        */
        public static void SapChanLe()
        {
            int n = NhapSoLuong();
            int[] a = NhapMang(n);

            Console.WriteLine("* Mang truoc khi sap xep:");
            InMang(a);

            int[] chan = a.Where(x => x % 2 == 0)
                          .OrderBy(x => x)
                          .ToArray();

            int[] le = a.Where(x => x % 2 != 0)
                        .OrderByDescending(x => x)
                        .ToArray();

            int[] ketqua = chan.Concat(le).ToArray();

            Console.WriteLine("* Mang sau khi sap xep:");
            InMang(ketqua);
        }

        /*
        Phát biểu đề bài: XoaChan
        Cho số nguyên n (n <= 500), dãy n số nguyên a0, a1, ..., an-1.
        Hãy xóa các phần tử có giá trị chẵn.

        Ý tưởng:
        - Nhập n và n phần tử.
        - Duyệt mảng.
        - Chỉ giữ lại các phần tử lẻ.
        - In mảng sau khi xóa.

        Mã giả:
        Nhập n
        Nhập mảng a
        kết quả = mảng rỗng
        với mỗi phần tử x trong a:
            nếu x lẻ:
                thêm x vào kết quả
        */
        public static void XoaChan()
        {
            int n = NhapSoLuong();
            int[] a = NhapMang(n);

            Console.WriteLine("* Mang truoc xoa:");
            InMang(a);

            int[] ketqua = a.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine("* Mang sau khi xoa:");
            InMang(ketqua);
        }

        /*
        Phát biểu đề bài: ThemChanLe
        Cho số nguyên n (n <= 500), dãy n số nguyên a0, a1, ..., an-1.
        Hãy thêm vào vị trí có 2 phần tử liên tiếp là chẵn
        1 giá trị lẻ để tạo thành mảng chẵn, lẻ.

        Ý tưởng:
        - Nhập n và n phần tử.
        - Duyệt từ trái sang phải.
        - Sau mỗi phần tử chẵn, nếu phần tử kế tiếp cũng chẵn
          thì chèn một số lẻ.
        - Theo đúng ví dụ đề bài, số lẻ được chèn là a[i] + 1.

        Mã giả:
        Nhập n
        Nhập mảng a
        tạo danh sách kết quả
        với i từ 0 đến n - 1:
            thêm a[i] vào kết quả
            nếu i < n - 1 và a[i] chẵn và a[i+1] chẵn:
                thêm a[i] + 1 vào kết quả
        */
        public static void ThemChanLe()
        {
            int n = NhapSoLuong();
            int[] a = NhapMang(n);

            Console.WriteLine("* Mang truoc them:");
            InMang(a);

            List<int> ketqua = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                ketqua.Add(a[i]);

                if (i < a.Length - 1 &&
                    a[i] % 2 == 0 &&
                    a[i + 1] % 2 == 0)
                {
                    ketqua.Add(a[i] + 1);
                }
            }

            Console.WriteLine("* Mang sau khi them:");
            InMang(ketqua);
        }

        /*
        Phát biểu đề bài: DaoDay
        Cho số nguyên n (n <= 500), dãy n số nguyên a0, a1, a2, ..., an-1.
        Hãy đảo ngược dãy số này.

        Ý tưởng:
        - Nhập n và n phần tử của mảng.
        - Dùng 2 chỉ số: left ở đầu mảng, right ở cuối mảng.
        - Đổi chỗ a[left] và a[right].
        - Tăng left, giảm right cho đến khi left >= right.

        Mã giả:
        Nhập n
        Nhập mảng a
        left = 0
        right = n - 1
        while left < right:
            đổi chỗ a[left] và a[right]
            left++
            right--
        */

        public static void DaoDay()
        {
            int n = NhapSoLuong();
            int[] a = NhapMang(n);

            Console.WriteLine("* Mang truoc dao:");
            InMang(a);

            int left = 0;
            int right = a.Length - 1;

            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine("* Mang sau khi dao:");
            InMang(a);
        }

        /*
        Phát biểu đề bài: TronDay
        Cho số nguyên n, m (n, m <= 500), dãy A có n số nguyên tăng dần
        và dãy B có m số nguyên tăng dần.
        Hãy trộn 2 dãy trên thành dãy C tăng dần,
        không dùng thuật toán sắp xếp.

        Ý tưởng:
        - Dùng 2 chỉ số i và j lần lượt duyệt A và B.
        - So sánh A[i] và B[j].
        - Phần tử nhỏ hơn được đưa vào C trước.
        - Khi một dãy đã hết, đưa toàn bộ phần còn lại của dãy kia vào C.

        Mã giả:
        Nhập n
        Nhập mảng A
        Nhập m
        Nhập mảng B

        i = 0, j = 0
        while i < n và j < m:
            nếu A[i] <= B[j]:
                thêm A[i] vào C
                i++
            ngược lại:
                thêm B[j] vào C
                j++

        thêm các phần tử còn lại của A vào C
        thêm các phần tử còn lại của B vào C
        */

        public static void TronDay()
        {
            Console.WriteLine("* Day A:");
            int n = NhapSoLuong();
            int[] a = NhapMang(n);

            Console.WriteLine("* Day B:");
            int m = NhapSoLuong();
            int[] b = NhapMang(m);

            Console.WriteLine("* Day A:");
            InMang(a);

            Console.WriteLine("* Day B:");
            InMang(b);

            int[] c = new int[n + m];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < n && j < m)
            {
                if (a[i] <= b[j])
                {
                    c[k] = a[i];
                    i++;
                }
                else
                {
                    c[k] = b[j];
                    j++;
                }

                k++;
            }

            while (i < n)
            {
                c[k] = a[i];
                i++;
                k++;
            }

            while (j < m)
            {
                c[k] = b[j];
                j++;
                k++;
            }

            Console.WriteLine("* Day C sau khi tron:");
            InMang(c);
        }
        // Hàm dùng chung để nhập số lượng phần tử.
        public static int NhapSoLuong()
        {
            int n;
            Console.WriteLine("Nhap so luong phan tu n");
            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null)
                    throw new InvalidOperationException("Khong con du lieu dau vao.");

                if (int.TryParse(input, out n) && n > 0 && n <= 500)
                    return n;

                Console.WriteLine("So luong phan tu khong hop le!");
                Console.WriteLine("Hay nhap lai n:");
            }
        }

        // Hàm dùng chung để nhập đủ n số nguyên.
        public static int[] NhapMang(int n)
        {
            int[] a = new int[n];
            int i = 0;
            Console.WriteLine("Nhap cac phan tu mang");
            while (i < n)
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
                    if (i >= n)
                        break;

                    if (int.TryParse(part, out int value))
                    {
                        a[i] = value;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Phan tu khong hop le!");
                        Console.WriteLine("Hay nhap lai phan tu:");
                    }
                }
            }

            return a;
        }

        // Hàm in mảng theo đúng kiểu "Day so co ... phan tu:"
        public static void InMang(IEnumerable<int> a)
        {
            int[] arr = a.ToArray();
            Console.WriteLine("Day so co {0} phan tu: {1}", arr.Length, string.Join(" ", arr));
        }
    }
}
