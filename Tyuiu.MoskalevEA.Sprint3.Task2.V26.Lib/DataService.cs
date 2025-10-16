using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevEA.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                sum = sum + ((Math.Pow(value, 3) * startValue) + 2);
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
