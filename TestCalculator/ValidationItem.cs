using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class ValidationItem
    {
        public int Expected { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int Action { get; set; }
        public string Message { get; set; }
    }
}
