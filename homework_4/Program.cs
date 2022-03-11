using System;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     a ededi 1-reqemlidirse cavabda 1-reqemli
                   2-reqemlidise cavabda 2reqemli
                   5-reqemlidise cavabda 5reqemli cap edin
             */

            int a = 44;
            if (a>0 && a < 10)
            {
                Console.WriteLine("1-reqemli");
            }

            else if (a > 9 && a < 100)
            {
                Console.WriteLine("2-reqemli");
            }

            else if (a>9999 && a < 100000)
            {
                Console.WriteLine("5-reqemli");
            }
        }
    }
}
