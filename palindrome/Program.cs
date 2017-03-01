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
            int chislo = 123321;
            int s = Counter(chislo);
            Console.WriteLine(s);
            int pow = Power10(s);
            int half1 = FirstHalfChisla(chislo, pow);
            int half2 = SecondHalfChisla(chislo, pow);



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

        static int ZapisNaooborot(int half2)
        {
            string halfnaoborot = " ";
            while (half2 == 0)
            {
                halfnaoborot = Convert.ToString(half2 % 10) + halfnaoborot;
                half2 = half2 / 10;

            }
            int halfnaoborottoint = Convert.ToInt32(halfnaoborot);
            return halfnaoborottoint;
        }

        static void Sravnenie(int s1, int half1)
        {

            if (s1 == half1)

                Console.WriteLine("palindrome");
            else

                Console.WriteLine("nopalindrome");


        }
    }

}
