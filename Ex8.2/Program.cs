using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
            string path = "Sum10.txt";
            Console.WriteLine("Введите 10 чисел");
            using (StreamWriter sw = new StreamWriter(path)) //Ведется запись в файл (существующий или создается новый)
            {
                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine()); //Запись массива чисел
                    sw.WriteLine(array[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path)) // Чтение файла
            {
                Console.WriteLine("Сумма чисел в файле");
                int[] array = new int[10];
                int s = 0;
                for (int i = 0; i < 10; i++)
                {
                    string line = sr.ReadLine();
                    array[i] = Convert.ToInt32(line);
                    s += array[i];

                }
                Console.WriteLine();
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}