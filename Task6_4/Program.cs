using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: 
                "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.


              */


            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите город: ");
            string city = Console.ReadLine();


            StringBuilder result = new StringBuilder();                                          // Формирование строки с использованием AppendFormat
            result.AppendFormat("Имя: {0}, Возраст: {1}, Город: {2}", name, age, city);


            Console.WriteLine(result.ToString());                                               // Вывод результата

            Console.ReadKey();



        }
    }
}
