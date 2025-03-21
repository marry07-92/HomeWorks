using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            int b = Convert.ToInt32(Console.ReadLine());  // Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

            if (a == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    a *= i;  //1* количество вводных перемноженных чисел до значения b за это отвечает *=
                }
                Console.WriteLine(a);


            }
        }
    }
}
