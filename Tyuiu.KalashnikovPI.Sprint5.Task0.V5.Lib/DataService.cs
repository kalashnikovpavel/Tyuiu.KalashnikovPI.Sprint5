using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            x = 3;
            double y = Math.Log(x+1) - Math.Log(x+2);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;

        }
    }
}
