using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KalashnikovPI.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            char[] eng = new char[] { 'H', 'e', 'l', 'o', 'I', 's', 'M', 'y', 'F', 'i', 'r', 't', 'P', 'r', 'o', 'g', 'a', 'm' };
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V25.txt");

           
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    StringBuilder strLine = new StringBuilder();

                    foreach (char c in line)
                    {
                        
                        if (!eng.Contains(c))
                        {
                            strLine.Append(c);
                        }
                    }

                    
                    File.AppendAllText(pathSaveFile, strLine.ToString().Trim() + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}
