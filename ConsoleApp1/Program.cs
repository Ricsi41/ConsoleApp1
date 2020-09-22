using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asd");
            int n = 30;
            int x = 1;
            int y = 1;
            Console.WriteLine($"{x} {y} ");
            for (int i = 0; i < n; i++)
            {
                int k = x + y;
                Console.Write($"{k} ");
                x = y;
                y = x;
            }
            Console.ReadKey();
        }
    }
}
