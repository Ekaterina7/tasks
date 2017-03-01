using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispersia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas;
            mas = new int[7];
         int mid =    MiddlZnachenie(mas);
         Console.WriteLine(mid);
         Dispersia(mas);
            

        }

        static int[] ZapolnenieMass(int[] mas, int start, int finish)
        {
            Random gen = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = gen.Next(start, finish);
            }
            return mas;

        }


        static int MiddlZnachenie(int[] mas)
        {
            mas = ZapolnenieMass(mas, 2, 9);
            int summ=0;
            for (int i = 0; i < mas.Length; i++)
            {
                summ = summ + mas[i];
            }
            return summ / mas.Length;

        }

        static void Dispersia(int[] mas)
        {
            int mid = MiddlZnachenie(mas);
            int dis;
            for (int i = 0; i < mas.Length; i++)
            {
                dis = Math.Abs(mas[i] - mid);
                Console.WriteLine("дисперсия {0} = {1} ", i, dis);
            }



        }



    }
}
