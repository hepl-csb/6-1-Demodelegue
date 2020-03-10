using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Demodelegue
{
    public class SimpleMath
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static int Subtract(int x, int y)
        { return x - y; }
        public static int Multiply(int x, int y)
        { return x * y; }
        public static int Divide(int x, int y)
        { return x / y; }
    }

    public enum Operation { Plus=0, Moins, Fois, Divise}

}
