using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*NumberFormatInfo numberFormatIndo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };

            string str = "5";
            string str2 = "5.9";
            int a = int.Parse(str);//в целом тоже самое что и конверт, в основном дял строк
            double A = double.Parse(str2, numberFormatIndo);*/


            string str = "1awdawdawdawd"; //а если пришло такое а надо число достать??
            try
            {
                int a = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }


            string str2 = "1awdawdawd"; //treyparse не бросает исключения, то есть ошибки не будет
            int b;
            //также tryparser возвращает true или false

            bool result = int.TryParse(str, out b);//передается что и куда, out означает, что переменная будет изменана внутри метода(Как я понял)

            if (result)
            {
                Console.WriteLine("Операция успешна, щначение = " + b);
            }
            else
            {
                Console.WriteLine("Не получилось!");
            }
            Console.ReadLine();
        }
    }
}
