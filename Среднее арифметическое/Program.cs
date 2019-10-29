using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее_арифметическое
{
    class Program
    {
        static void Main(string[] args)
        {
            Double first, second;
            //ввод числа и его парсинг в double
            Console.WriteLine("Введите число 1");
            first = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            second = double.Parse(Console.ReadLine());

            double result = (first + second) / 2;
            Console.WriteLine("Среднее = " + result);

            //оператор swotch
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("Введено 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Введено 2 или 3");
                    break;
                default:
                    Console.WriteLine("Неизвестный ввод");
                    break;

            }
        }
    }
}
