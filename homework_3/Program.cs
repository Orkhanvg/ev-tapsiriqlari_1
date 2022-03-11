using System;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3.a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"
            cem 3 reqemlidirse "cem ucreqemlidir" eks halda "nezere alinmayıb" cap edilsin
             */


            int a = 43;
            int b = 2;
            int c = a + b;
            
                if ((c > 9 && c > 100))
            {
                Console.WriteLine("cem ikireqemli ededdir");

            }

                else if ((c > 99 && c > 1000))
            {
                Console.WriteLine("cem ucreqemlidir");
            }

                else
            {
                Console.WriteLine("nezere alinmayıb");
            }
        }
    }
}
