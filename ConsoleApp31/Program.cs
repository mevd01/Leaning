using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        class MyClass
        {

        }

        struct MyStruct
        {

        }

        static void Foo()
        {
            int b;//удалиться после выхода из метода
            int[] a = new int[10];//ссылка будет удалена, но данные остануться, их уберет сборщик мусора
        }

        static void Main(string[] args)
        {
            bool b;//false
            int a;//0
            double d;//0
            Random ramdon;//null
            int[] arr;//null
            MyClass myClass;//null
            MyStruct myStruct;
            //null - пустая ссылка
            int[] arra = new int[10];//0000000000
            arra = null; // разорвали связь, сборщик мусора очистит ура ура


        }
    }
}
