using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a;

            do
            {


                Int32.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Введите повторно число: ");

            }

            while ((a / 100 > 0) ^ (a / 1000 == 0));  /// не могу понять почему Введите повторно число повторяется еще и после выполнения условия это нахожднеия числа между этим диапозоном

            {
                Console.WriteLine("Число трехзначное");
            }
            return;






        }
    }
}
