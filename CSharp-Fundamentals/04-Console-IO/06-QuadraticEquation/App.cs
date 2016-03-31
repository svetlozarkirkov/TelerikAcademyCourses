namespace _06_QuadraticEquation
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            SolveQuadratic(a,b,c);
        }

        public static void SolveQuadratic(double a, double b, double c)
        {
            var sqrtpart = b * b - 4 * a * c;
            double x, x1, x2;
            if (sqrtpart > 0)
            {
                x1 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                if (x1 < x2)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}",x1,x2);
                }
                else
                {
                    Console.WriteLine("{0:F2}\n{1:F2}",x2,x1);
                }
            }
            else if (sqrtpart < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("{0:F2}", x);
            }
        }
    }
}