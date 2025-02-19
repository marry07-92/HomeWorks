using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());


            int c1 = a / 1000;
            int c2 = a / 100;
            int c3 = a / 10;
            int c4 = c2 - (c1 * 10);
            int c5 = c3 - (c4 * 10) - (c1 * 100);
            int c6 = a - (c1 * 1000) - (c4 * 100) - (c5 * 10);

            int a2 = c1 * 1000 + c5 * 10 + c6 * 100 + c4;
            Console.Write(a2);
            Console.ReadKey();
        }
    }
}
