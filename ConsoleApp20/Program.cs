using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[4] { 10, 2, 2, 55 };
            for (int i =0; i< myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            int[] myArray1 = new int[4];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = myArray.Length; i >= 0; i--)
            {
                Console.WriteLine(myArray1[i]);
            }

            int summ = 0;

            for (int i = myArray.Length; i >= 0; i--)
            {
                if (myArray1[i] % 2 == 0)
                {
                    summ += myArray1[i];
                }
            }

            Console.WriteLine(summ);

            int minn = myArray1.Min();

            Console.WriteLine(minn);


            Console.ReadLine();

        }
    }
}
