using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводятся четыре числа. Вывести большее из них.

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Math.Max(Math.Max(Math.Max(a, b), c), d));  
            Console.ReadKey();



        }
    }
}
