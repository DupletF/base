using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример встроенной функции, которая приводит все символы к нижнему регистру:
            Console.WriteLine("Пример встроенной функции, которая приводит все символы к нижнему регистру:");

            string a = "SaaSaaDjKKlMM";
            Console.WriteLine(a.ToLower());


            //Объявление функции:
            Console.WriteLine("Объявление функции:\n");

            Console.WriteLine("Привет!");
            WriteError("Ошибка, нет соединения с интернетом!");
            Console.WriteLine("Странно . . .");
            WriteError("Иди плати за интернет!");
            
        }
        static void WriteError(string text)  
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }

       

    }
}
