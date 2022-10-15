using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[3, 4, 5];
            /*{
                {
                    {2,4,5 },
                    {33,55,77 }
                },
                {
                    {324,45,76 },
                    {345,867,89 }
                },
                {
                    {34,54,765 },
                    {34,534,867 }
                }
            };*/
            Random random = new Random();

            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page Number:"+ (i+1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("====================================");
            }

            int[][][] myArray1 = new int[random.Next(3, 6)][][];
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = new int[random.Next(2, 6)][];
                for (int j = 0; j < myArray1[i].Length; j++)
                {
                    myArray1[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArray1[i][j].Length; k++)
                    {
                        myArray1[i] [j] [k] = random.Next(100);
                    }
                }
            }

            //myArray[0, 2, 3] = 44; 


            Console.ReadLine();
        }
    }
}
