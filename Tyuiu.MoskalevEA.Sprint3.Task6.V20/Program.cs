using Tyuiu.MoskalevEA.Sprint3.Task6.V20.Lib;

namespace Tyuiu.MoskalevEA.Sprint3.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Москалев Е.А. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [20, 32], количество всех делителей.    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 20;
            int stopValue = 32;

            Console.WriteLine("Отрезок: [" + startValue + ", " + stopValue + "]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int totalDivisorsSum = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("количества делителей = " + totalDivisorsSum);

            Console.ReadKey();
        }
    }
}
