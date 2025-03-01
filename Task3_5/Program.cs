using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.

            var a = Convert.ToString(Console.ReadLine());
            var b = a.Substring(a.Length - 1);
            int c = Convert.ToInt32((b));
            if (c == 0)
            {
                Console.WriteLine("Да");
                Console.ReadKey();

            }

            Console.WriteLine("Нет");
            Console.ReadKey();



        }
    }
}
