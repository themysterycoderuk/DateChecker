using System;

namespace DateChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void showDates()
        {
            var dt1 = new DateTime(2020, 12, 5);
            var dt2 = new DateTime(2020, 4, 5);

            Console.WriteLine($"5/12/2020 = {dt1.ToString()} (default), {dt1.ToString("dd/MM/yyyy")} (dd/MM/yyyy)");
            Console.WriteLine($"5/12/2020 = {dt2.ToString()} (default), {dt2.ToString("dd/MM/yyyy")} (dd/MM/yyyy)");
        }
    }
}
