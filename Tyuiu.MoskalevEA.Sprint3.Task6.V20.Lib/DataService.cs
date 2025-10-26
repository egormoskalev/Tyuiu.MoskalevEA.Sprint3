using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MoskalevEA.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;


            for (int n = startValue; n <= stopValue; n++)
            {
                
                int divisorCount = 0;
               
                for (int d = 1; d <= n && d <= 11; d++)
                {
                        if (n % d == 0)
                            divisorCount++;
                }

                totalSum += divisorCount;
           
            }

            return totalSum;
        }
    }
}