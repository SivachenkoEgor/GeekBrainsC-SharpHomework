using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_3._3
{
    class FractionException : ArgumentException
    {
        public int Value { get; }
        public FractionException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
}
