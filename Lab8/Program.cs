using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\AutoCAD");
            Console.WriteLine("============Список каталогов=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("==Список подкаталогов==");
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(it.Name);
                Console.WriteLine();
            }
            Console.WriteLine("==============Список файлов==============");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
