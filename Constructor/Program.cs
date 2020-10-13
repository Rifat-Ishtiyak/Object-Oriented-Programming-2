using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1(23, 65);
             c1 = new Class1();
          

            c1.Display();
        }
    }
}
