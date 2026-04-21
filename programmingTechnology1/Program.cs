using System;

namespace ConsoleApp1
{
    public static class Logic
    {
        public static string CountTime(int trainHourIn, int trainMinIn, int trianHourOut, int trainMinOut, int humanHour, int humanMin)
        {
            if (trainHourIn < 0 || trainHourIn > 23 || trianHourOut < 0 || trianHourOut > 23 || humanHour < 0 || humanHour > 23 || 
                trainMinIn < 0 || trainMinIn > 59 || trainMinOut < 0 || trainMinOut > 59 || humanMin < 0 || humanMin > 59)
            {
                return "Ошибка: некорректное время";
            }

            int minutesIn = trainHourIn * 60 + trainMinIn;
            int minutesOut = trianHourOut * 60 + trainMinOut;
            int minutesHere = humanHour * 60 + humanMin;

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

                Console.WriteLine("Ошибка: введите правильное число");
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