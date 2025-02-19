using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            double t = ((a + (b / 60) + (c / 3600))) * Math.PI / 180; //в данном случае перевод из градосо минут и секунд в градусы, далее из градусов радианы. t=x*pi/180


            Console.Write(t);
            Console.ReadKey();
        }
    }
}
