using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void stroka (int a, char b)
        {
            Console.WriteLine(new string(b, a));
        }




        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void PrintLine()
        {
            Console.WriteLine("хи хи ха ха");
        }


        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения  "+ result);
        }

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = Sum(a, b);

            Console.WriteLine(c);
            PrintLine();
            PrintResult(c);
            stroka(5,'!');


            Console.ReadLine();
        }
    }
}
