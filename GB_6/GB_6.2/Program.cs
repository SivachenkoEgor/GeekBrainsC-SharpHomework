using System;
using System.IO;
using CallBackConsole;

namespace GB_6._2
{
    /*    2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    а) Сделать меню с различными функциями и представить пользователю выбор,
       для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
       в котором хранятся различные функции.
    б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
    Пусть она возвращает минимум через параметр(с использованием модификатора out).*/

    class Program
    {
        
        static void Main(string[] args)
        {
            Exercise_Shower();

        }

        static void Exercise_Shower()
        {
            MinClass minInstance = new();
            minInstance.RegisterHandler(ConsoleView.CallBackConsole);
            minInstance.FuncMin(1, -100, 100, 0.5, out double[] arr);
        }
    }

}
