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
            bool hasValues = false; // Для отслеживания наличия вещественных чисел

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на значения
                    string[] values = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var value in values)
                    {
                        // Заменяем запятую на точку для корректного парсинга
                        string normalizedValue = value.Replace(',', '.');

                        // Проверяем, является ли значение вещественным числом
                        if (double.TryParse(normalizedValue, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                        {
                            // Проверяем, является ли число вещественным
                            if (number % 1 != 0)
                            {
                                res *= Math.Round(number, 3); // Умножаем на округленное значение
                                hasValues = true; // Устанавливаем флаг, если найдено вещественное число
                            }
                        }
                    }
                }
            }

            // Если не найдено вещественных чисел, возвращаем 0
            return hasValues ? Math.Round(res, 3) : 0;
        }
    }
}