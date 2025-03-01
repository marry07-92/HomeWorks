using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводятся три разных числа. Вывести медиану – среднее по величине число.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());


            if (a > b)

            {
                if (b > c)
                {
                    //получаем трехзначное число, состоящее по возрастанию c + b + a

                    Console.WriteLine("медиана введенных чисел равна {b}");
                    Console.ReadKey();

                }

            }

            else if (a > c)

            {
                {
                    //получаем трехзначное число, состоящее по возрастанию c + a + b

                    Console.WriteLine("медиана введенных чисел равна {a}");
                    Console.ReadKey();
                }

            }

            else if (b > c)
            {
                {
                    //получаем трехзначное число, состоящее по возрастанию a + c + b

                    Console.WriteLine("медиана введенных чисел равна {c}");
                    Console.ReadKey();


                }
            }




        }
    }
}
