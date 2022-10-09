using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление, вывод, обращение к массивам.
            Console.WriteLine("Объявление, вывод, обращение к массивам");

            int[] array = new int[10];
            array[1] = 5;
            array[2] = 8;
            array[3] = 15;

            Console.WriteLine(array[1] + " " + array[2] + " " + array[3]);


            //перебирание массивов с помощью цикла for.
            Console.WriteLine("перебирание массивов с помощью циула for");

            int[] array_for = new int[10];
            array_for[4] = 11;
            array_for[7] = 14;

            for (int i = 0; i < array_for.Length; i++)
            {
                Console.WriteLine(array_for[i]);
            }


            //Сокращенные инициализаторы и рандомайзер чисел.
            Console.WriteLine("Сокращенные инициализаторы и рандомайзер чисел.");

            int[] array_small = { 1, 5, 4, 6, 7, 8, 4, 3, 5 };

            for (int i = 0; i < array_small.Length; i++)
            {
                Console.Write(array_small[i] + " ");
            }

            Console.WriteLine("\n\nрандомайзер");

            int[] array_rand = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                array_rand[i] = rand.Next(0, 11);
                Console.Write(array_rand[i] + " ");
            }
            //двухмерные массивы, их объявление, перебирание и сокращённый инициализатор.
            Console.WriteLine("\n\nдвухмерные массивы, их объявление, перебирание и сокращённый инициализатор");

            int[,] array_second = new int[10, 10];

            int[,] array_second_small = new int[3, 3] { { 1, 4, 2 },
                                                        { 5, 6, 9 },
                                                        { 1, 7, 3 } };

            Console.WriteLine(array_second_small[0, 1] + " " + array_second_small[2, 1]);


            //массив - ссылочный тип.
            Console.WriteLine("\nмассив - ссылочный тип");

            int[] temparray = new int[5];
            int[] temparray_second = new int[3];

            temparray_second[0] = 5;

            Console.WriteLine(temparray_second[0] + " " + temparray[0]);

            temparray = temparray_second;

            Console.Write(temparray[0]);
            Console.Write(" " + temparray_second[0]);


            //Расширение массива.
            Console.WriteLine("Расширение массива");

            int[] bag = new int[1];
            //нужно расширить этот массив на одну единицу.
            int[] tempbag = new int[bag.Length + 1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempbag[i] = bag[i];
            }
            tempbag[tempbag.Length - 1] = 15;

            bag = tempbag;

            //результат.
            for(int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i] + " ");
            }
        }  

    }
}













