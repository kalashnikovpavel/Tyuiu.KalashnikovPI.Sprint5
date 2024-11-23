using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x += 1)
            {
                y = Math.Round((((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x)), 2);
                strY = Convert.ToString(y);
                if (x != stopValue && (Math.Cos(x) - 2 * x) != 0)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else if (x != stopValue && (Math.Cos(x) - 2 * x) == 0)
                {
                    y = 0;
                    strY = Convert.ToString(y);
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;

        }
    }
}
