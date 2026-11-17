using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Calculator
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть вираз:");
            string expression = Console.ReadLine();

            DataTable table = new DataTable();

            var result = table.Compute(expression, "");

            Console.WriteLine($"Відповідь програми: {result}");
        }

    }
}
