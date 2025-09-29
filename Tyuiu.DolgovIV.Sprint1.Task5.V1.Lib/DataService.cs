using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgovIV.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            return Convert.ToInt32(Math.Pow(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2), 0.5));
        }
    }
}
