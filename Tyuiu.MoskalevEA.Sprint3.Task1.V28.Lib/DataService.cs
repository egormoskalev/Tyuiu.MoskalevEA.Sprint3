﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevEA.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k;
            for (k = startValue; k < stopValue; k++)
            {
                sum = sum + ((Math.Pow(value , k) + 0.25) * Math.Cos(k));
            }
            return Math.Round(sum, 3);
        }
    }
}