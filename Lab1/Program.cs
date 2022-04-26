using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());

            while (c == 0)
            {
                Console.Write("Деление на ноль, введите c:");
                c = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 0;
            if (x + c < 0 || a != 0)
            {
                y = -a * Math.Pow(x, 3) - b;
            }
            else if (x + c > 0 && a == 0)
            {
                if (x - c == 0)
                    Console.WriteLine("Деление на ноль");
                else
                    y = (x - a) / (x - c);
            }
            else
            {
                y = (x / c) + (c / x);
            }

            Console.WriteLine(y);
        }
    }
}
