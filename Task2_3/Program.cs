using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double t = a * 0.0254; //в данном случае перевод из дюйма в см
            double m = Math.Truncate(t);
            double c = Math.Truncate(t * 100) - (m * 100);
            double l = (t * 1000) - (m * 1000) - (c * 10);

            Console.Write("{0} {1} {2}", m, c, l);
            Console.ReadKey();
        }
    }
}
