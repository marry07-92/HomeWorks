using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2-ки?

            int b = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            do
            {
                a = b % 2;


                //Console.WriteLine(a); 

                if (a == 0)

                    b /= 2;

                //Console.WriteLine($"b /= 2");
                //Console.WriteLine(b);
            }

            while (a != 1);


            if ((a == 1) && (b > 2))


                Console.WriteLine("Нет");


            else if ((a == 1) && (b == 1))


                Console.WriteLine("Да");






        }
    }
}
