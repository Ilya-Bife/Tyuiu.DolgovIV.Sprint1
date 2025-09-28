﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgovIV.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            return Math.Round( 1 / Math.Pow(x - 5 * y, 0.5), 3);
        }
    }
}
