using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevEA.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k;
            for (k = startValue; k < stopValue; k++)
            {
                sum = sum + Math.Pow(1 / (Math.Sin(k) + 2 * Math.Pow(value, k)), k);
            }
            return Math.Round(sum, 3);
        }
    }
}