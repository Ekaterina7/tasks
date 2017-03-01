using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        static int Counter(int chislo_tmp)
        {
            int s = 0;
            while (chislo_tmp != 0)
            {

                int c = chislo_tmp % 10;

                s++;
                chislo_tmp = chislo_tmp / 10;
            }
            return s;
        }

        static int Power10(int s)
        {
            int pow = (s / 2);
            return pow;

        }

        static int FirstHalfChisla(int chislo, int pow)
        {

            int half1 = (int)(chislo / Math.Pow(10, pow));
            return half1;

        }

        static int SecondHalfChisla(int chislo, int pow)
        {

            int half2 = (int)(chislo % Math.Pow(10, pow));
            return half2;

        }
    }

}
