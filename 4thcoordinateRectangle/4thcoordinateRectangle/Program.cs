using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thcoordinateRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectanle coordinates:");
            Console.WriteLine("x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0},{1}),({2},{3}),({4},{5})", x1,y1,x2,y2,x3,y3);
            int x4 = 0;
            int y4 = 0;
            byte Z = 0;
            if (x1==x2)
            {
                if (x3!=x1)
                {
                    if (y3 == y1)
                    {
                        y4 = y2;
                        x4 = x3;
                        Z = 1;
                    }
                    else
                    {
                        if (y3 == y2)
                        {
                            y4 = y1;
                            x4 = x3;
                            Z = 1;
                        }
                    }
                }
                

            }
            else
            {
                if (x1==x3)
                {
                    if (x2!=x1)
                    {
                        if (y2 == y1)
                        {
                            y4 = y3;
                            x4 = x2;
                            Z = 1;
                        }
                    }
                    
                }
                else
                {
                    if (x2==x3)
                    {
                        y4 = y2;
                        x4 = x1;
                        Z=1;
                    }
                }
            }
            if (Z==0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("{0},{1}" , x4,y4);
            }
            Console.ReadKey();
        }
    }
}
