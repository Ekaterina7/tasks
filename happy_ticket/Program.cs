using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ticket
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int s = 0;


            int chislo = 123455;
            s = Counter(chislo);
            PrintCounter(s);

            int pow = Power10(s);
            PrintPower(pow);
            int half1 = FirstHalfChisla(chislo, pow);
            PrintFirstHalfChisla(half1);
            int half2 = SecondHalfChisla(chislo, pow);
            PrintSecondHalfChisla(half2);


            int counthalf1 = Counter(half1);
            int counthalf2 = Counter(half2);
            int summhalf1 = SummCounter(half1);
            PrintSummCounter(summhalf1);
            int summhalf2 = SummCounter(half2);
            PrintSummCounter2(half2);
            СomparisonSummHalf1AndSummHalf2(summhalf1, summhalf2);



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
        static void PrintCounter(int s)
        {

            Console.WriteLine(" цифр в числе = " + s);

        }


        static int Power10(int s)
        {
            int pow = (s / 2);
            return pow;

        }
        static void PrintPower(int pow)
        {

            Console.WriteLine(" Степень 10 = " + pow);
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
        static void PrintFirstHalfChisla(int half1)
        {
            Console.WriteLine(" первая половина числа = " + half1);

        }

        static void PrintSecondHalfChisla(int half2)
        {
            Console.WriteLine(" вторая половина числа = " + half2);

        }

        static int SummCounter(int half)
        {
            int summhalf = 0;
            while (half != 0)
            {

                int c = half % 10;

                summhalf = summhalf + c;
                half = half / 10;
            }
            return summhalf;

        }

        static void PrintSummCounter(int summhalf1)
        {

            Console.WriteLine(" сумма цифр первой половины = " + summhalf1);
        }

        static void PrintSummCounter2(int summhalf2)
        {

            Console.WriteLine(" сумма цифр второй  половины = " + summhalf2);
        }

        static void СomparisonSummHalf1AndSummHalf2(int summhalf1, int summhalf2)
        {
            if (summhalf1 == summhalf2)

                Console.WriteLine(" happy");

            else Console.WriteLine(" unhappy");

        }
    }
}
