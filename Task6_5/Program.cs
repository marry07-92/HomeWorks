using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Составить регулярное выражение для проверки корректности номера телефона. Корректный номер имеет формат +7(123)456-78-90.
             */

            // Регулярное выражение для проверки номера телефона
            string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";

            // Примеры номеров для проверки
            string[] phoneNumbers = {
            "+7(123)456-78-90", // Корректный
            "+7(123)456-7890",  // Некорректный (отсутствует дефис)
            "+7(123)4567890",   // Некорректный (отсутствуют скобки и дефисы)
            "+71234567890",     // Некорректный (отсутствуют скобки и дефисы)
            "+7(123)456-78-9",  // Некорректный (недостаточно цифр)
            "+7(123)456-78-901" // Некорректный (лишняя цифра)
                                    };

            // Проверка каждого номера
            foreach (var phone in phoneNumbers)
            {
                bool isValid = Regex.IsMatch(phone, pattern);

                Console.WriteLine($"{phone} -> {(isValid ? "Корректный" : "Некорректный")}");
            }





        }
    }
}
