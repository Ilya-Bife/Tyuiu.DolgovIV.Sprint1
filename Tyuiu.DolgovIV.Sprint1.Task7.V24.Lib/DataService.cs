using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgovIV.Sprint1.Task7.V24.Lib
{
    public class DataService : ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((1 + Math.Cos(Math.Pow(x + 1, 0.5))) / Math.Sin(15 * y - 4), 3);
        }
    }
}
