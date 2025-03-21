using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных


            const int n = 10;

            int[] a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)

            {
                a[i] = rnd.Next(-1, 101);

                //Console.WriteLine("{0} ", a[i]);  для проверки

            }
            int size1 = a.Count(c => c % 2 == 0); //определяю количество четных

            int size2 = a.Count(c => c % 2 != 0); //определяю количество нечетных

            if (size1 > size2)
            {
                Console.WriteLine("больше четных ");
            }
                        else
            {
                Console.WriteLine("больше нечетных ");
            }

            Console.ReadKey();

        }
    }
}
