namespace _13_ComparingFloats
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var firstDouble = double.Parse(Console.ReadLine());
            var secondDouble = double.Parse(Console.ReadLine());
            const double eps = 0.000001;

            var areEqual =
                Math.Abs(Math.Abs(firstDouble) - Math.Abs(secondDouble)) <= eps;

            Console.WriteLine(areEqual.ToString().ToLowerInvariant());
        }
    }
}