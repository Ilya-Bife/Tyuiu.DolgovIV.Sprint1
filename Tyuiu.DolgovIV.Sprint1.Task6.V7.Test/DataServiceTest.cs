using Tyuiu.DolgovIV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.DolgovIV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string name = " Hello Wo rld !";
            Assert.AreEqual(ds.DeleteLastLetter(name), " Hell W rl ");
        }
    }
}
