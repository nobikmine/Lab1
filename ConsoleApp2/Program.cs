using System;

namespace ConsoleApp2
{
    public class Logic
    {
        public static (List<int> row, int FirstNum) FindFirstNum(int n)
        {
            List<int> nums = new List<int>();
            int i = 1;
            int current = 1;

            while (current <= n)
            {
                nums.Add(current);
                i++;
                current = i * i;
            }

            nums.Add(current);
            return (nums, current);

        }
    }
    public static class InputHelper
    {
        public static bool TryParseInput(string input, out int n)
        {
            return int.TryParse(input, out n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите число n: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Пожалуйста, введите корректное число.");
                }
            }

            var result = Logic.FindFirstNum(n);

            Console.WriteLine("Сформированный ряд чисел:");
            Console.WriteLine(string.Join(", ", result.row));
            Console.WriteLine($"Первое число, большее {n}: {result.FirstNum}");
        }
    }
}