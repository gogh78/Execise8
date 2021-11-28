using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вручную подготовьте текстовый файл с фрагментом текста.Напишите программу,
            //которая выводит статистику по файлу - количество символов, строк и слов в тексте.
            string path = "Ex8.3.txt";
            int lines = 1;
            int newtLine = '\n';
            string s = "";
            string[] words;
            using (StreamReader sr = new StreamReader(path)) // Чтение файла
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine("Количество символов в тексте - {0}", text.Length); //Подсчет символов в тексте
            }
            using (StreamReader sr = new StreamReader(path)) // Чтение файла
            {
                //Подсчет строк в тексте
                while (!sr.EndOfStream)
                {
                    if (sr.Read() == newtLine)
                    {
                        lines++;
                    }
                }
            }
            using (StreamReader sr = new StreamReader(path)) // Чтение файла
            {
                //Подсчет слов в тексте
                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine();
                }
                words = s.Split(' ');
            }
            Console.WriteLine("Количество строк в тексте - {0}", lines);
            Console.WriteLine("Количество слов в тексте - {0}", words.Length);
            Console.ReadKey();
        }
    }
}
