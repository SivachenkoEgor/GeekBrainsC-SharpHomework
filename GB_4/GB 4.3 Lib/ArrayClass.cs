using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_4._3_Lib
{
    public class ArrayClass
    {

        

        private int[] Arr;
        public int this[int i]
        {
            get { return Arr[i]; }
            set { Arr[i] = value; }
        }
        public int MaxCount
        {
            get
            {
                int maxCount = 0;

                for (int i = 0; i < this.Arr.Length; i++)
                {
                    if (this.Arr[i] == this.Arr.Max())
                        maxCount++;
                }
                return maxCount;
            }
        }

        


        public ArrayClass(int len)
        {
            Arr = new int[len];
            //numberFrequency = new(len);
        }
        public ArrayClass(int len, int val, int step) : this(len)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = val;
                val += step;
                //numberFrequency = new(len);
            }

        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < this.Arr.Length; i++)
            {
                sum += this.Arr[i];
            }
            return sum;
        }

        public void Multi(int multi)
        {

            for (int i = 0; i < this.Arr.Length; i++)
                this.Arr[i] *= multi;
        }

        public int[] Inverse()
        {
            int[] newArr = new int[Arr.Length];
            for (int i = 0; i < Arr.Length; i++)
                newArr[i] = -Arr[i];
            return newArr;
        }
        public void Print()
        {
            for (int i = 0; i < this.Arr.Length; i++)
                Console.Write($"{Arr[i]} ");
            Console.WriteLine();
        }

        // благородно украдено с сайта майкрософта ( в случае если пользователь захочет распечатывать массив из view )


        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }
        public class MyEnumerator
        {
            int nIndex;
            private ArrayClass a;
            public MyEnumerator(ArrayClass coll)
            {
                a = coll;
                nIndex = -1;
            }

            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < a.Arr.Length);
            }

            public int Current => a.Arr[nIndex];
        }

    }
}
