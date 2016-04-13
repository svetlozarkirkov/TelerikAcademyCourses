namespace _03_CheckForAPlayCard
{
    using System;
    using System.Linq;

    internal class App
    {
        private static void Main()
        {
            string[] validCards =
                { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            var input = Console.ReadLine();

            Console.WriteLine(
                validCards.Contains(input.ToUpperInvariant())
                ? "yes {0}"
                : "no {0}", input);
        }
    }
}