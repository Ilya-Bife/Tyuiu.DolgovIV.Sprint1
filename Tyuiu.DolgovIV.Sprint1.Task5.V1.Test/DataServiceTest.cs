using Tyuiu.DolgovIV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double y1 = 2;
            double x2 = 5;
            double y2 = 6;
            Assert.AreEqual(ds.DistanceBetweenDots(x1,y1,x2,y2), 5);
        }
    }
}
