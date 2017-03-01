using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1000; i < 1000; i++)
            {
                int half1 = Half1(i);
                int half2 = Half2(i);
                int summ1 = SummZiferHalf(half1);
                int summ2 = SummZiferHalf(half2);
                Console.Write(i);
                ProverkaForHappy(summ1, summ2);
            }
        }
        static int Half1(int chislo)
        {
            int half1 = chislo / 100;
            return half1;
        }

        static int Half2(int chislo)
        {
            int half2 = chislo % 100;
            return half2;
        }

        static int SummZiferHalf(int half)
        {
            int summ = 0;
            while (half != 0)
            {
                summ = half % 10;
                half = half / 10;
            }
            return summ;


        }
        static void ProverkaForHappy(int summ1, int summ2)
        {
            
            if (summ1 == summ2)
            {
                Console.WriteLine("happy" );
            }
            else
            {
                Console.WriteLine("unhappy" );
            }

        }


    }
}
