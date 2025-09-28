using Tyuiu.DolgovIV.Sprint1.Task2.V25.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(572.958, res);
        }
    }
}
