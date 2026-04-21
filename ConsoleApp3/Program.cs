using System;

namespace ConsoleApp3
{

    public static class Logic
    {
        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return "";

            var words = sentence
                .Trim()
                .Split(new char[]{ ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Программа для разворота слов в предложении ===");
            Console.WriteLine();
            while (true)
            {
                Console.Write("Введите предложение (или 'выход' для завершения): ");
                string input = Console.ReadLine();
                if (input == "выход")
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                if (input == null || input == "")
                {
                    Console.WriteLine("Ошибка: Вы ничего не ввели!");
                    Console.WriteLine();
                    continue;
                }
                string result = Logic.ReverseWords(input);

                if (result == "")
                {
                    Console.WriteLine("Ошибка: В предложении нет слов!");
                }
                else
                {
                    Console.WriteLine("Результат: " + result);
                }
                Console.WriteLine();
            }
        }
    }
}