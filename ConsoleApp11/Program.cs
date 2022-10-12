using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        public static bool GetTemperature()
        {
            return true;
        }
        public static bool GetCoolingStatus()
        {
            return true;
        }
        static void Main(string[] args)
        {
            /* bool isInfected = false;
             if (!isInfected)
             {
                 Console.WriteLine("Ваш персонаж здоров");
             }
             else
             {
                 Console.WriteLine("Ваш персонаж заболел");
             }*/
            int fanSpeed = 3000;

            bool isHighTemprature = true;
            bool hasNoCooling = fanSpeed <= 0 ;


            if (GetTemperature() | GetTemperature())
            {
                Console.WriteLine("Угроза повредждения процессора!!!");
            }





            /*if (isHighTemprature && hasNoCooling)
            {
                Console.WriteLine("Угроза повредждения процессора!!!");
            }*/
        }
    }
}
