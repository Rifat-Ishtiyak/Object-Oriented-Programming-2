using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Class1
    {
        int a, b;
        public Class1()
        {
            Console.WriteLine("default Constructor");
        }

        public Class1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Display()
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }


    }
}
