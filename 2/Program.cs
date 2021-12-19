using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.CreateText("C:\\BIM\\F1.txt");
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100));
                }
            }
            sw.Close();
            int n, sum = 0;
            string[] file_name = File.ReadAllLines(@"C:\\BIM\\F1.txt");
            Console.Write("\nВыводим данные из файла :  \n" + file_name[0]);
            n = Convert.ToInt32(file_name[0].ToString());
            sum += n;
            Console.Write("\nСумма : {0}\n", sum);
            Console.ReadKey();
        }
    }
}
            
