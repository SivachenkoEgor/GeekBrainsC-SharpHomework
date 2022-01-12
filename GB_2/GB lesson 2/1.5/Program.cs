using System;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //5.
            //а) Написать программу, которая запрашивает массу и рост человека,
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            // m/h^2, < 16 / 16 - 18,5 / 18,5 - 25 (norma) / 25 - 30 / 30 - 35 / 35 - 40 / > 40

            void IMTcalc(double weight, double height)
            {
                double IMT = weight / (height * height);

                if (IMT > 25)
                {
                    double lossCount = (IMT - 25) * (height * height);
                    Console.WriteLine($" У вас лишний вес, рекомендую сбросить {lossCount:F} кг");
                }
                else if (IMT < 18.5)
                {
                    double gainCount = (18.5 - IMT) * (height * height);
                    Console.WriteLine($" У вас недостаточный вес, рекомендую набрать  {gainCount:F} кг");
                }
                else Console.WriteLine("Вы в порядке!");
                return;
            }
            Console.Write("Введите свой вес");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в метрах ");
            double height = Convert.ToDouble(Console.ReadLine());

            IMTcalc(weight, height);


        }
    }
}
