using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.

            int a = Convert.ToInt32(Console.ReadLine());

            if (-10 <= a && a <= 10)

            {

                Console.WriteLine("Да");

            }
            else
            {
                Console.WriteLine("Нет");


            }
            Console.ReadKey();


        }
    }
}
