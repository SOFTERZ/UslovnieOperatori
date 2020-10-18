using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите b:");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите c:");
                int c = int.Parse(Console.ReadLine());
                if (a + b > c && a + c > b && c + b > a)
                Console.WriteLine("Можно");
                else Console.WriteLine("Нельзя");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
