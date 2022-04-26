using System;
using System.Collections.Generic;

namespace Lab2_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите b");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите c");
                double c = Convert.ToDouble(Console.ReadLine());

                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                if (IsCorrect(a, b, c))
                {
                    IsSides(a, b, c);
                    IsArea(a, b, c);
                    Console.WriteLine($"Площадь: {s}");
                }
                else
                {
                    Console.WriteLine("No correct values");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public static bool IsCorrect(double a,double b, double c)
        {
            if ((a <= 0 || b <= 0 || c <= 0) || (a + b <= c || a + c <= b || b + c <= a))
                return false;
            else
                return true;
        }

        public static void IsSides(double a, double b, double c)
        {
            if ((a == b) && (a != c) || (a == c) && (a != b) || (b == c) && (b != a))
            {
                Console.WriteLine("Это равобедренный треугольник");
            }
            else if (a == b && b == c && a == c)
            {
                Console.WriteLine("Это равносторонний треугольник");
            }
            else
            {
                Console.WriteLine("Это разносторонний треугольник");
            }
        }

        public static void IsArea(double a, double b, double c)
        {
            List<double> sides = new List<double>() { a, b, c };
            sides.Sort();
            double cos = (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) / (2 * sides[0] * sides[1]);

            if (cos < 0)
            {
                Console.WriteLine("Это тупоугольный треугольник");
            }
            else if (cos > 0)
            {
                Console.WriteLine("Это остроугольный треугольник");
            }
            else
            {
                Console.WriteLine("Это прямоугольный треугольник");
            }
        }
    }
}
