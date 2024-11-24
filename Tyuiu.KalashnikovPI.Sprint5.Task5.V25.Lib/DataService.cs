using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            double val = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {  
                    
                    val = Convert.ToDouble(line);
                    if(val % 1 != 0)
                    {
                        res = res * val;
                    }
                                      
                }
            }
            return Math.Round(res,3);
        }
    }
}
