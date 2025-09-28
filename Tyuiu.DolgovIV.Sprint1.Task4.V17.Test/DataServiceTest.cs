using Tyuiu.DolgovIV.Sprint1.Task4.V17.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);

        }
    }
}
