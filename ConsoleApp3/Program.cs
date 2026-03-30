using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic reverser = new Logic();
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
                string result = reverser.ReverseWords(input);

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
    public class Logic
    {
        public string ReverseWords(string sentence)
        {
            if (sentence == null || sentence == "")
            {
                return "";
            }

            sentence = sentence.Trim();
            string[] words = sentence.Split(' ');
            string[] reversedWords = new string[words.Length];
            int j = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "")
                {
                    reversedWords[j] = words[i];
                    j++;
                }
            }
            string result = "";
            for (int i = 0; i < j; i++)
            {
                result = result + reversedWords[i];
                if (i < j - 1)
                {
                    result = result + " ";
                }
            }

            return result;
        }
        public bool HasWords(string sentence)
        {
            if (sentence == null || sentence == "")
            {
                return false;
            }

            string trimmedSentence = sentence.Trim();
            return trimmedSentence != "";
        }
    }
}