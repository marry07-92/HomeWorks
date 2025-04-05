using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
               Знаки препинания не используются. Составить программу, определяющую, является ли строка 
                палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
              */

            string revs = "";

            Console.WriteLine(" Введите предложение");

            string vvod = Console.ReadLine(); //часть для ввода текста

            string a = vvod.ToLower(); // привожу к нижнему регистру

            string words = a.Replace(" ", ""); // убираю пробелы

            Console.WriteLine("{0}", words);  // для проверки

            for (int i = words.Length - 1; i >= 0; i--) //реверс
            {
                revs += words[i].ToString();
            }
            if (revs == words) // проверка предложение является палиндромом или нет
            {
                Console.WriteLine("Предложение является палиндром \n Введенное предложение {0} и перевернутое предложение {1}", words, revs);
            }
            else
            {
                Console.WriteLine("Предложение не являеться палиндром \n Введенное предложение {0} и перевернутое предложение {1}", words, revs);
            }
            Console.ReadKey();


        }
    }
}

