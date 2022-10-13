using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns];

            for (int i =0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }
                Console.WriteLine();
            }

            /* for (int i = 1; i<=3;i++)
             {
                 Console.WriteLine("цикл 1 итерация №: " + i);
                 for (int j = 1; j <= 5; j++)
                 {
                     Console.WriteLine("\tцикл 2 итерация №: " + j);
                     for (int k = 1; k <= 2; k++)
                     {
                         Console.WriteLine("\t\tцикл 3 итерация №: " + k);
                     }

                 }
             }
            Console.Write("Enter height");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter width");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j <= height; j++) 
            {
                for (int i = 0; i <= width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */


            Console.ReadLine();
        }
    }
}
