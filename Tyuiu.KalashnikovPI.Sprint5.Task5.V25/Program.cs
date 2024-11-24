using Tyuiu.KalashnikovPI.Sprint5.Task5.V25.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task5.V25
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти произведение всех вещественных чисел в файле. Результат округлить *");
            Console.WriteLine("*  до 3 знаков после запятой. Полученный результат вывести на консоль. У  *");
            Console.WriteLine("* вещественных значений округлить до трёх знаков после запятой            *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V25.txt" });

            Console.WriteLine("Данные находятся в папке " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("произведение элементов файла = " + res);
        }
    }
}
