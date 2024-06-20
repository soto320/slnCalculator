using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        public int Multiplication(int a, int b)
        {
            Thread.Sleep(100);
            return a * b;
        }
    }
}
