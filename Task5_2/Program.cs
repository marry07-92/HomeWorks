using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20]. Определить количество положительных, отрицательных и равных нулю элементов

            const int n = 10;

            int[] a = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)

            {
                a[i] = rnd.Next(-21, 21);  //int num = rnd.Next(1, 3)==1 ? rnd.Next(10, 21) : rnd.Next(50,61);

                Console.WriteLine("{0} ", a[i]);  //для проверки
            }

            int size1 = a.Count(c => c > 0 & c != 0); //определяю количество положит

            int size2 = a.Count(c => c < 0); //определяю количество отриц

            int size3 = a.Count((int c) => c == 0); //определяю количество 0

            Console.WriteLine("Итого: положительных {0}, отрицательных {1}, нулей {2} ", size1, size2, size3);

            if (size1 > size2)

            {
                Console.WriteLine("больше положительных ");
            }

            else if (size2 > size1)
            {
                Console.WriteLine("больше отрицательных");
            }
            else
            {
                Console.WriteLine("чисел поровну");

            }

            Console.ReadKey();

        }

    }
}
