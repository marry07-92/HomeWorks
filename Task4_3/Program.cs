using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие задачи Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math

            int с = 1; // число результата

            int a = Convert.ToInt32(Console.ReadLine()); // вводное число

            int b = Convert.ToInt32(Console.ReadLine()); // вводное число степени

            if (с == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < b; i++)
                {

                    с *= a;  //1* количество вводных  перемноженных чисел до значения b за это отвечает *=

                }
                Console.WriteLine(с);
            }



        }



    }
}
