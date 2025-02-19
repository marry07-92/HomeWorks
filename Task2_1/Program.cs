using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int t = c;
            c = b;
            b = a;
            a = t;
            t = b;
            b = c;
            c = t;

            Console.Write("{0} {1} {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
