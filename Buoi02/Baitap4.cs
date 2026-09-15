using System;

namespace Buoi02
{
    class Baitap4
    {
        public static void Mainbt4()
        {
            Console.Write("Moi ban nhap thang: ");
            int thang = int.Parse(Console.ReadLine()!);
            int quy = (thang - 1) / 3 + 1;
            Console.WriteLine($"Thang {thang} thuoc quy {quy}.");
        }
    }
}