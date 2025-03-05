using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.

            int a = Convert.ToInt32(Console.ReadLine());

            if ((a % 2) == 0)
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
