using Tyuiu.AidemirAF.Sprint6.Task5.V9.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = [0, 0];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
