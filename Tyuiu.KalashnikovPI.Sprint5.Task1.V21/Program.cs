using Tyuiu.KalashnikovPI.Sprint5.Task1.V21.Lib;
namespace Tyuiu.KalashnikovPI.Sprint5.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int endValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано функция произвести табулирование                                   *");
            Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль. Округлить до   *");
            Console.WriteLine("* двух знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("ndValue = " + endValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, endValue);
            Console.WriteLine("Файл " + res + " создан!");
        }
    }
}
