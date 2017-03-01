using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("наименьшее общее кратное =  "+NOK(2, 6));
        }

        static int NOK(int a, int b)
        {
            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;

        }
    }
}
