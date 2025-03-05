using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.

            int a = Convert.ToInt32(Console.ReadLine());

            if ((a / 10 > 0) && (a / 100 == 0))

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
