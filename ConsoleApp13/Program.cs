using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            int chetchik = 0;
            /*while (count< limit)
            {
                count++;
                //Console.WriteLine(count);
            }*/
            while (count < limit)
            {
                count++;
                if (count % 2 == 0)
                {
                    chetchik++;
                    Console.WriteLine(chetchik);
                }
                //Console.WriteLine(count);
            }
            count = 0;
            do//в отличии while выполнится хотя бы один раз
            {
                count++;
                Console.WriteLine("хи хи");
            } while (count<5);




            Console.WriteLine(chetchik);
            Console.ReadLine();
        }
    }
}
