using System;

namespace GB_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Сиваченко Егор Александрович
            //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            Console.Write("Введите вес (в кг) ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост (в м) ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ: {bmi}");
        }
    }
}
