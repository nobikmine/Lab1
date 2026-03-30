using System;

namespace ConsoleApp1
{
    public static class Logic
    {
        public static string CountTime(string[] trainIn, string[] trainOut, string[] humanHere)
        {
            if (trainIn.Length < 2 || trainOut.Length < 2 || humanHere.Length < 2 ||
                string.IsNullOrWhiteSpace(trainIn[0]) || string.IsNullOrWhiteSpace(trainIn[1]) ||
                string.IsNullOrWhiteSpace(trainOut[0]) || string.IsNullOrWhiteSpace(trainOut[1]) ||
                string.IsNullOrWhiteSpace(humanHere[0]) || string.IsNullOrWhiteSpace(humanHere[1]))
            {
                return "Ошибка: введены не все значения времени";
            }

            int a = int.Parse(trainIn[0]);
            int b = int.Parse(trainIn[1]);

            int c = int.Parse(trainOut[0]);
            int d = int.Parse(trainOut[1]);

            int n = int.Parse(humanHere[0]);
            int m = int.Parse(humanHere[1]);

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
        static void Main(string[] args)
        {
            Console.Write("Введите время прибытия поезда (часы минуты через пробел): ");
            string[] trainIn = Console.ReadLine()?.Split(' ');

            Console.Write("Введите время отправления поезда (часы минуты через пробел): ");
            string[] trainOut = Console.ReadLine()?.Split(' ');

            Console.Write("Введите время прихода пассажира (часы минуты через пробел): ");
            string[] humanHere = Console.ReadLine()?.Split(' ');

            string result = Logic.CountTime(trainIn, trainOut, humanHere);
            Console.WriteLine(result);
        }
    }
}