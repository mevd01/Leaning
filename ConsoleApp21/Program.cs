using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {111,10,4,99,49,64,77,4,42,5,111,5 };


            Console.WriteLine(myArray.Max());
            Console.WriteLine(myArray.Min());
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Where(i=>i%2==0).Sum());//лямбда ввыражение где все элементы чентые
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());//самое маленькое нечетное число
            int[] result = myArray.Distinct().ToArray();//избавляемся от лишних элементов массив
            int[] result1 = myArray.OrderBy(i=>i).ToArray();
            int[] result2 = myArray.OrderByDescending(i => i).ToArray();
            Array.Sort(myArray);//array - абстрактный
            int result6 = Array.Find(myArray, i => i < 70);//первое вхождение
            int result7= Array.FindLast(myArray, i => i < 70);//последнее вхождение
            int[] result3 = Array.FindAll(myArray, i => i < 70);
            int a = Array.FindIndex(myArray, i => i == 70);
            Array.Reverse(myArray);

            int resulkt = myArray.Where(i => i < 70).First();
            int resulkt2 = myArray.Where(i => i < 70).FirstOrDefault();//если нет такого элемента то дефолтное значение
            int[] resulkt1 = myArray.Where(i => i < 70).ToArray();

        }
    }
}
