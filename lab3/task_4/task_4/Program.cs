using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                int position = i + 1;

                if (position % 15 == 0)
                {
                    characters[i] = '?';
                }
                else if (position % 5 == 0)
                {
                    characters[i] = '9';
                }
                else if (position % 3 == 0)
                {
                    characters[i] = 'X';
                }
            }

            string result = new string(characters);
            Console.WriteLine($"Результат: {result}");
        }

    }
}
