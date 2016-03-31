namespace _02_CompanyInfo
{
    using System;

    internal class App
    {
        private static void Main()
        {
            // input
            var companyName = Console.ReadLine();
            var companyAddress = Console.ReadLine();
            var companyPhoneNumber = Console.ReadLine();
            var companyFaxNumber = Console.ReadLine();
            if (string.IsNullOrEmpty(companyFaxNumber))
            {
                companyFaxNumber = "(no fax)";
            }
            var companyWebsite = Console.ReadLine();
            var managerFirstName = Console.ReadLine();
            var managerLastName = Console.ReadLine();
            var managerAge = int.Parse(Console.ReadLine());
            var managerPhoneNumber = Console.ReadLine();

            // output
            Console.WriteLine(
                "{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\n" +
                "Manager: {5}{6} (age:{7}, tel. {8}",
                companyName,
                companyAddress,
                companyPhoneNumber,
                companyFaxNumber,
                companyWebsite,
                managerFirstName,
                managerLastName,
                managerAge,
                managerPhoneNumber);
        }
    }
}