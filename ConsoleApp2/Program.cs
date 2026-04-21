using System;

namespace ConsoleApp2
{
    public static class Logic
    {
        public static int[] GetSquaresUpTo(int n)
        {
            List<int> result = new List<int>();
            int i = 1;
            int current = 1;

            while (current <= n)
            {
                result.Add(current);
                i++;
                current = i * i;
            }
            return result.ToArray();
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



    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите целое число n: ");
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
            Console.WriteLine("Сформированный ряд чисел:");

            var squares = Logic.GetSquaresUpTo(n);
            Console.WriteLine(string.Join(", ", squares));

            int result = Logic.FindFirstNum(n);
            Console.WriteLine($"Первое число, большее {n}: {result}");
        }
    }
}