using Tyuiu.DolgovIV.Sprint1.Task1.V9.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0f;
            double y = 2.0f;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}
