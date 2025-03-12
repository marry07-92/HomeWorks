using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            Console.WriteLine("Введите число: ");
            int a;


            do
            {


                Int32.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Введите повторно число: ");

            }

            while (a < 20 || a > 60);  /// не могу понять почему Введите повторно число повторяется еще и после выполнения условия это нахожднеия числа между этим диапозоном
            {

            }

            return;


        }


    }


}

