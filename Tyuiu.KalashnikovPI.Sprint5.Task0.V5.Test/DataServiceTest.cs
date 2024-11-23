using System.IO;
using Tyuiu.KalashnikovPI.Sprint5.Task0.V5.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"{Path.GetTempPath()}"
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}