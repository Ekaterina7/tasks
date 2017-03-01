using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plochad
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, y1 = 0;
            double x2 = 0, y2 = 2;
            double x3 = 0, y3 = 4;
            double x4 = 4, y4 = 2;
            double x5 = 4, y5 = 0;
            double a = DlinaVektora(x1, y1, x2, y2);
            
            double b = DlinaVektora(x2, y2, x3, y3);
            double c = DlinaVektora(x3, y3, x4, y4);
            double d = DlinaVektora(x4, y4, x5, y5);
            double e = DlinaVektora(x5, y5, x1, y1);
            double f = DlinaVektora(x4, y4, x2, y2);
            double j = DlinaVektora(x1, y1, x4, y4);

            double polyperimetrafj = PolyPerimetr(a, f, j);

            double polyperimetrbcf = PolyPerimetr(b, c, f);

            double polyperimetrdej = PolyPerimetr(d, e, j);

           double  afjplochad = Plochad(a,f,j,polyperimetrafj);
            double    bcfplochad = Plochad(b,c,f, polyperimetrbcf);
            double dejplochad = Plochad(d, e, j, polyperimetrdej);
            SummPlochad(afjplochad, bcfplochad, dejplochad);


        }

        static double DlinaVektora(double x0, double y0, double x1, double y1)
        {
            double first = x1 - x0;
            double second = y1 - y0;
            double vector = Math.Sqrt((Math.Pow(first, 2) + (Math.Pow(second, 2))));

            return vector;
        }

        static double PolyPerimetr(double vector1, double vector2, double vector3)
        {

            double polyperimetr = (vector1 + vector2 + vector3) / 2;

            return polyperimetr;
        }

        static double Plochad(double vector1, double vector2, double vector3, double polyp)
        {
            double plochad = Math.Sqrt(polyp * (polyp - vector1) * (polyp - vector2) * (polyp - vector3));
            return plochad;

        }

        static void SummPlochad(double plochad1, double plochad2, double plochad3)
        {
            double plochad = plochad1 + plochad2 + plochad3;
            Console.WriteLine(plochad);
        }

    }
}
