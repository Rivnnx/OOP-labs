using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGame
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            int score = 0;
            // question 1 
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Питання 1: Які кольори у прапора України?");
            Console.WriteLine("1. жовтий і блакитний");
            Console.WriteLine("2. червоний і зелений");
            Console.WriteLine("3. чорний і жовтий");
            Console.WriteLine("4. зелений і фіолетовий");
            Console.Write("Ваша відповідь: ");

            string answer1 = Console.ReadLine();

            if (answer1 == "1")
            {
                Console.WriteLine("Correct answer!");
                Console.WriteLine();
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer. Гра завершена.");
                return;
            }

            // question 2 
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Питання 2: В якому місті знаходиться ДТЕУ?");
            Console.WriteLine("1. Вінниця");
            Console.WriteLine("2. Київ");
            Console.WriteLine("3. Львів");
            Console.WriteLine("4. Одеса");
            Console.Write("Ваша відповідь: ");

            string answer2 = Console.ReadLine();

            if (answer2 == "2")
            {
                Console.WriteLine("Correct answer!\n");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer. Гра завершена.");
                return;
            }

            // question 3
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Питання 3: Скільки біт в одному байті?");
            Console.WriteLine("1. 4");
            Console.WriteLine("2. 16");
            Console.WriteLine("3. 8");
            Console.WriteLine("4. 32");
            Console.Write("Ваша відповідь: ");

            string answer3 = Console.ReadLine();

            if (answer3 == "3")
            {
                Console.WriteLine("Correct answer!\n");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer. Гра завершена.");
                return;
            }

            // question 4
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Питання 4: Яка планета Сонячної системи найбільша?");
            Console.WriteLine("1. Земля");
            Console.WriteLine("2. Марс");
            Console.WriteLine("3. Сатурн");
            Console.WriteLine("4. Юпітер");
            Console.Write("Ваша відповідь: ");

            string answer4 = Console.ReadLine();

            if (answer4 == "4")
            {
                Console.WriteLine("Correct answer!\n");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer. Гра завершена.");
                return;
            }

            // question 5
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine("Питання 5: Хто написав збірку «Кобзар»?");
            Console.WriteLine("1. Іван Франко");
            Console.WriteLine("2. Тарас Шевченко");
            Console.WriteLine("3. Леся Українка");
            Console.WriteLine("4. Ліна Костенко");
            Console.Write("Ваша відповідь: ");

            string answer5 = Console.ReadLine();

            if (answer5 == "2")
            {
                Console.WriteLine("Correct answer!\n");
                score += 100;
            }
            else
            {
                Console.WriteLine("Wrong Answer. Гра завершена.");
                return;
            }

            // finall 
            Console.WriteLine($"Вітаємо! Ви пройшли всю гру. Ваш фінальний рахунок: {score}");
        }
    }
}
