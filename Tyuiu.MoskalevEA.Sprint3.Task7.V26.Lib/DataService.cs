using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MoskalevEA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = 0;

                y = 5 - 3 * x + ((1 + Math.Sin(x)) / 2 * x - 0.5);

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
