using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        /* стэк - хранения переменных, выполнять логику работу нашей программы (1 мб). Очень быстро убирать и выделяется даннык
         Хип - куча для много, но медленно
        Значимые типы в стеке (enum, struct)
        Ссылочные типы - куча(класс)*/
        //static int a =11;
        static void Main(string[] args)
        {
            //a += 1;
            int a = 1; // Это структура, наследование от ValueType
            Random random = new Random(); // это класс
            // массив - класс, каждый массив наследник Array
            //ConsoleKey - enum, наследование от ValueType
            //ValueType существует в контексте этой переменной, как только выход из контекста, то память освобождается 
            //Классы имеют ссылки на кучу, удаляется не значение, а ссылка 
            //Если копировать классы, то копируется ссылка, а не значение 


        }
    }
}
