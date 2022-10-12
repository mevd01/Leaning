using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            /*switch (a)
            {
                case 1://если нет логики у кейса он будет делать след кейс
                    //{
                    //    Console.WriteLine("вы ввели 1");
                    //    break;
                    //}
                case 2:
                    {
                        Console.WriteLine("вы ввели 1 или 2");
                        break;
                    }

                default:
                    { //для кейса которого нет
                        Console.WriteLine("не знаю такого");
                        break;
                    }*/
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.Backspace:
                    {
                        Console.WriteLine("вы нажали пробел");
                        break;
                    }
                };
            Console.ReadLine();
            
        }
    }
}
