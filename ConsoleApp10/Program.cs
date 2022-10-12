using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isInfected = true;
            if (isInfected)
            {
                Console.WriteLine("Ваш персонаж забоелел");
            }
            else
            {
                Console.WriteLine("Ваш персонаж здоров");
            }

            int a;
            a = int.Parse(Console.ReadLine());
            if (a==5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("a!=5");
            }


            int b;
            b = int.Parse(Console.ReadLine());
             if (a % 2 == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }


        }
    }
}
