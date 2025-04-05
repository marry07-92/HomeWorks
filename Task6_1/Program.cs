using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
           Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
            Знаки препинания не используются. Найти самое длинное слово в строке.
          */


        Console.Write("Введите предложение: ");

            string vvod = Console.ReadLine(); //часть для ввода текста

            while (vvod.Contains("  "))         //для того, чтобы в случае ввода с лишними пробелами, очистить для уменьшения времени по перебору
            {
                vvod = vvod.Replace("  ", " ");
            }

    vvod = vvod.Trim();

            string[] words = vvod.Split(); // разделяю предложение на слова



    int maxW = 0, index = 0;

            for (int i = 0; i<words.Length; i++)
            {
                if (words[i].Length >= maxW)  
                {
                    maxW = words[i].Length;

                    index = i;
                }
            }



            Console.Write("Самое длинное слово: {0}", words[index]);


Console.ReadLine();




        }
    }
}
