using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Введите a");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите b");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите c");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Decision dec = new Decision(a, b, c);
                    dec.Recolve();
                }

                catch
                {
                    Console.WriteLine("Not correct input data");
                }            
            }
        }
    }

    class Decision
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;

        public Decision(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Recolve()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1={0} x2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }
        }
    }
}
