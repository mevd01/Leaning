using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "2";
            string str2 = "5";
            int chislo = 2;
            int chislo2 = 2000;


            Console.WriteLine(str + str2);
            Console.WriteLine(chislo + chislo2);


            int a = Convert.ToInt32(str);
            int b = Convert.ToInt32(str2);

            string c = Convert.ToString(chislo);
            string d = Convert.ToString(chislo2);


            Console.WriteLine(a + b);
            Console.WriteLine(c + d);


            string stroka = "1.9";//что же делать если разные системы записи например дробного числа???
            // подключаем using System.Globalization;

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo() //создаем экземпляр данного класса
            {
                NumberDecimalSeparator = ".", // сюда передаем сепаратор нужный системы записи
            };

            double A = Convert.ToDouble(str, numberFormatInfo); //в концерт вторым параметром передать наш класс!!









            Console.ReadLine();
        }
    }
}
