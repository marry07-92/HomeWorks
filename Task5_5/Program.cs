using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию. Вывести отсортированный таким образом массив на экран

            const int n = 10;

            int[] a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-51, 51);

                Console.WriteLine("{0} ", a[i]);  //для проверки

            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n - 5; j++)
                {
                    if (a[i] > a[j])
                    {
                        int mas = a[i];
                        a[i] = a[j];
                        a[j] = mas;
                    }
                }

            }

            for (int i = 5; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int mas = a[i];
                        a[i] = a[j];
                        a[j] = mas;
                    }
                }

            }

            Console.Write("\n");

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0} ", a[i]);  //для проверки
            }

            Console.ReadKey();
        }

    }



}
