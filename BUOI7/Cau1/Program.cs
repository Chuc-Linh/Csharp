
﻿using System;

namespace BUOI7
{
    class InBaHinhTamGiac
    {
        public static void Main(string[] args)
        {
            int h;
            Console.Write("Moi ban nhap chieu cao h: ");
            while (!int.TryParse(Console.ReadLine(), out h) || h < 1)
            {
                Console.Write("Nhap sai! Vui long nhap so nguyen duong: ");
            }

            Console.WriteLine($"h = {h}");
            InTamGiacCanRong(h);
            Console.ReadLine();
        }

        static void InTamGiacCanRong(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                // Khoảng trắng đầu dòng
                int soKhoangDau = h - i;
                for (int j = 1; j <= soKhoangDau; j++)
                {
                    Console.Write("  ");
                }

                if (i == 1)
                {
                    // Dòng đầu: 1 dấu *
                    Console.Write("*");
                }
                else if (i == h)
                {
                    // Dòng cuối: 2h-1 dấu *, cách nhau bởi khoảng trắng
                    int soDauSao = 2 * h - 1;
                    for (int j = 1; j <= soDauSao; j++)
                    {
                        Console.Write("*");
                        if (j < soDauSao)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    // Dòng giữa: 2 dấu * ở 2 bên
                    Console.Write("*");
                    int soKhoangGiua = 2 * i - 3;
                    for (int j = 1; j <= soKhoangGiua; j++)
                    {
                        Console.Write("  ");t
                    }
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
// ============================================================
//              In 3 hinh tam giac
// ============================================================
//
// ------------------------------------------------------------
// TEST 1: Chieu cao 3
// ------------------------------------------------------------
// Input:
//   3
//
// Output mong doi:
//   Moi ban nhap chieu cao h: h = 3
//       *
//     *   *
//   * * * * *
//
// ------------------------------------------------------------
// TEST 2: Chieu cao 5
// ------------------------------------------------------------
// Input:
//   5
//
// Output mong doi:
//   Moi ban nhap chieu cao h: h = 5
//           *
//         *   *
//       *       *
//     *           *
//   * * * * * * * * *
//
// ------------------------------------------------------------
// TEST 3: Chieu cao 7
// ------------------------------------------------------------
// Input:
//   7
//
// Output mong doi:
//   Moi ban nhap chieu cao h: h = 7
//               *
//             *   *
//           *       *
//         *           *
//       *               *
//     *                   *
//   * * * * * * * * * * * * *
//
// ------------------------------------------------------------
// TEST 4: Chieu cao 1 (truong hop dac biet)
// ------------------------------------------------------------
// Input:
//   1
//
// Output mong doi:
//   Moi ban nhap chieu cao h: h = 1
//   *
//
// ------------------------------------------------------------
// TEST 5: Chieu cao 2
// ------------------------------------------------------------
// Input:
//   2
//
// Output mong doi:
//   Moi ban nhap chieu cao h: h = 2
//     *
//   * * *
//
// ------------------------------------------------------------
// TEST 6: Nhap sai (so 0)
// ------------------------------------------------------------
// Input:
//   0
//   3
//
// Output mong doi:
//   Moi ban nhap chieu cao h: Nhap sai! Vui long nhap so nguyen duong: 
//   h = 3
//       *
//     *   *
//   * * * * *
//
// ============================================================
