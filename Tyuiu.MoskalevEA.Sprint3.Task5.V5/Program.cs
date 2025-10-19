using Tyuiu.MoskalevEA.Sprint3.Task5.V5.Lib;

namespace Tyuiu.MoskalevEA.Sprint3.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 3;
            int startValue2 = 10;
            int stopValue1 = 1;
            int stopValue2 = 1;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага 1= " + startValue1);
            Console.WriteLine("Конец шага 1= " + stopValue1);
            Console.WriteLine("Старт шага 2= " + startValue2);
            Console.WriteLine("Конец шага 2= " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetSumSumSeries( x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}
