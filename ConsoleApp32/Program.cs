using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            /*if (str == null)
            {
                Console.WriteLine("нет данных");
            }
            else
            {
                Console.WriteLine(str);
            }*/

            Console.WriteLine(str ?? "No data");//?? проверка на null

            string result = str ?? string.Empty;// если пусто то что вписать??

            Console.WriteLine("Количество символов в строке " + result.Length);

        }
    }
}
