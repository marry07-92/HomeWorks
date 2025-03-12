using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math


            double с = 1; // число результата

            double a = Convert.ToInt32(Console.ReadLine()); // вводное число

            double b = Convert.ToInt32(Console.ReadLine()); // вводное число степени


            for (double i = 0; i < (-1 * b); i++)

            {

                с *= (1 / a); //1* количество вводных  перемноженных чисел до значения b



            }
            Console.WriteLine(с);
        }



    }



}
