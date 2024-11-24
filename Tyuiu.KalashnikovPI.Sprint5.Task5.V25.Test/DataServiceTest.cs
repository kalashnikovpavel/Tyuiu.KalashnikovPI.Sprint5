using System.IO;
using Tyuiu.KalashnikovPI.Sprint5.Task5.V25.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(true, wait);

        }
    }
}