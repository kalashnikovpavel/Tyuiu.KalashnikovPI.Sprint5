using Tyuiu.KalashnikovPI.Sprint5.Task6.V14.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task6.V14
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл) в  котором есть набор  *");
            Console.WriteLine("* символьных данных.Найти количество знаков препинания в заданной строке. *");
            Console.WriteLine("*                                                                         *");

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask6V14.txt" });

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("данные находятся в файле " + path);

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

        }
    }
}
