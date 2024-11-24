using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            //path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V19.txt" });
            string strX = File.ReadAllText(path);
            double res = Math.Round(Math.Pow((Convert.ToDouble(strX) / Math.Cos(Convert.ToDouble(strX))), 2), 3);
            return res;
        }
    }
}
