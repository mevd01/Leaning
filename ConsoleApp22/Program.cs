using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // тип данных [,] имя_массива - объявление двухмерного массива
            int[,] myarray = //new int[3, 5]
            {
                { 1,54,6,3,56},
                { 2,345,456,345,6},
                { 45,687,345,987,345}
            };

            /*foreach(var item in myarray)
            {
                Console.WriteLine(item);
            }

            //myarray[0, 2] = 99;
            //Console.WriteLine(myarray[0, 2]);*/
            Console.WriteLine(myarray.Rank);//сколько измерений
            Console.WriteLine(myarray.GetLength(0));//сколько элементов в первом измерении
            Console.WriteLine(myarray.GetLength(1));//сколько элементов во втором измерении
            int height = myarray.GetLength(0);
            int length = myarray.GetLength(1);

            for(int y =0;y< height; y++)
            {
                
                for (int x = 0; x < length; x++)
                {
                    Console.Write(myarray[y, x]+"\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
