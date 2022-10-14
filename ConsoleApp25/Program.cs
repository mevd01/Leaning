using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] myarray = new int[3, 5];
            int[,] myarray1 = new int[3, 5];
            string[,] myarray2 = new string[3, 5];
            int height = myarray.GetLength(0);
            int length = myarray.GetLength(1);

            for (int y = 0; y < height; y++)
            {

                for (int x = 0; x < length; x++)
                {
                    myarray[y, x] = random.Next(100);
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            for (int y = 0; y < height; y++)
            {

                for (int x = 0; x < length; x++)
                {
                    myarray1[y, x] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int y = 0; y < height; y++)
            {

                for (int x = 0; x < length; x++)
                {
                    myarray2[y, x] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
