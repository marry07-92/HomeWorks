using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов. Заполнить его случайными числами в диапазоне [0, 10]. Определить максимальный элемент в каждой строке

            const int n = 10;
            const int m = 5;

            int[,] a = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int maxA = int.MaxValue;

                // выборка первого числа из списка

                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(0, 11);


                    if (maxA > a[i, j])  // если первое число больше всех последующих

                    {
                        maxA = a[i, j];

                    }

                    Console.Write("{0,3}", a[i, j]);  //для проверки
                }


                Console.WriteLine("{0,6}", maxA);  //для проверки
            }

            Console.ReadKey();
        }

    }

}
