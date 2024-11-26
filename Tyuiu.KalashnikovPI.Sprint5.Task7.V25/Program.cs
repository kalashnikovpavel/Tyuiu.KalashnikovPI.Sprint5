using Tyuiu.KalashnikovPI.Sprint5.Task7.V25.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл) в котором есть набор   *");
            Console.WriteLine("* символьных данных.Удалить все английские слова из файла.Полученный      *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V25.txt.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask7V25.txt" });
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V25.txt" });
            Console.WriteLine("Данные находятся в файле" + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.Write(pathSaveFile);
            Console.WriteLine();

        }
    }
}
