using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Застройщик построил n домов.
            // Вывести фразу «Мы построили n домов»,
            // обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов»,
            // 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

            var a = Convert.ToString(Console.ReadLine()); //Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
            var b = a.Substring(a.Length - 1);
            int d = Convert.ToInt32((a));
            int c = Convert.ToInt32((b));

            if (c == 1)

            {
                Console.WriteLine($"Мы построили {a} дом");


            }
            else if (c >= 5)
            {

                Console.WriteLine($"Мы построили {a} домов");

            }
            else if (c >= 2 & c <= 4)
            {
                Console.WriteLine($"Мы построили {a} дома");


            }
            else if (c == 0)
            {
                Console.WriteLine($"Мы построили {a} домов");  // не поняла, как исключить число 11 из перебора по c==1

            }

            Console.ReadKey();

        }
    }
}
