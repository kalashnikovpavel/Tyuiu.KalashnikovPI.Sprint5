using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KalashnikovPI.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            char[] eng = new char[] { 'H', 'e', 'l', 'o', 'I', 's', 'M', 'y', 'f', 'i', 'r', 't', 'P', 'r', 'o', 'g', 'a', 'm' };
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V25.txt" });
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(pathSaveFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach(string word in words)
                    {
                        if (!word.Any(c => eng.Contains(c)))
                        {
                            
                            writer.Write(word + " ");
                        }
                    }
                    writer.WriteLine();
                }
            }
            return pathSaveFile;
            
        }
    }
}
