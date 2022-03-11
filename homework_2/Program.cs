using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a - ededi 3-e bolunən cüt ədəddirsə "3-e bolunur cutdur" ,

          3-e bolunən tek ededdirse "

         3-e bolunur tekdir" eks halda "3-e bolunmur" sözünü ekranda çap edin
             

             */

            int a = 4843943;

            if (a % 3 == 0 && a % 2 == 0) 
            {
                Console.WriteLine("3 - e bolunur cutdur");
            }

            else  if (a % 3 == 0)
            {
                Console.WriteLine("3 - e bolunur tekdir");
            }

            else
            {
                Console.WriteLine("3 -e bolunmur");
            }



        }
    }
}
