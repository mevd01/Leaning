using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int limit = int.Parse(Console.ReadLine());
            for (int i =0;i< limit; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (; ; ) 
            {
                Console.WriteLine("For i working");
                System.Threading.Thread.Sleep(300);//задержка между итерациями
            }
            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("for1:"+i);
            }

            for (; i < 5; i++)
            {
                Console.WriteLine("for2:" + i);
            }
            
            for (int i = 0, j = 5; i < 10 && j<12; i++,j++)
            {
                Console.WriteLine("i"+i);
                Console.WriteLine("j" + j);
            }

            for (int i = int.Parse(Console.ReadLine()); i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */
            for (int i = 0, j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i= " + i);
                Console.WriteLine("j= " + j);
            }


            Console.ReadLine();
        }
    }
}
