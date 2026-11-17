using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Фігури для прорахування площі:");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Прямокутник");
            Console.WriteLine("3. Трикутник");
            Console.WriteLine("4. Коло");
            Console.Write("Виберіть фігуру (1-4): ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                // Квадрат
                Console.Write("Введіть сторону квадрата: ");
                string sideText = Console.ReadLine();
                float side = float.Parse(sideText);

                float area = side * side;
                Console.WriteLine($"Площа квадрата = {area}");
            }
            else if (option == "2")
            {
                // Прямокутник
                Console.Write("Введіть першу сторону: ");
                string aText = Console.ReadLine();
                float a = float.Parse(aText);

                Console.Write("Введіть другу сторону: ");
                string bText = Console.ReadLine();
                float b = float.Parse(bText);

                float area = a * b;
                Console.WriteLine($"Площа прямокутника = {area}");
            }
            else if (option == "3")
            {
                // Трикутник
                Console.Write("Введіть основу трикутника: ");
                string baseText = Console.ReadLine();
                float tBase = float.Parse(baseText);

                Console.Write("Введіть висоту трикутника: ");
                string heightText = Console.ReadLine();
                float height = float.Parse(heightText);

                float area = tBase * height / 2;
                Console.WriteLine($"Площа трикутника = {area}");
            }
            else if (option == "4")
            {
                // Коло
                Console.Write("Введіть радіус кола: ");
                string radText = Console.ReadLine();
                float rad = float.Parse(radText);

                float area = (float)(Math.PI * rad * rad);
                Console.WriteLine($"Площа кола = {area}");
            }
            else
            {
                Console.WriteLine("Потрібно обрати варіант від 1 до 4");
            }
        }
    }
}