using System;

namespace Buoi02
{
     class Baitap1
    {

        public static void Mainbt1()
        {
            Console.Write("Moi ban nhap so a, b: ");
            string input = Console.ReadLine()!;
            string[] parts = input.Split(' ');

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);

            int sumB = b * (b+1) / 2;
            int sumA = (a-1) * a / 2;
            int result = sumB - sumA;
            Console.WriteLine($"Tong cua cac so trong doan[{a}, {b}] la {result}.");
        }
    }
}