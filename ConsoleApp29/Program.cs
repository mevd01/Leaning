using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        /// <summary>
        /// Возвращает сумму двух целых числе
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum (int a,int b)
        {
            return a + b;
        }

        static int Sum(int a, int b,int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int result = Sum(2, 3);
            int result1 = Sum(2, 3,4);
            double result2 = Sum(3.6, 2.4);
        }
    }
}
