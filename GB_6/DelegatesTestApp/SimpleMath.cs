using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTestApp
{
    public delegate void MathOperationsStateHandler(string message);
    class SimpleMath
    {
        MathOperationsStateHandler del;
        public void RegisterHandler(MathOperationsStateHandler del)
        {
            this.del += del;
        }
        public int Add(int x, int y)
        {
            int sum = x + y;
            del?.Invoke($"Сумма чисел {sum}");
            return sum;
        }

        public int Sub(int x, int y)
        {
            int sub = x - y;
            del?.Invoke($"Разность чисел {sub}");
            return sub;
        }
        public int Multi(int x, int y)
        {
            int mult = x * y;
            del?.Invoke($"Произведение чисел {mult}");
            return mult;
        }
    }
}
