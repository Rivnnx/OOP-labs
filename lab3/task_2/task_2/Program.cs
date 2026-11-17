namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Речення:");
            string input = Console.ReadLine();

            Console.WriteLine("Кіслькість перших слів для видалення:");
            string inputX = Console.ReadLine();
            int x = int.Parse(inputX);


            // розділення на слова
            string[] words = input.Split(
                new char[] { ' '},
                StringSplitOptions.RemoveEmptyEntries
            );

            if (x < 0)
            {
                Console.WriteLine("X не може бути від'ємним");

                Console.WriteLine(string.Join(" ", words));
                return;
            }

            if (x >= words.Length)
            {
                Console.WriteLine("Порожньо");
                return;
            }

            string result = string.Join(" ", words, x, words.Length - x);

            Console.WriteLine($"Result: {result}");

        }
    }
}
