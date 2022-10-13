using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        //условие?если правда:если ложь
        static void Main(string[] args)
        {
            string password = "qwert";
            string user_paswword = Console.ReadLine();

            bool accessallowed = password == user_paswword ? true : false;
            Console.WriteLine(accessallowed);



            int a = int.Parse(Console.ReadLine());
            string b = a < 0 ? "Отрицатльное" : "положительное";
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
