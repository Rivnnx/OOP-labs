using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Висота трикутника: ");
            string input = Console.ReadLine();

            int height = Convert.ToInt32(input);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
