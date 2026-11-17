using System;
using System.Collections.Generic;
using System.Text;

namespace LeapYear
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть рік: ");

            string input = Console.ReadLine();

            int year = Convert.ToInt32(input);

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} рік є високосним");
            }
            else
            {
                Console.WriteLine($"{year} рік не є високосним");
            }
        }
    }
}
