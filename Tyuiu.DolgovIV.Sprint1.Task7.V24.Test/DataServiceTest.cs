using Tyuiu.DolgovIV.Sprint1.Task7.V24.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 4/15;
            Assert.AreEqual(ds.Calculate(x, y), 2.643);
        }
    }
}
