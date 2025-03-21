using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]. Перевернуть массив, т.е. переставить элементы массива в обратном порядке

            const int n = 10;

            int[] a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(0, 11);

                Console.WriteLine("mas[" + (i + 1) + "] = " + a[i]);  //"mas[" + (i + 1) + "] присваиваем каждому числу индекс,  + a[i] к индексу добавляем рандомные числа

            }

            Console.WriteLine();

            Array.Reverse(a);

            for (int i = 0; i < a.Length; i++)
            {
                // тут убиваем      Array.Reverse(a);
                Console.WriteLine("mas[" + (i + 1) + "] = " + a[i]);
            }
            Console.ReadKey();

        }

    }
}
