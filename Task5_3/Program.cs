using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50]. Найти и вывести значение максимального, минимального элементов и их индексы

            int max = 0, min = 0;

            const int n = 10;

            int[] a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)

                a[i] = rnd.Next(0, 51);

            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");

            Console.WriteLine("-------------------");

            Console.WriteLine("{0} ", a);  //для проверки

            int minA, maxA;
            minA = maxA = a[0];  // выборка первого числа из списка

            for (int i = 1; i < a.Length; i++)
            {
                if (minA > a[i])  // если первое число больше всех последующих
                {
                    minA = a[i];
                    min = (i + 1);
                }
                if (maxA < a[i])
                {
                    maxA = a[i];
                    max = (i + 1);
                }
            }

            Console.WriteLine("Max value: " + maxA + "\nMin value: " + minA + "\nMax index: " + max + "\nMin index: " + min);
            Console.ReadKey();
        }

    }

}
