using System.IO;
namespace Tyuiu.KalashnikovPI.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}