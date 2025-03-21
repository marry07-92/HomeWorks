using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Сформировать двумерный массив вида
                 1 0 1 0 1
                 0 1 0 1 0
                 1 0 1 0 1
                 0 1 0 1 0
                 1 0 1 0 1
                */

            const int n = 5;

            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    a[i, j] = i % 2 == 0 & j % 2 == 0 | i % 2 == 1 & j % 2 == 1 ? 1 : 0;

                    Console.Write("{0} ", a[i, j]);  //для проверки

                }

                Console.WriteLine();  //для проверки
            }

            Console.ReadKey();
        }

    }

}
