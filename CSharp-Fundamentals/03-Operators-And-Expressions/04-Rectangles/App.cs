namespace _04_Rectangles
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var perimeter = width*2 + height*2;
            var area = width*height;
            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}