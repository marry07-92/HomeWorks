using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие задачи Должно работать так - пользователь вводит размеры участка. Например, a=5, b=10
            //Дальше вводит размеры домов. Например, первый дом 2 на 3, второй дом - 2 на 2
            //Для такого примера программа должна вывести "Да"
            //Другой пример. Участок 3 на 3 Первый дом 5 на 2 Второй дом 1 на 1 Ответ должен быть "Нет"
            //В самой программе нужно проанализировать размеры домов и участка. При этом дом можно поворачивать на 90 градусов, если нужно.
            //Дома можно расположить рядом по "горизонтали" или по "вертикали"

            // Можно ли на прямоугольном участке застройки
            // размером a * b метров разместить два дома размером в плане p * q и r * s метров?
            // Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.

            Console.WriteLine($"Введите габариты участка");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите габариты дома 1");
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите габариты дома 2");
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());



            if (r > a - p) { Console.WriteLine($"Нет"); return; }

            else if (s > b - q) { Console.WriteLine($"Нет"); return; }

            else if (s > a - q) { Console.WriteLine($"Нет"); return; }

            else if (r > b - p) { Console.WriteLine($"Нет"); return; }


            Console.WriteLine($"Да");
            Console.ReadKey();


        }
    }
}
