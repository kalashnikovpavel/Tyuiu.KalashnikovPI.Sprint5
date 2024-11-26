using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            char[] punctuationMarks = new char[] { '.', ',', '!', '?', ';', ':' };
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (Array.Exists(punctuationMarks, mark => mark == c))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}

