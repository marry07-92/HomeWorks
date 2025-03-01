using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводятся три числа. Вывести большее их них.

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Math.Max(Math.Max(a, b), c));  
            Console.ReadKey();


        }
    }
}
