using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15
{
    public class Uranvnenie
    {
        static public void Uravnenie(double a1, double b1,double c1)
        {
            a = a1;
            b = b1;
            c = c1;

            uravn(discrim());
        }
        static double a, b, c,x1,x2;

        static bool d =false;

        static private double discrim()
        {        
            return Math.Sqrt((b * b) - 4 * (a * c));
        }
        
        static private  double uravnpol(double dis)
        {
            
                return (-b + dis) / (2 * a);
            
            
        }

        static private double uravnotric(double dis)
        {
            
                return (-b - dis) / (2 * a);
            
            
        }

        static void uravn(double dis)
        {
           if(dis>=0)
            {
                x1=uravnpol(dis);
                x2=uravnotric(dis);
            }
            else
            {
                d = true;
            }
        }
        public static string reshenie1()
        {   double D = b * b;
            return "D = " + D.ToString() + " - 4 * " + a.ToString() + " * " + c.ToString() + " = " + discrim().ToString();
        }
        public static string reshenie2()
        {   double botric = -b;
            return "X1,X2 = (" + botric.ToString() + " + - " + discrim().ToString() + ") / (2 * " + a.ToString() + ") = " + x1.ToString() + ";" + x2.ToString();
        }
        public static string otvet()
        {
            if (d == true)
            {
                return "Корней нет";
            }
            return "X1 = " + x1.ToString() + ",X1 = " + x2.ToString();
        }


    }
}
