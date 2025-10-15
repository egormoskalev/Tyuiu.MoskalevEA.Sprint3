using Tyuiu.MoskalevEA.Sprint3.Task1.V28.Lib;

namespace Tyuiu.MoskalevEA.Sprint3.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1.001;

            Assert.AreEqual(wait, res);
        }
    }
}
