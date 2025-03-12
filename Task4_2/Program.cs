using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0; // число результата

            int b = Convert.ToInt32(Console.ReadLine()); //Вводится натуральное число n. Найти 1 + 1 / 2 + 1 / 3 + … +1 / n


            for (double i = 1; i <= b; i++)

            {
                a += (1 / i);  //получаю дробный результат


            }

            Console.WriteLine(Convert.ToInt32(a));  // конвертирую в натуральное число



        }


    }

}
