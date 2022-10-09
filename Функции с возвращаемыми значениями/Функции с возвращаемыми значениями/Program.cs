using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_с_возвращаемыми_значениями
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6, sum;
            sum = Sum(x, y);

            Console.WriteLine(sum);
        }

        //Возвращение значения в функции:
        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }
    }
}
