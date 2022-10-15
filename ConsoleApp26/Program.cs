using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][]; //двумернный зубчатый массив (массив массивов)
            int[,] myArray2 = new int[3,5];
            Random random = new Random();

            myArray[0] = new int[5];
            myArray[1] = new int[3];
            myArray[2] = new int[7];
            myArray[0][3] = 55;

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]);
                }
                Console.WriteLine();//переход на следуюшую строчку
            }


            Console.WriteLine(myArray[0][3]);

            int myArrayRank = myArray.Rank;
            int myArrayRank2 = myArray2.Rank;

            int myArrayLength = myArray.Length;
            int myArrayLength2 = myArray2.Length;
        }
    }
}
