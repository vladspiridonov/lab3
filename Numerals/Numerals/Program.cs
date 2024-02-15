using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            short Number = Convert.ToInt16(Console.ReadLine());
            short i = (short)(Number / 100);
            short j = (short)(Number / 10 % 10);
            short k = (short)(Number % 10);
            Console.WriteLine("{0}{1}{2}" ,i,j,k);
            if (Number<100|| Number > 999)
            {
                Console.WriteLine("wrong number");
            }
            else
            {
                string One = "один";
                string Two ="два";
                string ATwo = "две";
                string Three ="три";
                string Four="четыре";
                string Five="пять";
                string Six="шесть";
                string Seven="семь";
                string Eight="восемь";
                string Nine="девять";
                string Ten="десять";
               // string ATen="десят";
               // string Eleven="";
               // string Twelve;
                string Nadcat="надцать";
                //string Dcat="дцать";
                //string Fourty="сорок";
                string Ninety="девяносто";
                //string Hundred="сто";
                //string IHundred="сти";
               // string AHundred = "ста";

                switch (i)
                {
                    case 1:
                        {
                            Console.Write("сто ");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("двести ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("триста ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("четыреста ");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пятьсот ");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шестьсот ");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семьсот ");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемьсот ");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("девятьсот ");
                            break;
                        }
                    default:
                        break;
                }
                switch (j)
                {
                    case 0:
                        switch (k)
                        {
                            case 1:
                                {
                                    Console.Write(One);
                                    break;
                                }
                            case 2:
                                {
                                    Console.Write(Two);
                                    break;
                                }
                            case 3:
                                {
                                    Console.Write(Three);
                                    break;
                                }
                            case 4:
                                {
                                    Console.Write(Four);
                                    break;
                                }
                            case 5:
                                {
                                    Console.Write(Five);
                                    break;
                                }
                            case 6:
                                {
                                    Console.Write(Six);
                                    break;
                                }
                            case 7:
                                {
                                    Console.Write(Seven);
                                    break;
                                }
                            case 8:
                                {
                                    Console.Write(Eight);
                                    break;
                                }
                            case 9:
                                {
                                    Console.Write(Nine);
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    case 1:
                        {
                            switch (k)
                            {
                                case 0:
                                    {
                                        Console.Write(Ten);
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.Write("{0}{1}", One, Nadcat);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("{0}{1}", ATwo, Nadcat);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("{0}{1}", Three,Nadcat);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write("четырнадцать");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write("пятнадцать");
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write("шестнадцать");
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write("семнадцать");
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write("восемнадцать");
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write("девятнадцать");
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("двадцать ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("тридцать ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("сорок ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("пятьдесят ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Write("шестьдесят ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Write("семьдесят ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.Write("восемьдесят ");
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.Write(Ninety);
                            switch (k)
                            {
                                case 1:
                                    {
                                        Console.Write(One);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write(Two);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write(Three);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write(Four);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Write(Five);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write(Six);
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.Write(Seven);
                                        break;
                                    }
                                case 8:
                                    {
                                        Console.Write(Eight);
                                        break;
                                    }
                                case 9:
                                    {
                                        Console.Write(Nine);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
