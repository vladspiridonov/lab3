using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_dots_ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Xa:");
            double xa=Convert.ToDouble(Console.ReadLine());
            Console.Write("Ya:");
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Xb:");
            double xb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yb:");
            double yb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Xc:");
            double xc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yc:");
            double yc = Convert.ToDouble(Console.ReadLine());
            double LAB = 0;
            double LAC = 0;
            LAB = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
            LAC = Math.Sqrt(Math.Pow(xc - xa, 2) + Math.Pow(yc - ya, 2));
            if (xb == xc && yb == yc)
            {
                if (xb == xa && yb == ya)
                {
                    Console.WriteLine("координаты точек A, B и С совпадают ({0},{1})" ,xa,ya);
                }
                else
                {
                    Console.WriteLine("Координаты точек В и С совпадают ({0},{1}). Расстояние до точки А {2}.", xb, yb, LAB);
                }
            }
            else
            {
                double Difference = LAB - LAC;
                if (Difference!=0)
                {
                    if (Difference>0)
                    {
                        Console.WriteLine("Точка С ({0},{1}). Расстояние {2}" , xc,yc,LAC);
                    }
                    else
                    {
                        Console.WriteLine("Точка B ({0},{1}). Расстояние {2}", xb, yb, LAB);
                    }
                }
                else
                {
                    Console.WriteLine("Точки В и С равноудалены от точки А на расстояние {0}" , LAB);
                    Console.WriteLine("Точка С ({0},{1}), Точка B ({2},{3})" ,xc,yc,xb,yb);
                }
            }
            Console.ReadKey();
        }
    }
}
