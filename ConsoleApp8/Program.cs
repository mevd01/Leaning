using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++;
            a++;
            a++;
            a--;
            Console.WriteLine(a++);
            Console.WriteLine(--a);

            a = ++a * a;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
