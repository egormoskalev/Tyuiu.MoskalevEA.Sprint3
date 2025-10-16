using Tyuiu.MoskalevEA.Sprint3.Task3.V9.Lib;

namespace Tyuiu.MoskalevEA.Sprint3.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string Value = "56hy vfe4r4 vf45b";
            char item = 'w';

            Console.WriteLine("Исходная строка" + Value);
            Console.WriteLine("Исходный символ" + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Конечская строка = " + ds.ReplaceNumOnChar(Value, item));

            Console.ReadKey();
        }
    }
}

