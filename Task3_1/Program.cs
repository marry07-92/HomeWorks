using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)



            {
                Console.WriteLine($"Число {a} больше числа {b}");
                Console.ReadKey();
            }

            else if (a < b)

            {
                Console.WriteLine($"Число {a} меньше числа {b}");
                Console.ReadKey();
            }

            else if (a == b)

            {
                Console.WriteLine($"Число {a} равно числу {b}");
                Console.ReadKey();
            }
            Console.ReadKey();                        // вопрос по выполненному заданию, после получения результата появляется ошибка не пойму в чем дело  и так на каждой задаче

        }
    }
}
