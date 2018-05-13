using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class S
    {
         public S(double a1,double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
            PLshd(height());
        }
        static double a, b, c, PL;
       static double height()
        {   double p = (a + b + c) / 2;
            return 2 * (Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a;
        }
        static void PLshd(double h)
        {
            PL = a / 2 * h;
        }
        static public string otvet()
        {
            return "Площадь треугольника: " + PL.ToString();
        }
    }
}
