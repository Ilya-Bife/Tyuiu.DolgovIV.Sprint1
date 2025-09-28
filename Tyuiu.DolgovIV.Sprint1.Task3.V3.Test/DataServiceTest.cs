using Tyuiu.DolgovIV.Sprint1.Task3.V3.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 7.5;
            double z = 5;
            var res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(337.5,res);

        }
    }
}
