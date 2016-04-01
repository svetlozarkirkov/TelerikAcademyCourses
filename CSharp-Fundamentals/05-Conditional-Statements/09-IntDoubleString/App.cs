namespace _09_IntDoubleString
{
    using System;

    internal class App
    {
        private static void Main()
        {
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "integer":
                    var integerNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(integerNumber + 1);
                    break;
                case "real":
                    var realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", realNumber + 1);
                    break;
                case "text":
                    var stringValue = Console.ReadLine();
                    Console.WriteLine("{0}*", stringValue);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}