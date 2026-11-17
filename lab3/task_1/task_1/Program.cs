using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть ціле число:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int reversed = 0;
            int x = number;

            while (x != 0)
            {
                int y = x % 10;
                reversed = reversed * 10 + y;
                x /= 10;
            }
            Console.WriteLine($"result: {reversed}");

        }
    }
}
