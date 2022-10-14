using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray;
            //myArray = new int[5];
            int[] myArray = new int[5] {1,2,3,4,5};
            int[] myArray1 = Enumerable.Repeat(5, 10).ToArray(); // сделать в массив на 10 где все 5
            int[] myArray2 = Enumerable.Range(4,5).ToArray(); //4 5 6 7 8 



            myArray[1] = 3;
            myArray[0] = 10;
            int a = myArray[0];
            Console.WriteLine(myArray.Length);
            Console.WriteLine(myArray[0]);
            Console.ReadLine();
        }
    }
}
