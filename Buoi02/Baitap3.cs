using System;

namespace Buoi02
{
    class Baitap3
    {
        public static void Mainbt3()
        {
            Console.Write("Moi ban nhap so thuc x: ");
            double x = double.Parse(Console.ReadLine()!);
            // f(x) = 1 + 2x + 3x^2 - 4x^3
            // Horner: f(x) = 1 + x*(2 + x*(3 + x*(-4)))
            double result = 1 + x * (2 + x * (3 + x * (-4)));

            Console.WriteLine($"f({x}) = {result:0.00}");

        }
    }
}