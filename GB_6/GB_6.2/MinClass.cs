﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GB_6._2
{
    public delegate double FunctionsDelegate(double x);

    class MinClass
    {
        readonly FunctionsDelegate[] del = { 
            delegate(double x) {return x * x - 50 * x + 10; },
            delegate(double x) {return x*x + 25 * x +5; },
            delegate(double x) {return x*x + 10 * x -2; },
            delegate(double x) {return x*x + 30 * x +10; }
        };
        public void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(del[0](x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }


        /*    2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделать меню с различными функциями и представить пользователю выбор,
   для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,
   в котором хранятся различные функции.
*/

        public double FuncMin(int choice, double from, double to, double step)
        {
            FunctionsDelegate currentFunction = choice switch
            {
                1 => del[0],
                2 => del[1],
                3 => del[2],
                4 => del[3],
                _ => throw new Exception("Выберите число от 1 до 4"),
            };

            double min = double.MaxValue;
            double x = from;
            while (x <= to)
            {
                if (currentFunction(x) < min) min = currentFunction(x);
                x +=step;
            }
            return min;
        }
        public double FuncMin(int choice, double from, double to, double step, out double[] arr)
        {
            FunctionsDelegate currentFunction = choice switch
            {
                1 => del[0],
                2 => del[1],
                3 => del[2],
                4 => del[3],
                _ => throw new Exception("Выберите число от 1 до 4"),
            };
            
            
            
            arr = new double[Convert.ToInt32(Math.Abs(Math.Ceiling((from - to )/ step)))+1];
            double min = double.MaxValue;
            double x = from;
            int i = 0;
            while (x <= to)
            {
                if (currentFunction(x) < min) min = currentFunction(x);
                arr[i] = currentFunction(x);
                i++;
                x += step;
            }
            return min;
        }

        /*
                б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
        Пусть она возвращает минимум через параметр(с использованием модификатора out).*/


    }


}
