using Tyuiu.AidemirAF.Sprint6.Task6.V30.Lib;
namespace Tyuiu.AidemirAF.Sprint6.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
            DataService ds = new DataService();

            string res = ds.CollectTextFromFile(path);
            string wait = "PAlR qdsTS zgGQ XVZeHq dwMQ";
            Assert.AreEqual(wait, res);
        }
    }
}
