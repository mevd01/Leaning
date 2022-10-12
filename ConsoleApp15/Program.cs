using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i =0; i<10; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "exit")
                {
                    break;
                }
                Console.WriteLine(i);
            }*/

            for (int i =0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;//чтобы пропустить какую то итерацию, но не завершать цикл
                }
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
