using System;

namespace ConsoleApp2
{
    public class Logic
    {
        public static void PrintSquares(int n)
        {
            int i = 1;
            int current = 1;

            while (current <= n)
            {
                Console.Write(current + ", ");
                i++;
                current = i * i;
            }
            Console.Write(current);
            Console.WriteLine();
        }

        public static int FindFirstNum(int n)
        {
            int i = 1;

            while (i * i <= n)
            {
                i++;
            }

            return i * i;
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

                if (InputHelper.TryParseInput(input, out n))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Пожалуйста, введите корректное число.");
                }
            }

            Console.WriteLine("Сформированный ряд чисел:");
            Logic.PrintSquares(n);

            int result = Logic.FindFirstNum(n);
            Console.WriteLine($"Первое число, большее {n}: {result}");
        }
    }
}