namespace _15_Age
{
    using System;
    using System.Globalization;

    internal class App
    {
        private static void Main()
        {
            var input = Console.ReadLine();
            var inputDate = DateTime.ParseExact(
                input,
                "MM.dd.yyyy",
                CultureInfo.InvariantCulture);
            var age = GetAge(inputDate, DateTime.Now);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }

        private static int GetAge(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}