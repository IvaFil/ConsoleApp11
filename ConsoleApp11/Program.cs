using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задай первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задай второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
