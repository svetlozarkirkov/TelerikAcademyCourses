namespace _07_SortThreeNumbers
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (Math.Max(a, b) == a && Math.Max(a, c) == a)
            {
                Console.Write("{0} ", a);

                if (Math.Max(b, c) == b)
                {
                    Console.Write("{0} {1}", b, c);
                }
                else if (Math.Max(b, c) == c)
                {
                    Console.Write("{0} {1}", c, b);
                }
            }
            else if (Math.Max(b, a) == b && Math.Max(b, c) == b)
            {
                Console.Write("{0} ", b);

                if (Math.Max(a, c) == a)
                {
                    Console.Write("{0} {1}", a, c);
                }
                else if (Math.Max(a, c) == c)
                {
                    Console.Write("{0} {1}", c, a);
                }
            }
            else if (Math.Max(c, a) == c && Math.Max(c, b) == c)
            {
                Console.Write("{0} ", c);

                if (Math.Max(a, b) == a)
                {
                    Console.Write("{0} {1}", a, b);
                }
                else if (Math.Max(a, b) == b)
                {
                    Console.Write("{0} {1}", b, a);
                }
            }

            Console.WriteLine();
        }
    }
}