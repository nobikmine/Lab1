using System;

namespace ConsoleApp1
{
    public static class Logic
    {
        public static string CountTime(int a, int b, int c, int d, int n, int m)
        {
            if (a < 0 || a > 23 || c < 0 || c > 23 || n < 0 || n > 23 ||
                b < 0 || b > 59 || d < 0 || d > 59 || m < 0 || m > 59)
            {
                return "Ошибка: некорректное время";
            }

            int minutesIn = a * 60 + b;
            int minutesOut = c * 60 + d;
            int minutesHere = n * 60 + m;

            bool isTrainAtStation;

            if (minutesIn == minutesOut)
            {
                isTrainAtStation = false;
            }
            else if (minutesIn < minutesOut)
            {
                isTrainAtStation = minutesHere >= minutesIn && minutesHere <= minutesOut;
            }
            else
            {
                isTrainAtStation = minutesHere >= minutesIn || minutesHere <= minutesOut;
            }

            return isTrainAtStation ? "Поезд стоит на платформе" : "Поезда нет на платформе";
        }
    }

    class Program
    {
        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: ввод не может быть пустым");
                    continue;
                }

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите число");
            }
        }

        static void Main(string[] args)
        {
            int a = ReadInt("Введите часы прибытия: ");
            int b = ReadInt("Введите минуты прибытия: ");
            int c = ReadInt("Введите часы отправления: ");
            int d = ReadInt("Введите минуты отправления: ");
            int n = ReadInt("Введите часы прихода пассажира: ");
            int m = ReadInt("Введите минуты прихода пассажира: ");

            string result = Logic.CountTime(a, b, c, d, n, m);
            Console.WriteLine(result);
        }
    }
}