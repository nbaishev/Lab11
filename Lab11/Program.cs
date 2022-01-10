using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation eq = new Equation { k = 1, b = 10 };
            eq.Root();
            Console.ReadKey();
        }

        struct Equation
        {
            public float k;
            public float b;

            public void Root()
            {
               Console.WriteLine("x={0:F2}", -b / k);
            }
        }
    }
}
