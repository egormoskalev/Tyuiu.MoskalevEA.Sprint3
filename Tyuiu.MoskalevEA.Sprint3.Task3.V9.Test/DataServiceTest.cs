using Tyuiu.MoskalevEA.Sprint3.Task3.V9.Lib;

namespace Tyuiu.MoskalevEA.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string Value = "56hy vfe4r4 vf45b";
            char item = 'w'; 

            string res = ds.ReplaceNumOnChar(Value, item);

            string wait = "wwhy vfewrw vfwwb";

            Assert.AreEqual(wait, res);
        }
    }
}
