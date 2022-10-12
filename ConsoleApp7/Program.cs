using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 11;
            int c = 15;
            var result = a + b;
            double result2 = (double) a / b;
            int result3 = a % b;
            int result4 = a + b + c;

            double sredn = (double)(a + b) / 2;


            string chislo1 = Console.ReadLine();
            string chislo2 = Console.ReadLine();
            string chislo3 = Console.ReadLine();

            int a1 = Convert.ToInt32(chislo1);
            int a2 = Convert.ToInt32(chislo2);
            int a3 = Convert.ToInt32(chislo3);

            int resultsr = a1 + a2 + a3;
            int resultmn = a1 * a2 * a3;
            Console.WriteLine(resultsr);
            Console.WriteLine(resultmn);



            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadLine();
        }
    }
}
