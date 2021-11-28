using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории.
            //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            Console.WriteLine("Введите путь к папке");
            string name = Console.ReadLine();
            string path = name;
            Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            string[] allFolders = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (string folder in allFolders)
            {
                Console.WriteLine("Папка {0}", folder);
            }
            string[] allFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in allFiles)
            {
                Console.WriteLine("Файл {0}", file);
            }
            Console.ReadKey();
        }
    }
}